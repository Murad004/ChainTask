using ChainOfResponsibility.Classes;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ChainOfResponsibility
{
    /// <summary>
    /// Interaction logic for Products.xaml
    /// </summary>
    public partial class Products : UserControl
    {
        public List<Product> products = new List<Product>();
        public Products()
        {
            products = new List<Product>
            {
                new Product
            {
                Name="Cola",
                 Price=1.0,
                  ImagePath="Images/Cola.png",
                  Description="New Cola.Cola.MMC"

            },
            new Product
            {
                Name="Bread",
                 Price=0.50,
                  ImagePath="Images/Bread.png",
                  Description="Teze Corek"

            },
            new Product
            {
                Name="Chips",
                 Price=2.40,
                  ImagePath="Images/Pringless.png",
                  Description="Pringless Cips"

            },
            new Product
            {
                Name="Pizza",
                 Price=9.99,
                  ImagePath="Images/Pizza.png",
                  Description="Pizza"
            }
            };
            InitializeComponent();
        }

        private void AddBTn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Order Sucsesfully!", "Store Notify", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
