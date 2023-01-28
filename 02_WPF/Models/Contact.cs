using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_WPF.Models
{

    internal interface IContact
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string PhoneNumber { get; set; }
        string FamilyMember { get; set; }
        string ICE { get; set; }

        

    }
    internal class Contact : IContact
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string FamilyMember { get; set; } = null!;
        public string ICE { get; set; } = null!;

        public string DisplayContact => $"{FirstName} {LastName}";
        
        
    }
}
