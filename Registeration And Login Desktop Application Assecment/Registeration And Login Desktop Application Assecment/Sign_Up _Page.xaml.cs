using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for Sign_Up__Page.xaml
    /// </summary>
    public partial class Sign_Up__Page : Page
    {
        AssessmentEntities1 db = new AssessmentEntities1();
        string Gender;
        public Sign_Up__Page()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LogIn_Page logIn_Page   = new LogIn_Page();
            this.NavigationService.Navigate(logIn_Page);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e )
        {
            Regex regex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*\W).+$");
            if (regex.IsMatch(pass.Text))
            {
                if (int.Parse(age.Text) >= 18 && int.Parse(age.Text) <= 60)
                {
                    if (phone.Text.Length == 11)
                    {
                        User_ user = new User_();
                        user.UserName = name.Text;
                        user.Password_ = pass.Text;
                        user.Gender = Gender;
                        user.City = combo.Text;
                        user.Phone_Number = int.Parse(phone.Text);
                        user.Age = int.Parse(age.Text);
                        
                        user = db.User_.Add(user);
                        db.SaveChanges();
                        LogIn_Page logIn = new LogIn_Page();
                        this.NavigationService.Navigate(logIn);
                    }
                    else
                    {
                        MessageBox.Show("phone number must be 11 numbers");
                    }
                    
                }
                else
                {
                    MessageBox.Show("age must be between 18 and 60");
                }
                
                
            }
            else
            {
                MessageBox.Show("password must be strong");
            }
            
            
            
           
           
           
            
            
            
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            Gender = "Male";
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            Gender = "Female";
        }
    }
}
