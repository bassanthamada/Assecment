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
    /// Interaction logic for LogIn_Page.xaml
    /// </summary>
    public partial class LogIn_Page : Page
    {
        AssessmentEntities1 db = new AssessmentEntities1();
        public LogIn_Page()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Sign_Up__Page sign_Up__Page = new Sign_Up__Page();
            this.NavigationService.Navigate(sign_Up__Page);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Change_Password change = new Change_Password();
            this.NavigationService.Navigate(change);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                User_ user = new User_();
                user = db.User_.First(x => x.UserName == username.Text && x.Password_ == password.Text);




                Profile profile = new Profile();
                profile.Nam_Txt.Text = user.UserName;
                profile.Pass_Txt.Password = user.Password_;
                profile.Age_Txt.Text = user.Age.ToString();
                profile.City_Txt.Text = user.City;
                profile.PH_Txt.Text = user.Phone_Number.ToString();
                profile.Gen_Txt.Text = user.Gender;
                this.NavigationService.Navigate(profile);
            }
            catch
            {
                MessageBox.Show("Please Enter The Data");
            }

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Admin_LogIn admin_Log = new Admin_LogIn();
            this.NavigationService.Navigate(admin_Log);
        }
    }
}
