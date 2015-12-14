using System.Collections.Generic;
using System.Windows;
using ChiliDomain.DbObjects;
using ChiliService;
using ClassLibrary1;

namespace NoweChili.View
{
    /// <summary>
    /// Interaction logic for OrderPage.xaml
    /// </summary>
    public partial class OrderPage : Window
    {
        readonly ProductService productService = new ProductService(new HtcAplicationContext());
        public OrderPage()
        {
            InitializeComponent();
        }

        private void Test_Click(object sender, RoutedEventArgs e)
        {
          

            ProductDbObject product = new ProductDbObject()
            {
                ProductName = "Margarita",
                ProductCode = 1260,
                ProductPrice = 38,
                ProductSize = 60
            };

            productService.AddNew(product);
            productService.SaveChange();
            
        }

        private void ChangeEntity_OnClick(object sender, RoutedEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void DeleteEntity_OnClick(object sender, RoutedEventArgs e)
        {
            int id = 1;
            List<ProductDbObject> ProductdbObjectList = new List<ProductDbObject>();
            ProductdbObjectList = productService.GetAll();
            productService.DeleteById(id);
            productService.SaveChange();

        }

        private void GetById_OnClick(object sender, RoutedEventArgs e)
        {
            int id = 5;
            ProductDbObject var = productService.GetById(id);
            GetByidTextBlock.Text = var.ProductName + var.PrimaryKey + "Fuck Yea";
        }
    }
}
