using System;
using System.Collections.Generic;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using ChiliDomain.DbObjects;
using NoweChili.Models;
using NoweChili.DeAndSerialization;

namespace NoweChili.View
{
    /// <summary>
    /// Interaction logic for OrderView.xaml
    /// </summary>
    public partial class OrderView : Window
    {
        List<ProductDbObject> ProductList = new List<ProductDbObject>();
        private ProductDbObject pro;
        List<TransportDbObject> TransportList = new List<TransportDbObject>();
        private TransportDbObject transportPrice;
        public LoggedUser user;
        private decimal Suma;
        Serialization serialization = new Serialization();



        public OrderView()
        {
            InitializeComponent();
            RemoveProductButton.IsEnabled = false;
            TransportList = Services.transportService.GetAll(); //Tak powinno być zamiast przykładowych danych
            TransportComboBox.ItemsSource = TransportList;
        }

        private void ObliczSume()
        {
            decimal suma = 0;
            string total = string.Empty;
            foreach (var VARIABLE in ProductList)
            {
                suma += VARIABLE.ProductPrice;
            }

            if (transportPrice != null)
                suma += transportPrice.TransportPrice;

            total = suma.ToString("N2") + " zł";
            TotalTextBlock.Text = total;
            Suma = suma;
        }

        private void AddProductButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int ile = Int32.Parse(AmountTextBox.Text);

                var product = Services.productService.GetAll();
                var productByCode = product.Where(c => c.ProductCode == Int32.Parse(ProductCodeTextBox.Text));

                for (int i = 0; i < ile; i++)
                {
                    ProductList.Add(productByCode.First());
                }

                ProductListView.ItemsSource = null;
                ProductListView.ItemsSource = ProductList;
                ObliczSume();
                ProductCodeTextBox.Text = string.Empty;
                AmountTextBox.Text = string.Empty;
            }
            catch (ArgumentNullException)
            {
                var msg = "Wszystkie pola są wymagane";

                MessageBox.Show(msg, "Uwaga");
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Nie znaleziono produktu o podanym kodzie", "Uwaga!");
            }
            catch (FormatException)
            {
                var msg = "Wszystkie pola są wymagane!\nLub wpisałeś zły format...";

                MessageBox.Show(msg, "Uwaga");
            }
            catch (DbException ex)
            {
                var msg = "Coś nie tak z bazą danych: \n" + ex;

                MessageBox.Show(msg, "Uwaga");
            }
            catch (Exception ex)
            {
                var msg = "Coś poszło nie tak:  \n" + ex;
                MessageBox.Show(msg, "Uwaga!");
            }


        }

        private void RemoveProductButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ProductList.Remove(pro);
                ProductListView.ItemsSource = null;
                ProductListView.ItemsSource = ProductList;
                ObliczSume();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Coś poszło nie tak: \n" + ex, "Uwaga!");
            }
            finally
            {
                AddProductButton.IsEnabled = true;
                RemoveProductButton.IsEnabled = false;
            }

        }

        private void ProductListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            RemoveProductButton.IsEnabled = true;
            AddProductButton.IsEnabled = false;
            if (e.AddedItems.Count <= 0)
                return;
            pro = e.AddedItems[0] as ProductDbObject;
        }

        private void TransportComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {


            if (e.AddedItems.Count <= 0)
                return;

            transportPrice = e.AddedItems[0] as TransportDbObject;
            ObliczSume();

        }

        private void AmountTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(AmountTextBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Proszę wpisywać liczby", "Uwaga!");
                AmountTextBox.Text = AmountTextBox.Text.Remove(AmountTextBox.Text.Length - 1);
            }
        }

        private async Task SaveToFileAndPrint()
        {
            try
            {

                OrderModel order = new OrderModel(transportPrice, DateTime.Now, user, ProductList, Suma);


                string title = "Czas zamówienia: " + order.OrderTime.ToLongTimeString();
                string _user = "Użytkownik: " + order.User.loggedDbUserName + "\n";
                string _transport = "Miejscowość: " + order.Transport.TransportName + ", Cena: " +
                                    order.Transport.TransportPrice.ToString() + " zł \r\n";

                string _products = "Produkty: ";


                string _total = "Suma: " + Suma.ToString() + " zł\r\n\r\n\r\n";

                Directory.CreateDirectory(@"C:\Zamowienia");
                string filePath = @"C:\Zamowienia\Zamowienia_" + order.OrderTime.ToShortDateString() + ".txt";

                serialization.OrderSerialization(order);
              
                if (!File.Exists(filePath))
                {
                    File.Create(filePath).Dispose();

                    await SaveToFileAndPrint();
                    MessageBox.Show("Utworzono plik, zatwierdź jeszcze raz aby zapisać", "Uwaga");



                }
                else
                {
                    using (StreamWriter file = new StreamWriter(filePath, true))
                    {
                        await file.WriteLineAsync(title);
                        await file.WriteLineAsync(_user);
                        await file.WriteLineAsync(_transport);
                        await file.WriteLineAsync(_products);

                        foreach (var VARIABLE in ProductList)
                        {
                            await file.WriteLineAsync(VARIABLE.ToString());
                        }


                        await file.WriteLineAsync(_total);
                        await file.WriteLineAsync("\n");
                        await file.WriteLineAsync("\n");
                        await file.WriteLineAsync("\n");

                        file.Close();
                        MessageBox.Show("Zamówienie złożone !", "Informacja");
                    }

                    //await Print(order, title, _transport, _products);
                }


            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Nie znaleziono pliku", "Uwaga!");
            }
            catch (FileFormatException)
            {
                MessageBox.Show("Zły format pliku!", "Uwaga");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }


        }

        private async Task Print(OrderModel order, string _tytul, string _transport, string _products)
        {
            try
            {
                PrintDialog printDialog = new PrintDialog();

                string doDruku = string.Empty;

                doDruku += _tytul;
                doDruku += _transport;
                doDruku += _products;

                foreach (var VARIABLE in order.ProductList)
                {
                    doDruku += VARIABLE.ToString() + "\r\n";
                }

                FlowDocument doc = new FlowDocument(new Paragraph(new Run(doDruku)));
                doc.Name = "FlowDoc";

                IDocumentPaginatorSource idpSource = doc;

                printDialog.PrintDocument(idpSource.DocumentPaginator, "Zamówienie do druku");

                MessageBox.Show("Drukowanie...", "Drukowanie");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie można wydrukować dokumentu \r\n" + ex, "Uwaga!");
            }


        }

        private async void SubmitOrderButton_Click(object sender, RoutedEventArgs e)
        {

            await SaveToFileAndPrint();
            ProductList.Clear();
            ProductListView.ItemsSource = null;
            Suma = 0;
            TotalTextBlock.Text = "0 zł";
            Serialization serialization = new Serialization();
            List<OrderModel> orderModels = new List<OrderModel>();

        }

        private void LogOutButton_Click(object sender, RoutedEventArgs e)
        {
            user.Logout(this);
        }
    }
}
