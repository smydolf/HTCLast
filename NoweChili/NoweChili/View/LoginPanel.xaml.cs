using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ChiliDomain.DbObjects;

namespace NoweChili.View
{
    /// <summary>
    /// Interaction logic for LoginPanel.xaml
    /// </summary>
    public partial class LoginPanel : Window
    {
        public LoginPanel()
        {
            InitializeComponent();
        }

        private string CryptPassword(string text)
        {
            SHA1Managed sha1 = new SHA1Managed();
            byte[] bytes = sha1.ComputeHash(new UnicodeEncoding().GetBytes(text));
            return Convert.ToBase64String(bytes);
        }

      
        private void Login_Click(object sender, RoutedEventArgs e)
        {

            UserDbObject userDbObject = Services.userService.GetUserByName(Username.Text);
            string password = PasswordBox.Password;
            string Cryptpassword = CryptPassword(password);
            if (userDbObject != null)
            {
                if (userDbObject.Password == Cryptpassword && userDbObject.IsAdmin)
                {
                    var generalAdminPanel = new GeneralAdminPanel();
                    generalAdminPanel.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Wypierdalaj");
            }




        }
    }
}
