﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//
//     Zmiany w tym pliku mogą spowodować niewłaściwe zachowanie i zostaną utracone
//     w przypadku ponownego wygenerowania kodu.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Gus
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ParametryWyszukiwania", Namespace="http://CIS/BIR/PUBL/2014/07/DataContract")]
    public partial class ParametryWyszukiwania : object
    {
        
        private string KrsField;
        
        private string KrsyField;
        
        private string NipField;
        
        private string NipyField;
        
        private string RegonField;
        
        private string Regony14znField;
        
        private string Regony9znField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Krs
        {
            get
            {
                return this.KrsField;
            }
            set
            {
                this.KrsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Krsy
        {
            get
            {
                return this.KrsyField;
            }
            set
            {
                this.KrsyField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nip
        {
            get
            {
                return this.NipField;
            }
            set
            {
                this.NipField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nipy
        {
            get
            {
                return this.NipyField;
            }
            set
            {
                this.NipyField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Regon
        {
            get
            {
                return this.RegonField;
            }
            set
            {
                this.RegonField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Regony14zn
        {
            get
            {
                return this.Regony14znField;
            }
            set
            {
                this.Regony14znField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Regony9zn
        {
            get
            {
                return this.Regony9znField;
            }
            set
            {
                this.Regony9znField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Gus.IUslugaBIRzewnPubl")]
    public interface IUslugaBIRzewnPubl
    {
        
        // CODEGEN: Trwa generowanie kontraktu komunikatu, ponieważ przestrzeń nazw otoki (http://CIS/BIR/2014/07) komunikatu GetValueRequest nie pasuje do domyślnej wartości (http://tempuri.org/)
        [System.ServiceModel.OperationContractAttribute(Action="http://CIS/BIR/2014/07/IUslugaBIR/GetValue", ReplyAction="http://CIS/BIR/2014/07/IUslugaBIR/GetValueResponse")]
        Gus.GetValueResponse GetValue(Gus.GetValueRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://CIS/BIR/2014/07/IUslugaBIR/GetValue", ReplyAction="http://CIS/BIR/2014/07/IUslugaBIR/GetValueResponse")]
        System.Threading.Tasks.Task<Gus.GetValueResponse> GetValueAsync(Gus.GetValueRequest request);
        
        // CODEGEN: Trwa generowanie kontraktu komunikatu, ponieważ przestrzeń nazw otoki (http://CIS/BIR/PUBL/2014/07) komunikatu ZalogujRequest nie pasuje do domyślnej wartości (http://tempuri.org/)
        [System.ServiceModel.OperationContractAttribute(Action="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/Zaloguj", ReplyAction="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/ZalogujResponse")]
        Gus.ZalogujResponse Zaloguj(Gus.ZalogujRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/Zaloguj", ReplyAction="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/ZalogujResponse")]
        System.Threading.Tasks.Task<Gus.ZalogujResponse> ZalogujAsync(Gus.ZalogujRequest request);
        
        // CODEGEN: Trwa generowanie kontraktu komunikatu, ponieważ przestrzeń nazw otoki (http://CIS/BIR/PUBL/2014/07) komunikatu WylogujRequest nie pasuje do domyślnej wartości (http://tempuri.org/)
        [System.ServiceModel.OperationContractAttribute(Action="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/Wyloguj", ReplyAction="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/WylogujResponse")]
        Gus.WylogujResponse Wyloguj(Gus.WylogujRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/Wyloguj", ReplyAction="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/WylogujResponse")]
        System.Threading.Tasks.Task<Gus.WylogujResponse> WylogujAsync(Gus.WylogujRequest request);
        
        // CODEGEN: Trwa generowanie kontraktu komunikatu, ponieważ przestrzeń nazw otoki (http://CIS/BIR/PUBL/2014/07) komunikatu DaneSzukajPodmiotyRequest nie pasuje do domyślnej wartości (http://tempuri.org/)
        [System.ServiceModel.OperationContractAttribute(Action="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/DaneSzukajPodmioty", ReplyAction="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/DaneSzukajPodmiotyResponse")]
        Gus.DaneSzukajPodmiotyResponse DaneSzukajPodmioty(Gus.DaneSzukajPodmiotyRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/DaneSzukajPodmioty", ReplyAction="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/DaneSzukajPodmiotyResponse")]
        System.Threading.Tasks.Task<Gus.DaneSzukajPodmiotyResponse> DaneSzukajPodmiotyAsync(Gus.DaneSzukajPodmiotyRequest request);
        
        // CODEGEN: Trwa generowanie kontraktu komunikatu, ponieważ przestrzeń nazw otoki (http://CIS/BIR/PUBL/2014/07) komunikatu DanePobierzPelnyRaportRequest nie pasuje do domyślnej wartości (http://tempuri.org/)
        [System.ServiceModel.OperationContractAttribute(Action="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/DanePobierzPelnyRaport", ReplyAction="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/DanePobierzPelnyRaportResponse")]
        Gus.DanePobierzPelnyRaportResponse DanePobierzPelnyRaport(Gus.DanePobierzPelnyRaportRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/DanePobierzPelnyRaport", ReplyAction="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/DanePobierzPelnyRaportResponse")]
        System.Threading.Tasks.Task<Gus.DanePobierzPelnyRaportResponse> DanePobierzPelnyRaportAsync(Gus.DanePobierzPelnyRaportRequest request);
        
        // CODEGEN: Trwa generowanie kontraktu komunikatu, ponieważ przestrzeń nazw otoki (http://CIS/BIR/PUBL/2014/07) komunikatu DanePobierzRaportZbiorczyRequest nie pasuje do domyślnej wartości (http://tempuri.org/)
        [System.ServiceModel.OperationContractAttribute(Action="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/DanePobierzRaportZbiorczy", ReplyAction="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/DanePobierzRaportZbiorczyResponse")]
        Gus.DanePobierzRaportZbiorczyResponse DanePobierzRaportZbiorczy(Gus.DanePobierzRaportZbiorczyRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/DanePobierzRaportZbiorczy", ReplyAction="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/DanePobierzRaportZbiorczyResponse")]
        System.Threading.Tasks.Task<Gus.DanePobierzRaportZbiorczyResponse> DanePobierzRaportZbiorczyAsync(Gus.DanePobierzRaportZbiorczyRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetValue", WrapperNamespace="http://CIS/BIR/2014/07", IsWrapped=true)]
    public partial class GetValueRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://CIS/BIR/2014/07", Order=0)]
        public string pNazwaParametru;
        
        public GetValueRequest()
        {
        }
        
        public GetValueRequest(string pNazwaParametru)
        {
            this.pNazwaParametru = pNazwaParametru;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetValueResponse", WrapperNamespace="http://CIS/BIR/2014/07", IsWrapped=true)]
    public partial class GetValueResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://CIS/BIR/2014/07", Order=0)]
        public string GetValueResult;
        
        public GetValueResponse()
        {
        }
        
        public GetValueResponse(string GetValueResult)
        {
            this.GetValueResult = GetValueResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Zaloguj", WrapperNamespace="http://CIS/BIR/PUBL/2014/07", IsWrapped=true)]
    public partial class ZalogujRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://CIS/BIR/PUBL/2014/07", Order=0)]
        public string pKluczUzytkownika;
        
        public ZalogujRequest()
        {
        }
        
        public ZalogujRequest(string pKluczUzytkownika)
        {
            this.pKluczUzytkownika = pKluczUzytkownika;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ZalogujResponse", WrapperNamespace="http://CIS/BIR/PUBL/2014/07", IsWrapped=true)]
    public partial class ZalogujResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://CIS/BIR/PUBL/2014/07", Order=0)]
        public string ZalogujResult;
        
        public ZalogujResponse()
        {
        }
        
        public ZalogujResponse(string ZalogujResult)
        {
            this.ZalogujResult = ZalogujResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Wyloguj", WrapperNamespace="http://CIS/BIR/PUBL/2014/07", IsWrapped=true)]
    public partial class WylogujRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://CIS/BIR/PUBL/2014/07", Order=0)]
        public string pIdentyfikatorSesji;
        
        public WylogujRequest()
        {
        }
        
        public WylogujRequest(string pIdentyfikatorSesji)
        {
            this.pIdentyfikatorSesji = pIdentyfikatorSesji;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="WylogujResponse", WrapperNamespace="http://CIS/BIR/PUBL/2014/07", IsWrapped=true)]
    public partial class WylogujResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://CIS/BIR/PUBL/2014/07", Order=0)]
        public bool WylogujResult;
        
        public WylogujResponse()
        {
        }
        
        public WylogujResponse(bool WylogujResult)
        {
            this.WylogujResult = WylogujResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DaneSzukajPodmioty", WrapperNamespace="http://CIS/BIR/PUBL/2014/07", IsWrapped=true)]
    public partial class DaneSzukajPodmiotyRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://CIS/BIR/PUBL/2014/07", Order=0)]
        public Gus.ParametryWyszukiwania pParametryWyszukiwania;
        
        public DaneSzukajPodmiotyRequest()
        {
        }
        
        public DaneSzukajPodmiotyRequest(Gus.ParametryWyszukiwania pParametryWyszukiwania)
        {
            this.pParametryWyszukiwania = pParametryWyszukiwania;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DaneSzukajPodmiotyResponse", WrapperNamespace="http://CIS/BIR/PUBL/2014/07", IsWrapped=true)]
    public partial class DaneSzukajPodmiotyResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://CIS/BIR/PUBL/2014/07", Order=0)]
        public string DaneSzukajPodmiotyResult;
        
        public DaneSzukajPodmiotyResponse()
        {
        }
        
        public DaneSzukajPodmiotyResponse(string DaneSzukajPodmiotyResult)
        {
            this.DaneSzukajPodmiotyResult = DaneSzukajPodmiotyResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DanePobierzPelnyRaport", WrapperNamespace="http://CIS/BIR/PUBL/2014/07", IsWrapped=true)]
    public partial class DanePobierzPelnyRaportRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://CIS/BIR/PUBL/2014/07", Order=0)]
        public string pRegon;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://CIS/BIR/PUBL/2014/07", Order=1)]
        public string pNazwaRaportu;
        
        public DanePobierzPelnyRaportRequest()
        {
        }
        
        public DanePobierzPelnyRaportRequest(string pRegon, string pNazwaRaportu)
        {
            this.pRegon = pRegon;
            this.pNazwaRaportu = pNazwaRaportu;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DanePobierzPelnyRaportResponse", WrapperNamespace="http://CIS/BIR/PUBL/2014/07", IsWrapped=true)]
    public partial class DanePobierzPelnyRaportResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://CIS/BIR/PUBL/2014/07", Order=0)]
        public string DanePobierzPelnyRaportResult;
        
        public DanePobierzPelnyRaportResponse()
        {
        }
        
        public DanePobierzPelnyRaportResponse(string DanePobierzPelnyRaportResult)
        {
            this.DanePobierzPelnyRaportResult = DanePobierzPelnyRaportResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DanePobierzRaportZbiorczy", WrapperNamespace="http://CIS/BIR/PUBL/2014/07", IsWrapped=true)]
    public partial class DanePobierzRaportZbiorczyRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://CIS/BIR/PUBL/2014/07", Order=0)]
        public string pDataRaportu;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://CIS/BIR/PUBL/2014/07", Order=1)]
        public string pNazwaRaportu;
        
        public DanePobierzRaportZbiorczyRequest()
        {
        }
        
        public DanePobierzRaportZbiorczyRequest(string pDataRaportu, string pNazwaRaportu)
        {
            this.pDataRaportu = pDataRaportu;
            this.pNazwaRaportu = pNazwaRaportu;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DanePobierzRaportZbiorczyResponse", WrapperNamespace="http://CIS/BIR/PUBL/2014/07", IsWrapped=true)]
    public partial class DanePobierzRaportZbiorczyResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://CIS/BIR/PUBL/2014/07", Order=0)]
        public string DanePobierzRaportZbiorczyResult;
        
        public DanePobierzRaportZbiorczyResponse()
        {
        }
        
        public DanePobierzRaportZbiorczyResponse(string DanePobierzRaportZbiorczyResult)
        {
            this.DanePobierzRaportZbiorczyResult = DanePobierzRaportZbiorczyResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface IUslugaBIRzewnPublChannel : Gus.IUslugaBIRzewnPubl, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class UslugaBIRzewnPublClient : System.ServiceModel.ClientBase<Gus.IUslugaBIRzewnPubl>, Gus.IUslugaBIRzewnPubl
    {
        
        /// <summary>
        /// Wdróż tę metodę częściową, aby skonfigurować punkt końcowy usługi.
        /// </summary>
        /// <param name="serviceEndpoint">Punkt końcowy do skonfigurowania</param>
        /// <param name="clientCredentials">Poświadczenia klienta</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public UslugaBIRzewnPublClient() : 
                base(UslugaBIRzewnPublClient.GetDefaultBinding(), UslugaBIRzewnPublClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.e3.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public UslugaBIRzewnPublClient(EndpointConfiguration endpointConfiguration) : 
                base(UslugaBIRzewnPublClient.GetBindingForEndpoint(endpointConfiguration), UslugaBIRzewnPublClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public UslugaBIRzewnPublClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(UslugaBIRzewnPublClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public UslugaBIRzewnPublClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(UslugaBIRzewnPublClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public UslugaBIRzewnPublClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Gus.GetValueResponse Gus.IUslugaBIRzewnPubl.GetValue(Gus.GetValueRequest request)
        {
            return base.Channel.GetValue(request);
        }
        
        public string GetValue(string pNazwaParametru)
        {
            Gus.GetValueRequest inValue = new Gus.GetValueRequest();
            inValue.pNazwaParametru = pNazwaParametru;
            Gus.GetValueResponse retVal = ((Gus.IUslugaBIRzewnPubl)(this)).GetValue(inValue);
            return retVal.GetValueResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Gus.GetValueResponse> Gus.IUslugaBIRzewnPubl.GetValueAsync(Gus.GetValueRequest request)
        {
            return base.Channel.GetValueAsync(request);
        }
        
        public System.Threading.Tasks.Task<Gus.GetValueResponse> GetValueAsync(string pNazwaParametru)
        {
            Gus.GetValueRequest inValue = new Gus.GetValueRequest();
            inValue.pNazwaParametru = pNazwaParametru;
            return ((Gus.IUslugaBIRzewnPubl)(this)).GetValueAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Gus.ZalogujResponse Gus.IUslugaBIRzewnPubl.Zaloguj(Gus.ZalogujRequest request)
        {
            return base.Channel.Zaloguj(request);
        }
        
        public string Zaloguj(string pKluczUzytkownika)
        {
            Gus.ZalogujRequest inValue = new Gus.ZalogujRequest();
            inValue.pKluczUzytkownika = pKluczUzytkownika;
            Gus.ZalogujResponse retVal = ((Gus.IUslugaBIRzewnPubl)(this)).Zaloguj(inValue);
            return retVal.ZalogujResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Gus.ZalogujResponse> Gus.IUslugaBIRzewnPubl.ZalogujAsync(Gus.ZalogujRequest request)
        {
            return base.Channel.ZalogujAsync(request);
        }
        
        public System.Threading.Tasks.Task<Gus.ZalogujResponse> ZalogujAsync(string pKluczUzytkownika)
        {
            Gus.ZalogujRequest inValue = new Gus.ZalogujRequest();
            inValue.pKluczUzytkownika = pKluczUzytkownika;
            return ((Gus.IUslugaBIRzewnPubl)(this)).ZalogujAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Gus.WylogujResponse Gus.IUslugaBIRzewnPubl.Wyloguj(Gus.WylogujRequest request)
        {
            return base.Channel.Wyloguj(request);
        }
        
        public bool Wyloguj(string pIdentyfikatorSesji)
        {
            Gus.WylogujRequest inValue = new Gus.WylogujRequest();
            inValue.pIdentyfikatorSesji = pIdentyfikatorSesji;
            Gus.WylogujResponse retVal = ((Gus.IUslugaBIRzewnPubl)(this)).Wyloguj(inValue);
            return retVal.WylogujResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Gus.WylogujResponse> Gus.IUslugaBIRzewnPubl.WylogujAsync(Gus.WylogujRequest request)
        {
            return base.Channel.WylogujAsync(request);
        }
        
        public System.Threading.Tasks.Task<Gus.WylogujResponse> WylogujAsync(string pIdentyfikatorSesji)
        {
            Gus.WylogujRequest inValue = new Gus.WylogujRequest();
            inValue.pIdentyfikatorSesji = pIdentyfikatorSesji;
            return ((Gus.IUslugaBIRzewnPubl)(this)).WylogujAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Gus.DaneSzukajPodmiotyResponse Gus.IUslugaBIRzewnPubl.DaneSzukajPodmioty(Gus.DaneSzukajPodmiotyRequest request)
        {
            return base.Channel.DaneSzukajPodmioty(request);
        }
        
        public string DaneSzukajPodmioty(Gus.ParametryWyszukiwania pParametryWyszukiwania)
        {
            Gus.DaneSzukajPodmiotyRequest inValue = new Gus.DaneSzukajPodmiotyRequest();
            inValue.pParametryWyszukiwania = pParametryWyszukiwania;
            Gus.DaneSzukajPodmiotyResponse retVal = ((Gus.IUslugaBIRzewnPubl)(this)).DaneSzukajPodmioty(inValue);
            return retVal.DaneSzukajPodmiotyResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Gus.DaneSzukajPodmiotyResponse> Gus.IUslugaBIRzewnPubl.DaneSzukajPodmiotyAsync(Gus.DaneSzukajPodmiotyRequest request)
        {
            return base.Channel.DaneSzukajPodmiotyAsync(request);
        }
        
        public System.Threading.Tasks.Task<Gus.DaneSzukajPodmiotyResponse> DaneSzukajPodmiotyAsync(Gus.ParametryWyszukiwania pParametryWyszukiwania)
        {
            Gus.DaneSzukajPodmiotyRequest inValue = new Gus.DaneSzukajPodmiotyRequest();
            inValue.pParametryWyszukiwania = pParametryWyszukiwania;
            return ((Gus.IUslugaBIRzewnPubl)(this)).DaneSzukajPodmiotyAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Gus.DanePobierzPelnyRaportResponse Gus.IUslugaBIRzewnPubl.DanePobierzPelnyRaport(Gus.DanePobierzPelnyRaportRequest request)
        {
            return base.Channel.DanePobierzPelnyRaport(request);
        }
        
        public string DanePobierzPelnyRaport(string pRegon, string pNazwaRaportu)
        {
            Gus.DanePobierzPelnyRaportRequest inValue = new Gus.DanePobierzPelnyRaportRequest();
            inValue.pRegon = pRegon;
            inValue.pNazwaRaportu = pNazwaRaportu;
            Gus.DanePobierzPelnyRaportResponse retVal = ((Gus.IUslugaBIRzewnPubl)(this)).DanePobierzPelnyRaport(inValue);
            return retVal.DanePobierzPelnyRaportResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Gus.DanePobierzPelnyRaportResponse> Gus.IUslugaBIRzewnPubl.DanePobierzPelnyRaportAsync(Gus.DanePobierzPelnyRaportRequest request)
        {
            return base.Channel.DanePobierzPelnyRaportAsync(request);
        }
        
        public System.Threading.Tasks.Task<Gus.DanePobierzPelnyRaportResponse> DanePobierzPelnyRaportAsync(string pRegon, string pNazwaRaportu)
        {
            Gus.DanePobierzPelnyRaportRequest inValue = new Gus.DanePobierzPelnyRaportRequest();
            inValue.pRegon = pRegon;
            inValue.pNazwaRaportu = pNazwaRaportu;
            return ((Gus.IUslugaBIRzewnPubl)(this)).DanePobierzPelnyRaportAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Gus.DanePobierzRaportZbiorczyResponse Gus.IUslugaBIRzewnPubl.DanePobierzRaportZbiorczy(Gus.DanePobierzRaportZbiorczyRequest request)
        {
            return base.Channel.DanePobierzRaportZbiorczy(request);
        }
        
        public string DanePobierzRaportZbiorczy(string pDataRaportu, string pNazwaRaportu)
        {
            Gus.DanePobierzRaportZbiorczyRequest inValue = new Gus.DanePobierzRaportZbiorczyRequest();
            inValue.pDataRaportu = pDataRaportu;
            inValue.pNazwaRaportu = pNazwaRaportu;
            Gus.DanePobierzRaportZbiorczyResponse retVal = ((Gus.IUslugaBIRzewnPubl)(this)).DanePobierzRaportZbiorczy(inValue);
            return retVal.DanePobierzRaportZbiorczyResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Gus.DanePobierzRaportZbiorczyResponse> Gus.IUslugaBIRzewnPubl.DanePobierzRaportZbiorczyAsync(Gus.DanePobierzRaportZbiorczyRequest request)
        {
            return base.Channel.DanePobierzRaportZbiorczyAsync(request);
        }
        
        public System.Threading.Tasks.Task<Gus.DanePobierzRaportZbiorczyResponse> DanePobierzRaportZbiorczyAsync(string pDataRaportu, string pNazwaRaportu)
        {
            Gus.DanePobierzRaportZbiorczyRequest inValue = new Gus.DanePobierzRaportZbiorczyRequest();
            inValue.pDataRaportu = pDataRaportu;
            inValue.pNazwaRaportu = pNazwaRaportu;
            return ((Gus.IUslugaBIRzewnPubl)(this)).DanePobierzRaportZbiorczyAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.e3))
            {
                System.ServiceModel.Channels.CustomBinding result = new System.ServiceModel.Channels.CustomBinding();
                System.ServiceModel.Channels.TextMessageEncodingBindingElement textBindingElement = new System.ServiceModel.Channels.TextMessageEncodingBindingElement();
                result.Elements.Add(textBindingElement);
                System.ServiceModel.Channels.HttpsTransportBindingElement httpsBindingElement = new System.ServiceModel.Channels.HttpsTransportBindingElement();
                httpsBindingElement.AllowCookies = true;
                httpsBindingElement.MaxBufferSize = int.MaxValue;
                httpsBindingElement.MaxReceivedMessageSize = int.MaxValue;
                result.Elements.Add(httpsBindingElement);
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Nie można znaleźć punktu końcowego o nazwie „{0}”.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.e3))
            {
                return new System.ServiceModel.EndpointAddress("https://wyszukiwarkaregon.stat.gov.pl/wsBIR/UslugaBIRzewnPubl.svc");
            }
            throw new System.InvalidOperationException(string.Format("Nie można znaleźć punktu końcowego o nazwie „{0}”.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return UslugaBIRzewnPublClient.GetBindingForEndpoint(EndpointConfiguration.e3);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return UslugaBIRzewnPublClient.GetEndpointAddress(EndpointConfiguration.e3);
        }
        
        public enum EndpointConfiguration
        {
            
            e3,
        }
    }
}
