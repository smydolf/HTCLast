using System;
using System.Windows;
using System.Windows.Navigation;
using ChiliDomain.DbObjects;
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
        #region ObjectInit
        public ProductDbObject ProductDbObject = null;
        public TransportDbObject TransportDbObject = null;
        public UserDbObject UserDbObject = null;
         #endregion
        public void CreateOrUpdateProduct()
        {
            

            if (ProductDbObject == null)
            {
                var newProductDbObject = new ProductDbObject()
                {
                    ProductName = Convert.ToString(NameOfProductTextBox.Text),
                    ProductPrice = Convert.ToDecimal(PriceOfProductTextBox.Text),
                    ProductCode = Convert.ToInt16(ProductCodeTextBox.Text),
                    ProductSize = Convert.ToInt16(SizeOfProductTextBox.Text)
                };
                Services.productService.AddNew(newProductDbObject);
                Services.productService.SaveChange();
            }
            else
            {
                ProductDbObject.ProductName = Convert.ToString(NameOfProductTextBox.Text);
                ProductDbObject.ProductPrice = Convert.ToDecimal(PriceOfProductTextBox.Text);
                ProductDbObject.ProductCode = Convert.ToInt16(ProductCodeTextBox.Text);
                ProductDbObject.ProductSize = Convert.ToInt16(SizeOfProductTextBox.Text);
                Services.productService.Update(ProductDbObject.PrimaryKey, ProductDbObject);
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
