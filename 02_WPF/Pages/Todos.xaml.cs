using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
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
using _02_WPF.Models;
using _02_WPF.Services;
using Newtonsoft.Json;

namespace _02_WPF.Pages
{
    /// <summary>
    /// Interaction logic for Todos.xaml
    /// </summary>
    public partial class Todos : Page
    {
        private readonly FileService fileService;
        public ObservableCollection<Activity_todo> TodoList { get; set; }
        public Todos()
        {
            InitializeComponent();
            fileService = new FileService();
            TodoList = (ObservableCollection<Activity_todo>)fileService.Activity();
            lv_Todos.ItemsSource = TodoList;
        }
        



    }
}
