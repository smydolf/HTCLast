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

namespace NoweChili.View.AdminView
{
    /// <summary>
    /// Interaction logic for AddNewUser.xaml
    /// </summary>
    public partial class AddNewUser : Window
    {
        public AddNewUser()
        {
            InitializeComponent();
        }

        #region MethodMember
        private string CryptPassword(string text)
        {
            SHA1Managed sha1 = new SHA1Managed();
            byte[] bytes = sha1.ComputeHash(new UnicodeEncoding().GetBytes(text));
            return Convert.ToBase64String(bytes);
        }
        #endregion
        private void BackButton_OnClick(object sender, RoutedEventArgs e)
        {
            var generalAdminPanel = new GeneralAdminPanel();
            generalAdminPanel.Show();
            this.Close();
        }
        private void SubmitAddProduct_OnClick(object sender, RoutedEventArgs e)
        {
            string password = PasswordBox.Password;
            string codedPassword = CryptPassword(password);

            UserDbObject newUserDbObject = new UserDbObject()
            {
                IsAdmin = false,
                Password = codedPassword,
                UserName = UserNameTextBox.Text
            };
            Services.userService.AddNew(newUserDbObject);
            Services.userService.SaveChange();
        }
    }
}
