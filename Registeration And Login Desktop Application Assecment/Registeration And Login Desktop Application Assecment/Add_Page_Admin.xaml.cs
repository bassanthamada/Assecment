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
    /// Interaction logic for Add_Page_Admin.xaml
    /// </summary>
    public partial class Add_Page_Admin : Page
    {
        AssessmentEntities1 db = new AssessmentEntities1();
        
        public Add_Page_Admin()
        {
            InitializeComponent();
            datagrid.ItemsSource = db.User_.ToList();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            User_ user = new User_();
            user.City = city_text.Text;
            //user.Phone_Number =int.Parse( phone_number_text.Text);
            user = db.User_.FirstOrDefault ( x => x.City == city_text.Text/*x => x.Phone_Number== user.Phone_Number*/);
            if(city_text.Text != null /*&& phone_number_text.Text != null*/) 
            { 
                user.City = city_text.Text;
                //user.Phone_Number = int.Parse(phone_number_text.Text);
                datagrid.ItemsSource = db.User_.Where( x => x.City == user.City /*&& x.Phone_Number == int.Parse(phone_number_text.Text)*/).ToList();
            }
            else if(city_text.Text == null/* && phone_number_text.Text == null*/)
            {
                user.City = city_text.Text;
                datagrid.ItemsSource = db.User_.Where(x => x.City == user.City /*&& x.Phone_Number == int.Parse(phone_number_text.Text)*/).ToList();
            }
            //else if (city_text.Text == null && phone_number_text.Text != null)
            //{
            //    user.Phone_Number = int.Parse(phone_number_text.Text);
            //    db.ItemsSource = db.User_.Where(x => x.City == user.City && x.Phone_Number == int.Parse(phone_number_text.Text)).ToList();
          /*  } */else
            {
                MessageBox.Show("Please Enter Phone");
            }
        }
    }
}
