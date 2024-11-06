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

namespace WpfApp1.UserControls.All
{
    /// <summary>
    /// Interaction logic for QuitButton.xaml
    /// </summary>
    public partial class QuitButton : UserControl
    {
        public QuitButton()
        {
            InitializeComponent();
        }

        private void OnExitButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow? _mainWindow = Window.GetWindow(App.Current.MainWindow) as MainWindow;

            if (_mainWindow != null)
                SaveLoadFromData.Save(_mainWindow.data);

            Window.GetWindow(this).Close();
        }
    }
}
