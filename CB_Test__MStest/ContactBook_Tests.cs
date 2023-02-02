using ConsoleApp.Models.AbstractModels;
using ConsoleApp.Services;

namespace CB_Test__MStest
{
    [TestClass]

    public class ContactBook_Tests
    {
        [TestMethod]
        public void Shoud_Add_Contact_To_List()
        {
            //Arrange
            MenuManagement menuManagement = new MenuManagement();
            menuManagement.ContactList = new List<Contact>();
            Contact contact = new Contact();
           

            // Act
            menuManagement.ContactList.Add(contact);

            // Assert
            Assert.AreEqual(1, menuManagement.ContactList.Count);
        }






    }
}