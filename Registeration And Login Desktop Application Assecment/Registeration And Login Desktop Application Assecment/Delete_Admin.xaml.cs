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
    /// Interaction logic for Delete_Admin.xaml
    /// </summary>
    public partial class Delete_Admin : Page
    {
        AssessmentEntities1 db = new AssessmentEntities1();
        public Delete_Admin()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            User_ user = new User_();
            user.Phone_Number =int.Parse( phone1.Text);
            user =db.User_.FirstOrDefault(x => x.Phone_Number== user.Phone_Number);
            db.User_.Remove(user);
            db.SaveChanges();
            MessageBox.Show("The Task Is Done");
        }
    }
}
