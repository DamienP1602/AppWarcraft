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

namespace WpfApp1.UserControls.LoginScreen
{
    /// <summary>
    /// Interaction logic for LoginElements.xaml
    /// </summary>
    public partial class LoginElements : UserControl
    {
        public LoginElements()
        {
            InitializeComponent();
        }

        private void OnLogin_Click(object sender, RoutedEventArgs e)
        {
            string _login = NameAccountBox.Text;
            string _password = PasswordAccountBox.Text;

            MainWindow _mainWindow = Window.GetWindow(App.Current.MainWindow) as MainWindow;
            Data _data = _mainWindow.data.ExistInDataBase(_login, _password);

            if (_data.ID != 0)
            {
                MessageBox.Show("You're log in !");
                _mainWindow.SwitchToUserScreen(_data);
            }
            else
            {
                MessageBox.Show("Wrong Login or Password !");
            }
        }

        public void Reset()
        {
            NameAccountBox.Text = string.Empty;
            PasswordAccountBox.Text = string.Empty;
        }
    }
}
