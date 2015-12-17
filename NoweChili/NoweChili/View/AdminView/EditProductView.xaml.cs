using System.Windows;
using ChiliDomain.DbObjects;
using NoweChili.Models;

namespace NoweChili.View.AdminView
{
    /// <summary>
    /// Interaction logic for EditProductView.xaml
    /// </summary>
    public partial class EditProductView : Window
    {
        ProductModel productModel = new ProductModel();
        public EditProductView()
        {
            
            InitializeComponent();
            ProductListListView.DataContext = productModel;
          
        }
        #region MethodDeclaration
        public void CheckListIsNotNull()
        {
            if (productModel.OProductDbObjects.Count == 0)
            {
                MessageBox.Show("Twoja lista jest pusta, najpierw dodaj jakiś produkt");
                
                var GeneralAdminPanel = new GeneralAdminPanel();
                GeneralAdminPanel.Show();
                this.Close();                    
            }
            else
            {
                ProductDbObject editProductDbObject;
                editProductDbObject = (ProductDbObject)ProductListListView.SelectedItem;
                var addWindows = new AddProductAdminView();
                addWindows.Show();
                this.Close();
                addWindows.NameOfProductTextBox.Text = editProductDbObject.ProductName.ToString();
                addWindows.ProductCodeTextBox.Text = editProductDbObject.ProductCode.ToString();
                addWindows.PriceOfProductTextBox.Text = editProductDbObject.ProductPrice.ToString();
                addWindows.SizeOfProductTextBox.Text = editProductDbObject.ProductSize.ToString();
                addWindows.ProductDbObject = editProductDbObject;
            }
            
        }
        #endregion MethodDeclaration
        private void ProductEditButton_OnClick(object sender, RoutedEventArgs e)
        {
            CheckListIsNotNull();          
        }
        private void ProductDeleteButton_OnClick(object sender, RoutedEventArgs e)
        {
           ProductDbObject productToDelete = new ProductDbObject();
            productToDelete = (ProductDbObject) ProductListListView.SelectedItem;
            if (productToDelete == null)
            {
                var result = MessageBox.Show("Proszę zaznaczyć obiekt na liście");
            }

            else
            {
                Services.productService.DeleteEntity(productToDelete);
                Services.productService.SaveChange();
                productModel.OProductDbObjects.Remove(productToDelete);
            }


        }

        private void ProductBackButton_OnClick(object sender, RoutedEventArgs e)
        {
            var generalAdminPanel = new GeneralAdminPanel();
            generalAdminPanel.Show();
            this.Close();

         }
    }
}
