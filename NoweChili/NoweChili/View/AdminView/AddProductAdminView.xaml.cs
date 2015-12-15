using System;
using System.Windows;
using ChiliDomain.DbObjects;
using ChiliService;
using ClassLibrary1;

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

        private void SubmitAddProduct_OnClick(object sender, RoutedEventArgs e)
        {
            
         
           ProductDbObject newProductDbObject = new ProductDbObject()
            {
               ProductName = Convert.ToString(NameOfProductTextBox.Text),
               ProductPrice = Convert.ToDecimal(PriceOfProductTextBox.Text),
               ProductCode = Convert.ToInt16(ProductCodeTextBox.Text),
               ProductSize = Convert.ToInt16(SizeOfProductTextBox.Text)
            };
            Services.productService.AddNew(newProductDbObject);
            Services.productService.SaveChange();
        }

        private void BackButton_OnClick(object sender, RoutedEventArgs e)
        {
           var generalAdminPanel = new GeneralAdminPanel();
           generalAdminPanel.Show();
           this.Close();
        }
    }
}
