using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows;
using ChiliDomain.DbObjects;
using NoweChili.Models;

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
                    generalAdminPanel.user = new LoggedUser(userDbObject, DateTime.Now);
                    this.Close();
                    
                }
                else
                {
                    var OrderViewPanel = new OrderView();
                    OrderViewPanel.Show();
                    OrderViewPanel.user = new LoggedUser(userDbObject, DateTime.Now);
                    this.Close();   
                }
            }
         
        }
    }
}
