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
using NoweChili.Models;

namespace NoweChili.View.AdminView
{
    /// <summary>
    /// Interaction logic for EditTransportAdminView.xaml
    /// </summary>
    public partial class EditTransportAdminView : Window
    {
        TransportModel transportModel = new TransportModel();
        public EditTransportAdminView()
        {
            InitializeComponent();
            TransportListListView.DataContext = transportModel;
        }

        public void CheckListIsNotNull()
        {
            if (transportModel.OTransportDbObjects.Count == 0)
            {
                MessageBox.Show("Twoja lista jest pusta, najpierw dodaj jakiś produkt");

                var GeneralAdminPanel = new GeneralAdminPanel();
                GeneralAdminPanel.Show();
                this.Close();
            }
            else
            {
                TransportDbObject editProductDbObject;
                editProductDbObject = (TransportDbObject)TransportListListView.SelectedItem;
                var addWindows = new AddTransportView();
                addWindows.Show();
                this.Close();
                addWindows.TransportNameTextBox.Text = editProductDbObject.TransportName;
                addWindows.TransportPriceTextBox.Text = editProductDbObject.TransportPrice.ToString();

                addWindows.transportDbObject = editProductDbObject;
            }

        }


        private void ProductEditButton_OnClick(object sender, RoutedEventArgs e)
        {
            CheckListIsNotNull();
        }

        private void ProductDeleteButton_OnClick(object sender, RoutedEventArgs e)
        {
            TransportDbObject transportToDelete = new TransportDbObject();
            transportToDelete = (TransportDbObject)TransportListListView.SelectedItem;
            if (transportToDelete == null)
            {
                var result = MessageBox.Show("Proszę zaznaczyć obiekt na liście");
            }

            else
            {
                Services.transportService.DeleteEntity(transportToDelete);
                Services.transportService.SaveChange();
                transportModel.OTransportDbObjects.Remove(transportToDelete);
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
