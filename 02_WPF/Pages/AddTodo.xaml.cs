using _02_WPF.Models;
using _02_WPF.Services;
using System;
using System.Collections.Generic;
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
    /// Interaction logic for AddTodo.xaml
    /// </summary>
    public partial class AddTodo : Page
    {
        private readonly FileService fileService;
        public AddTodo()
        {
            InitializeComponent();
            fileService = new FileService();
        }

        private void btn_add_Activity_Click(object sender, RoutedEventArgs e)
        {
            fileService.AddToList(new Activity_todo { Text = tb_enter_Activity.Text });
            tb_enter_Activity.Text = string.Empty;

        }

    }
}
