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

namespace WpfApp1.UserControls
{
    /// <summary>
    /// Interaction logic for CreateAccount.xaml
    /// </summary>
    public partial class CreateAccount : UserControl
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void OnCreateAccount_Click(object sender, RoutedEventArgs e)
        {
            string _login = NewNameAccountBox.Text;
            string _password = NewPasswordAccountBox.Text;

            if (_password.Contains(" ") || _login.Contains(" ") || string.IsNullOrEmpty(_login) || string.IsNullOrEmpty(_password))
            {
                MessageBox.Show("Please don't use the space character");
                return;
            }

            MainWindow _window = Window.GetWindow(App.Current.MainWindow) as MainWindow;
            Data _data = _window.data.ExistInDataBase(_login, _password);

            if (_data.ID != 0)
            {
                MessageBox.Show("An account with this name already exist !");
            }
            else
            {
                Data _newData = new Data() { ID = _window.data.Total, Login = _login, Password = _password };
                _window.data.Data.Add(_newData);

                MessageBox.Show("Your Account has been created !");
                SaveLoadFromData.Save(_window.data);
                NewNameAccountBox.Text = "";
                NewPasswordAccountBox.Text = "";
                Visibility = Visibility.Hidden;
            }
        }
    }
}
