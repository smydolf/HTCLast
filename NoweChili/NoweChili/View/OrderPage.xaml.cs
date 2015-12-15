using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using ChiliDomain.DbObjects;
using ChiliService;
using ClassLibrary1;

using System.Windows.Navigation;

namespace NoweChili.View
{
    /// <summary>
    /// Interaction logic for OrderPage.xaml
    /// </summary>
    public partial class OrderPage : Window
    {
        readonly UserService UserService = new UserService(new HtcAplicationContext());
        public OrderPage()
        {
            InitializeComponent();
        }

        private void Test_Click(object sender, RoutedEventArgs e)
        {

            var user = new UserDbObject()
            {
                UserName = "Adam"
            };

            UserService.AddEntity(user);
            UserService.SaveChange();

        }

        private void ChangeEntity_OnClick(object sender, RoutedEventArgs e)
        {
           AdminPanel panel = new AdminPanel();
            panel.Show();
            this.Hide();
        }

        private void DeleteEntity_OnClick(object sender, RoutedEventArgs e)
        {
            //int id = 1;
            //List<ProductDbObject> ProductdbObjectList = new List<ProductDbObject>();
            //ProductdbObjectList = productService.GetAll();
            //productService.DeleteById(id);
            //productService.SaveChange();

        }

        private void GetById_OnClick(object sender, RoutedEventArgs e)
        {
            //int id = 5;
            //ProductDbObject var = productService.GetById(id);
            //GetByidTextBlock.Text = var.ProductName + var.PrimaryKey + "Fuck Yea";
        }
    }
}
