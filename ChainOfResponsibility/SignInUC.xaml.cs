using ChainOfResponsibility.ChainOfResponsibility;
using ChainOfResponsibility.Extension;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for SignInUC.xaml
    /// </summary>
    public partial class SignInUC : UserControl
    {
        public MainWindow MainWindow { get; set; }


        public bool singinclick = false;

        public ObservableCollection<User> _User_List { get; set; }

        public ObservableCollection<User> List { get; set; } = new ObservableCollection<User>();



        string stepofchain = "SingIn Chain";
        public SignInUC()
        {
            InitializeComponent();
            Helper.Signin = this;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SignUpUC signUp = new SignUpUC();
            UCgrid.Children.Add(signUp);
        }

        private void SubmitBtn_Click(object sender, RoutedEventArgs e)
        {
            List = Helper.Userlist;

            foreach (var item in List)
            {
                if (item.Email == EmailTxtBox.Text && item.Password == PasswordTxtBox.Text)
                {
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.ShowDialog();

                    singinclick = true;



                }


            }

            if (!List.Any())
            {


                IChain chain = new SignUpChain();
                IChain chain2 = new SignInChain();
                IChain chain3 = new OrderChain();

                chain.setNextChain(chain2);
                chain2.setNextChain(chain3);

                User User = new User { Email = EmailTxtBox.Text, Password = PasswordTxtBox.Text, StepsOfChain = stepofchain };
                chain2.Handle(User);
                singinclick = false;
            }


            if (!List.Any(x => x.Email == EmailTxtBox.Text) || !List.Any(x => x.Password == PasswordTxtBox.Text))
            {

                IChain chain = new SignUpChain();
                IChain chain2 = new SignInChain();
                IChain chain3 = new OrderChain();

                chain.setNextChain(chain2);
                chain2.setNextChain(chain3);

                User User = new User { Email = EmailTxtBox.Text, Password = PasswordTxtBox.Text, StepsOfChain = stepofchain };
                chain2.Handle(User);

                singinclick = false;
            }


        }


    }
}
