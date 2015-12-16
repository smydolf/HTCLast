using System;
using System.Windows;
using ChiliDomain.DbObjects;
using ChiliService;
using ClassLibrary1;
using NoweChili.View.AdminView;

namespace NoweChili.View
{
    /// <summary>
    /// Interaction logic for AddProductAdminView.xaml
    /// </summary>
    public partial class AddProductAdminView : Window
    {
        public AddProductAdminView()
        {
            InitializeComponent();
        }

        public ProductDbObject productDbObject = null;
        public TransportDbObject TransportDbObject = null;
        public UserDbObject UserDbObject = null;
        public void CreateOrUpdateProduct()
        {

            if (productDbObject == null)
            {
                productDbObject = new ProductDbObject()
                {
                    ProductName = Convert.ToString(NameOfProductTextBox.Text),
                    ProductPrice = Convert.ToDecimal(PriceOfProductTextBox.Text),
                    ProductCode = Convert.ToInt16(ProductCodeTextBox.Text),
                    ProductSize = Convert.ToInt16(SizeOfProductTextBox.Text)
                };
                Services.productService.AddNew(productDbObject);
                Services.productService.SaveChange();
            }
            else
            {
                productDbObject.ProductName = Convert.ToString(NameOfProductTextBox.Text);
                productDbObject.ProductPrice = Convert.ToDecimal(PriceOfProductTextBox.Text);
                productDbObject.ProductCode = Convert.ToInt16(ProductCodeTextBox.Text);
                productDbObject.ProductSize = Convert.ToInt16(SizeOfProductTextBox.Text);
                Services.productService.Update(productDbObject.PrimaryKey, productDbObject);
                var newEditingWindows = new EditProductView();
                newEditingWindows.Show();
                this.Close();
            }
        }
        private void SubmitAddProduct_OnClick(object sender, RoutedEventArgs e)
        {
            CreateOrUpdateProduct();
        }
        private void BackButton_OnClick(object sender, RoutedEventArgs e)
        {
            var generalAdminPanel = new GeneralAdminPanel();
            generalAdminPanel.Show();
            this.Close();
        }
    }
}
