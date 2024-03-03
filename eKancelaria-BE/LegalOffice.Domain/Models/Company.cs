using System.ComponentModel.DataAnnotations.Schema;

namespace LegalOffice.Domain.Models
{
    public class Company : Plantiff
    {
        public string Name { get; set; }
        public string? Headquarters { get; set; }
        public string? REGON { get; set; }
        public sbyte? IsRegistered { get; set; }
        public string? KRS { get; set; }
        public PersonForCompany[]? BoardMembers { get; set; }
    }

    public class PersonForCompany
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string? SecondName { get; set; }
        public string LastName { get; set; }
        public string Name { get; set; }
        public string Pesel { get; set; }
        public string? DocumentNumber { get; set; }
        public string? FatherName { get; set; }
        public string? MotherName { get; set; }
        public string? MaidenName { get; set; }
        public string? MotherMaidenName { get; set; }
        public string? PlaceOfBirth { get; set; }
        public string? DateOfBirth { get; set; }
    }
}
