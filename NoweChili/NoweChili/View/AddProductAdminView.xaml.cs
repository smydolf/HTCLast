using System;
using System.Collections.Generic;
using System.Linq;
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
            
           ProductService productService = new ProductService(new HtcAplicationContext());
           ProductDbObject newProductDbObject = new ProductDbObject()
            {
               ProductName = Convert.ToString(NameOfProductTextBox.Text),
               ProductPrice = Convert.ToDecimal(PriceOfProductTextBox.Text),
               ProductCode = Convert.ToInt16(ProductCodeTextBox.Text),
               ProductSize = Convert.ToInt16(SizeOfProductTextBox.Text)
            };
           productService.AddNew(newProductDbObject);
            productService.SaveChange();
        }

        private void BackButton_OnClick(object sender, RoutedEventArgs e)
        {
           var generalAdminPanel = new GeneralAdminPanel();
            generalAdminPanel.Show();
            this.Close();
        }
    }
}
