
namespace ConsoleApp.Interfaces
{
    internal interface IContact
    {
        
        string FirstName { get; set; }
        string LastName { get; set; }
        string FamilyMember { get; set; }
        int PhoneNumber { get; set; }
        string ICE { get; set; }
        string DisplayContact => $"{FirstName} | {LastName} | {PhoneNumber} | {FamilyMember} |{ICE}";
        
    }
}
