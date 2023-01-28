

using ConsoleApp.Interfaces;
using ConsoleApp.Models.AbstractModels;
using ConsoleApp.Services;
using Newtonsoft.Json;




namespace ConsoleApp.Services
{
    internal class MenuManagement
    { 

       // Builds a list for all contacts.
        private List<IContact> contacts = new List<IContact>();
        private readonly DocumentManagement doc = new DocumentManagement();
        

       

        public void WelcomeMenu() // shows start menu
        {
            Console.Clear();
            Console.WriteLine("Welcome to the contact list!");
            Console.WriteLine("1.Add Contact");
            Console.WriteLine("2.Remove Contact");
            Console.WriteLine("3.Show a contact");
            Console.WriteLine("4.Show all contacts");
            Console.Write("What do you want to do?: ");
            var option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    OptionOne();
                    break;
                case "2":
                    OptionTwo();
                    break;
                case "3":
                    OptionThree();
                    break;
                case "4":
                    OptionFour();
                    break;
                default:
                    Console.WriteLine("Choose a number from 1-4.");
                    break;
            }
           
        }
        

        private void OptionOne() // adds contact
        {
            
            Console.Clear();
            Console.WriteLine("Add Your contact.");
            IContact contact = new Contact();
            Console.Write("Add a first name:");
            contact.FirstName = Console.ReadLine() ?? null!;
            Console.Write("Add a last name:");
            contact.LastName = Console.ReadLine() ?? null!;
            Console.Write("Add a phone number:");
            contact.PhoneNumber = Convert.ToInt32(Console.ReadLine()); 
            Console.Write("Is contact a family member?");
            contact.FamilyMember = Console.ReadLine() ?? null!;
            Console.Write("is this a ICE contact?");
            contact.ICE = Console.ReadLine() ?? null!;

            
            contacts.Add(contact);
         
            


        }
        private void OptionTwo() // removes contact
        {
            
            Console.Clear();
            Console.WriteLine("What contact do you want to remove?");
            string input = Console.ReadLine() ?? null!;

            //Should remove a contact. 
            IContact contact = contacts.Find(x => x.FirstName == input) ?? null! ; 
            if(contact != null)
            {
                Console.Clear();
                contacts.Remove(contact);
                Console.WriteLine("Your contact was removed.");
                Console.ReadLine();
            }
            
            
        }
        private void OptionThree() // shows a contact
        {
            //Should show a contact thats saved in the list.
            
        }
        private void OptionFour() // shows all contacts
        {
            Console.Clear();
            //Should show all contacts that are saved in the list.
            foreach(Contact contact in contacts)
            {
                Console.WriteLine(contact);
            }

        }
    }
}
