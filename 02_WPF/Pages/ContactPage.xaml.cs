using _02_WPF.Controls;
using _02_WPF.Models;
using _02_WPF.Services;
using FsCheck;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace _02_WPF.Pages
{
    /// <summary>
    /// Interaction logic for ContactPage.xaml
    /// </summary>
    public partial class ContactPage : Page
    { 

    private ObservableCollection<Contact> contacts = new ObservableCollection<Contact>();
    private readonly DocumentManagement doc = new();

    
        public ContactPage()
        {
            InitializeComponent();
            doc.DocPath = @$"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\content.json";
            PopulateContactList();
        }
    

                
      

    private void PopulateContactList()
    {
        try
        {
            var items = JsonConvert.DeserializeObject<ObservableCollection<Contact>>(doc.ReadDoc());
            if (items != null)
                contacts = items;
        }
        catch
        {

        }
        lv_Contacts.ItemsSource = contacts;
    }

    private void Btn_Add_Contact_Click(object sender, RoutedEventArgs e)
    {
         
        contacts.Add(new Contact
        {
            FirstName = tb_FirstName.Text,
            LastName = tb_LastName.Text,
            PhoneNumber = tb_PhoneNumber.Text,
            FamilyMember = tb_FamilyMember.Text,
            ICE = tb_ICE.Text

        });
        doc.SaveDoc(JsonConvert.SerializeObject(contacts));
        ClearForm();
    }


        private void Btn_Del_Contact_Click(object sender, RoutedEventArgs e)
        {
            
            if (MessageBox.Show("Do You want to delete this contact?", "",MessageBoxButton.YesNo) == MessageBoxResult.No)
            {
               
            }
            else
            {
                if (lv_Contacts.SelectedItem != null)
                {
                    contacts.Remove(lv_Contacts.SelectedItem as Contact);
                    
                }
                doc.SaveDoc(JsonConvert.SerializeObject(contacts));

            }
        }

        private void lv_Contacts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selected = lv_Contacts.SelectedItem as NavButton;
        }


        private void ClearForm()
    {
        tb_FirstName.Text = "";
        tb_LastName.Text = "";
        tb_PhoneNumber.Text = "";
        tb_FamilyMember.Text = "";
        tb_ICE.Text = "";
    }

        private void Btn_Edit_Contact_Click(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            var contact = (Contact)button.DataContext;
            
           
        }

        private void lv_Contact_Selected(object sender, RoutedEventArgs e)
        {
            var ListViewItem = (ListViewItem)sender;
            var contact = (Contact)ListViewItem.DataContext;
            MessageBox.Show(contact.DisplayContact);
        }
    }
}

    

