

using ConsoleApp.Interfaces;
using ConsoleApp.Models.AbstractModels;
using ConsoleApp.Services;
using Newtonsoft.Json;




namespace ConsoleApp.Services
{

    
    public class MenuManagement
    { 
       // Builds a list for all contacts.
        private List<IContact> contacts = new List<IContact>();
        private  DocumentManagement doc = new DocumentManagement();
        public string DocPath { get; set; } = null!;

        // Testet
        public List<Contact> ContactList { get; set; } = null!;
        //slutar här

        public void WelcomeMenu() // shows start menu
        {
            try
            {
                contacts = JsonConvert.DeserializeObject<List<IContact>>(doc.ReadDocuments(DocPath))!;
            }
            catch { }

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
            doc.SavedDocuments(DocPath, JsonConvert.SerializeObject(contacts));
            Console.ReadLine();
            WelcomeMenu();
        }


        private void OptionTwo() // removes contact
        {
            Console.Clear();
            Console.WriteLine("What contact do you want to remove?");
            var input = Console.ReadLine();
            //Should remove a contact. 
            Console.Clear();
            contacts.RemoveAll(contact => contact.FirstName! == input);
            doc.SavedDocuments(DocPath, JsonConvert.SerializeObject(contacts));
            Console.WriteLine("Your contact was removed.");
            Console.WriteLine("Press enter to continue..");
            Console.ReadLine();
            WelcomeMenu();
        }


        private void OptionThree() // shows a specific contact
        {
            
            Console.Clear();
            Console.WriteLine("Write the name of the contact:");
            var contactName = Console.ReadLine();
            //Should show a contact thats saved in the list.
            var findContact = contacts.Find(x => x.FirstName == contactName);
            Console.WriteLine("First name:" + findContact!.FirstName);
            Console.WriteLine("Last name:" + findContact!.LastName);
            Console.WriteLine("Phonenumber:" + findContact!.PhoneNumber);
            Console.WriteLine("Family member:" + findContact!.FamilyMember);
            Console.WriteLine("ICE:" + findContact!.ICE);
            Console.ReadKey();
            WelcomeMenu();

        }
        private void OptionFour() // shows all contacts
        {
            Console.Clear();
            Console.WriteLine("Your Contacts:");
            //Should show all contacts that are saved in the list.
            contacts!.ForEach(contact => Console.WriteLine("Name:" + contact.FirstName + "" + contact.LastName));
            Console.ReadKey();
        }
    }
}
