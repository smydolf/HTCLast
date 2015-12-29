using System.Windows;
using NoweChili.Models;
using NoweChili.View.AdminView;

namespace NoweChili.View
{
    /// <summary>
    /// Interaction logic for GeneralAdminPanel.xaml
    /// </summary>
    public partial class GeneralAdminPanel : Window
    {
        public LoggedUser user;
        public GeneralAdminPanel()
        {
            InitializeComponent();
        }

        private void AddButtonInAdminPanel_OnClick(object sender, RoutedEventArgs e)
        {
            AddProductAdminView addProductAdminView = new AddProductAdminView();
            addProductAdminView.Show();
            this.Close();
        }
        private void EditProductButtonInAdminPanel_OnClick(object sender, RoutedEventArgs e)
        {
            EditProductView editProductView = new EditProductView();
            editProductView.Show();
            this.Close();
        }

        private void AddUserButtonInAdminPanel_OnClick(object sender, RoutedEventArgs e)
        {
            var newUserView = new AddNewUser();
            newUserView.Show();
            this.Close();
        }

        private void AddTransportButtonInAdminPanel_OnClick(object sender, RoutedEventArgs e)
        {
            AddTransportView addTransport = new AddTransportView();
            addTransport.Show();
            this.Close();
        }

        private void EditTransportInAdminPanel_OnClick(object sender, RoutedEventArgs e)
        {
            EditTransportAdminView editTransportInAdminPanel = new EditTransportAdminView();
            editTransportInAdminPanel.Show();
            this.Close();
        }


        private void button_Click(object sender, RoutedEventArgs e)
        {
            user.Logout(this);
        }

        private void OrderEditInAdminPanel_OnClick(object sender, RoutedEventArgs e)
        {
            EditOrderView editOrderView = new EditOrderView();
            editOrderView.Show();
            this.Close();
        }
    }
}
