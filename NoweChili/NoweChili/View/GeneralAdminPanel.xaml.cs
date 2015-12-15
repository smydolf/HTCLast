using System.Windows;

namespace NoweChili.View
{
    /// <summary>
    /// Interaction logic for GeneralAdminPanel.xaml
    /// </summary>
    public partial class GeneralAdminPanel : Window
    {
        public GeneralAdminPanel()
        {
            InitializeComponent();
        }

        private void AddButtonInAdminPanel_OnClick(object sender, RoutedEventArgs e)
        {
           AddProductAdminView addProductAdminView = new AddProductAdminView();
            addProductAdminView.Show();
            this.Close();
        }
    }
}
