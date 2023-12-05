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

namespace Registeration_And_Login_Desktop_Application_Assecment
{
    /// <summary>
    /// Interaction logic for Admin_Page.xaml
    /// </summary>
    public partial class Admin_Page : Page
    {
        public Admin_Page()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Delete_Admin delete = new Delete_Admin();
            this.NavigationService.Navigate(delete);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           Add_Page_Admin Search = new Add_Page_Admin();
            this.NavigationService.Navigate(Search);
        }
    }
}
