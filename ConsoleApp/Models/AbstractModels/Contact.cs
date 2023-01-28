using ConsoleApp.Interfaces;

namespace ConsoleApp.Models.AbstractModels;

internal class Contact : IContact
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string FamilyMember { get; set; } = null!;
    public int PhoneNumber { get; set; }

    public string ICE { get; set; } = null!;
}
