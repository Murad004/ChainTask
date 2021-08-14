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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<User> Users = new List<User>();
        public SignUpUC SignUpUC = new SignUpUC();
        public SignInUC SignInUC = new SignInUC();
        public Products Products = new Products();
        public MainWindow()
        {

            InitializeComponent();
        }

        private void ProductsBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SignUpBtn_Click(object sender, RoutedEventArgs e)
        {
            UCgrid.Children.Add(SignUpUC);
            Users = new List<User>
            {
                new User
                {
                    Name=SignUpUC.NameTxtBox.Text,
                    Surname=SignUpUC.SurnameTxtBox.Text,
                    Email=SignUpUC.EmailTxtBox.Text,
                    Password=SignUpUC.PasswordTxtBox.Text,
                    StepsOfChain=""
                   
                },
            };
        }

        private void SignInBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
