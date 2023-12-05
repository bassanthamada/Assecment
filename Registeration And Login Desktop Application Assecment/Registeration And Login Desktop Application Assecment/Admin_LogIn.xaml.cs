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
    /// Interaction logic for Admin_LogIn.xaml
    /// </summary>
    public partial class Admin_LogIn : Page
    {
        AssessmentEntities1 db = new AssessmentEntities1();
        public Admin_LogIn()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Admain admain = new Admain();
            if(admain.admin_username_ == admin_user.Text && admain.admin_pass == admin_pass.Text)
            {
                admain = db.Admains.Add(admain);
                db.SaveChanges();
            }
            Admin_Page admin = new Admin_Page();
            this.NavigationService.Navigate(admin);
            //else
            //{
            //    MessageBox.Show("Please Enter The User Name And Password Corriect");
            //}
        }
    }
}
