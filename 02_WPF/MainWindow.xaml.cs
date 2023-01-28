using _02_WPF.Models;
using _02_WPF.Services;
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
using _02_WPF.Controls;
using System.Windows.Controls.Primitives;

namespace _02_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
      


        public MainWindow()
        {
            InitializeComponent();
          

        }
        private void lbx_NavMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selected = lbx_NavMenu.SelectedItem as NavButton;
            frame_PageFrame.Navigate(selected?.NavLink);
        }

        private void frame_PageFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
