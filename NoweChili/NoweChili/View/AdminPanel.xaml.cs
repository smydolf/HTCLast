using System;
using System.Windows;
using ChiliDomain.DbObjects;
using ChiliService;
using ClassLibrary1;

namespace NoweChili.View
{
    /// <summary>
    /// Interaction logic for AdminPanel.xaml
    /// </summary>
    public partial class AdminPanel : Window
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void Edit_OnClick(object sender, RoutedEventArgs e)
        {
            UserService userService = new UserService(new HtcAplicationContext());

            var updateUser = new UserDbObject()
            {
                UserName = NameUserLaber.Text
            };



            userService.Update(2,updateUser);
               

         
        }
    }
}
