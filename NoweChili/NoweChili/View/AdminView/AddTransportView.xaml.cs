using System;
using System.Windows;
using ChiliDomain.DbObjects;

namespace NoweChili.View.AdminView
{
    /// <summary>
    /// Interaction logic for AddTransportView.xaml
    /// </summary>
    public partial class AddTransportView : Window
    {
        public TransportDbObject transportDbObject = null;
        public AddTransportView()
        {
            InitializeComponent();
        }

        public void CreateOrUpdateProduct()
        {


            if (transportDbObject == null)
            {
                TransportDbObject newTransportDbObject = new TransportDbObject()
                {
                    TransportName = TransportNameTextBox.Text,
                    TransportPrice = Convert.ToDecimal(TransportPriceTextBox.Text),
                };

                Services.transportService.AddNew(newTransportDbObject);
                Services.transportService.SaveChange();

            }
            else
            {
                transportDbObject.TransportName = TransportNameTextBox.Text;
                transportDbObject.TransportPrice = Convert.ToDecimal(TransportPriceTextBox.Text);
                Services.transportService.Update(transportDbObject.PrimaryKey, transportDbObject);
                var newEditingWindows = new EditTransportAdminView();
                newEditingWindows.Show();
                this.Close();
            }
        }

        private void BackButton_OnClick(object sender, RoutedEventArgs e)
        {
            var generalAdminPanel = new GeneralAdminPanel();
            generalAdminPanel.Show();
            this.Close();
        }
        private void SubmitAddProduct_OnClick(object sender, RoutedEventArgs e)
        {
            CreateOrUpdateProduct();
        }
    }
}
