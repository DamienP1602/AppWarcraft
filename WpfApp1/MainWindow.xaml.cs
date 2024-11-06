using System.Media;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public DataLogin? data = null;

        public MainWindow()
        {
            InitializeComponent();
            SaveLoadFromData.Load(out data);
            DataContext = this;
            StartMusic();

        }

        public void SwitchToUserScreen(Data _user)
        {
            LoginScreen.Visibility = Visibility.Hidden;
            UserScreen.Visibility = Visibility.Visible;
            UserScreen.Init(_user);
        }

        public void SwitchToConnexionScreen()
        {
            LoginScreen.Visibility = Visibility.Visible;
            UserScreen.Visibility = Visibility.Hidden;
            LoginScreen.LoginElements.Reset();
        }

        void StartMusic()
        {
            SoundPlayer _sp = new SoundPlayer("Song/LoginScreenMusic.wav");            
            _sp.PlayLooping();

        }
    }
}