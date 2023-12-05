using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
{   /// <summary>
    /// Interaction logic for Change_Password.xaml
    /// </summary>
    public partial class Change_Password : Page
    {
        AssessmentEntities1 db_ = new AssessmentEntities1();
        public Change_Password()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //User_ user = new User_();
            //user = db_.User_.FirstOrDefault(x => x.Phone_Number == user.Phone_Number);
            //if (new_pass.Text == confirm_pass.Text)
            //{
            //    user.Password_ = new_pass.Text;
            //    user = db_.User_.AddOrUpdate(user);
            //    db_.SaveChanges();
            //    LogIn_Page logIn_ = new LogIn_Page();
            //    this.NavigationService.Navigate(logIn_);
            //}
            //else
            //{
            //    MessageBox.Show("Please Enter The Phone Number Corrict");
            //}
        }
    }
}
