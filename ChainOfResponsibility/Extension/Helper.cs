using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Extension
{
    public class Helper
    {
        public static MainWindow mainWindow { get; set; }
        public static SignIn Signin { get; set; }
        public static ObservableCollection<User> Userlist { get; set; } = new ObservableCollection<User>();
    }
}
