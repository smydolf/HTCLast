﻿using System;
using System.Collections.Generic;
using System.Data;
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

        private void ProductEditButton_OnClick(object sender, RoutedEventArgs e)
        {

            throw new NotImplementedException();

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
    }
}
