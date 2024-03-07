using eCourtService;
using LegalOffice.Domain.Models;
using LegalOffice.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using eCourt;
using Microsoft.Extensions.Options;

namespace LegalOffice.Services
{
    public interface ILawsuitService
    {
        public Task SendLawsuit(int id);
    }
    public class LawsuitService : ILawsuitService
    {
        private readonly ILawsuitRepository _lawsuitRepository;
        private readonly ECourtSettings _eCourtSettings;

        public LawsuitService(ILawsuitRepository lawsuitRepository, IOptions<ECourtSettings> eCourtSettings)
        {
            _lawsuitRepository = lawsuitRepository;
            _eCourtSettings = eCourtSettings.Value;
        }

        public async Task SendLawsuit(int id)
        {
            var lawsuit = await _lawsuitRepository.Get(id);
            await Sent(lawsuit);

        }

        private async Task Sent(Lawsuit lawsuit)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Pozwy));

            Encoding utf8Encoding = new UTF8Encoding(false);

            using (MemoryStream memoryStream = new MemoryStream())
            {
                using (XmlTextWriter xmlWriter = new XmlTextWriter(memoryStream, utf8Encoding))
                {
                    xmlWriter.Formatting = Formatting.Indented;
                    serializer.Serialize(xmlWriter, GetLawsuitsToSend(lawsuit));

                    byte[] xmlBytes = memoryStream.ToArray();

                    string xmlString = utf8Encoding.GetString(xmlBytes);

                    Console.WriteLine("Obiekt został zserializowany do ciągu znaków XML:");
                    Console.WriteLine(xmlString);
                    var client = new EpuServiceClient();
                    try
                    {
                        await client.ZlozPozwyAsync(_eCourtSettings.Username,_eCourtSettings.Password,_eCourtSettings.ApiKey,xmlString);
                    }
                    catch (FaultException<ZlozPozwyOutputData> ex)
                    {
                        var exception = ex.InnerException;
                        Console.WriteLine("Wiadomosc: " + ex.Message);
                        Console.WriteLine("Kod wiadomosci: " + ex.Detail.kod);
                        Console.WriteLine("Informacja: " +
                        ex.Detail.informacja);
                        Console.WriteLine("Opis : " + ex.Detail.opis);
                        if (ex.Detail.kod == KodOdpowiedzi.ValidationError)
                        {
                            foreach (ZlozPozwyOutputElement element in
                            ex.Detail.wynikiWalidacji)
                            {
                                Console.WriteLine("Kod walidacji: " +
                                element.kodWalidacji);
                                Console.WriteLine("Kod walidacji pozwu: " +
                                element.kodWalidacjiPozwu);
                                Console.WriteLine("Liczba porzadkowa pozwu: " +
                            element.liczbaPorzadkowa);
                                Console.WriteLine("Opis walidacji: " +
                                element.opisWalidacji);
                            }
                        }
                        Console.ReadKey();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        Console.ReadKey();
                    }
                }
            }
        }

        private typStrona GetPlantiffToSend(Plantiff plantiff)
        {
            object item = null;
            if (plantiff is Company company)
            {
                item = new typInstytucja
                {
                    Nazwa = company.Name,
                    REGON = company.REGON,
                    czyRejestr = (sbyte)company.IsRegistered,
                };
            }
            if(plantiff is Person person)
            {
                item = new typOsobaFizyczna
                {
                    Imie = person.FirstName,
                    Nazwisko = person.LastName,
                    PESEL = person.Pesel,
                };
            }

            return new typStrona
            {
                Obcokrajowiec = plantiff.IsForeigner,
                ObcokrajowiecString = "obywatelstwo polskie",
                BrakNumerowIdentyfikacyjnych = plantiff.LacksIdentificationNumbers,
                reprezentacja = plantiff.Representation,
                rodzajStrony = (sbyte)plantiff.PartyType,
                ID = (ulong)plantiff.Id,
                numerKonta = plantiff.AccountNumber,
                NIP = plantiff.Tin,
                Adres = new typAdres
                {
                    ulica = plantiff.Address.Street,
                    nr_domu = plantiff.Address.HouseNumber,
                    kod = plantiff.Address.PostalCode,
                    miejscowosc = plantiff.Address.City,
                },
                Item = item
            };
        }

        private typRoszczenie GetClaimToSend(Claim claim)
        {
            return new typRoszczenie
            {
                numer = claim.Id,
                wartosc = claim.Value,
                waluta = (typWaluta)claim.Currency,
                odsetki = claim.InterestRate,
                solidarnie = claim.Jointly,
                typ = claim.Type,
                Dowody = claim.Proofs,
                dataWymagalnosci = claim.DueDate,
            };
        }

        private PozewEPU GetLawsuiteToSend(Lawsuit lawsuit)
        {
            var listaPowodow = lawsuit.Plantiffs.Select(p => GetPlantiffToSend(p)).ToArray();
            var listaPozwanych = lawsuit.Defendant.Select(p => GetPlantiffToSend(p)).ToArray(); 
            var lawsuitToSent = new PozewEPU
            {
                version = "2.0",
                ID = (ulong)lawsuit.Id,
                dataZlozenia = DateTime.Now.ToString("yyyy-MM-dd"),
                Adresat = new typAdresat
                {
                    Nazwa = lawsuit.Addressee.Name,
                    Wydzial = lawsuit.Addressee.Division,
                    Adres = new typAdres
                    {
                        ulica = lawsuit.Addressee.Address.Street,
                        nr_domu = lawsuit.Addressee.Address.HouseNumber,
                        kod = lawsuit.Addressee.Address.PostalCode,
                        miejscowosc = lawsuit.Addressee.Address.City,
                    }

                },
                ListaPowodow = listaPowodow,
                ListaPozwanych = listaPozwanych,
                OsobaSkladajaca = new typSkladajacy
                {
                    pelnomocnik = lawsuit.Submitter.Proxy,
                    podstawa = lawsuit.Submitter.Basis,
                    Osoba= new typOsoba
                    {
                        Imie = lawsuit.Submitter.Person.FirstName,
                        Nazwisko = lawsuit.Submitter.Person.LastName,
                        PESEL = lawsuit.Submitter.Person.Pesel,
                    },
                    Adres = new typAdres
                    {
                        ulica = lawsuit.Submitter.Address.Street,
                        nr_domu = lawsuit.Submitter.Address.HouseNumber,
                        kod = lawsuit.Submitter.Address.PostalCode,
                        miejscowosc = lawsuit.Submitter.Address.City,
                    },
                },
                ListaRoszczen = lawsuit.Claims.Select(c => GetClaimToSend(c)).ToArray(),
                Uzasadnienie = lawsuit.Ground,
                WartoscSporu = lawsuit.AmountOfControversy,
                OplataSadowa = new typOplata
                {
                    zasadzenie = lawsuit.Fee.Adjudication,
                    ObnizenieKosztowOplatySadowej = lawsuit.Fee.ReducedCourtFee,
                    ObnizenieKosztowOplatySadowejSpecified = lawsuit.Fee.ReducedCourtFeeSpecified,
                    wartosc = lawsuit.Fee.Value,
                    zwolnienie = lawsuit.Fee.Exemption,
                    identyfikator = lawsuit.Fee.Identifier,
                    identyfikatorSpecified = lawsuit.Fee.IdentifierSpecified,
                },
                KosztyZastepstwa = new typKoszty
                {
                    wartosc = lawsuit.Cost.Value,
                    zasadzenie = (sbyte)lawsuit.Cost.Adjudication,
                    opis = lawsuit.Cost.Description,
                },
                RachunekDoZwrotuOplat = new typRachunekDoZwrotuOplat
                {
                    WlascicielRachunku = lawsuit.RefundAccount.AccountOwner,
                    NumerRachunkuDoZwrotuOplat = lawsuit.RefundAccount.RefundAccountNumber,
                }
            };

            return lawsuitToSent;
        }

        private Pozwy GetLawsuitsToSend(Lawsuit lawsuit)
        {
            var pozwy = new Pozwy { OznaczeniePaczki = $"{DateTime.Now} - {lawsuit.Submitter.Name}" };
            pozwy.PozewEPU = new[] { GetLawsuiteToSend(lawsuit) };
            return pozwy;
        }


    }


}
