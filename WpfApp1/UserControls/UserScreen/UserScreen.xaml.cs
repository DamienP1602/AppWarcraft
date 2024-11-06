using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using WpfApp1.Classes;

namespace WpfApp1.UserControls.UserScreen
{
    /// <summary>
    /// Interaction logic for UserScreen.xaml
    /// </summary>

    public partial class UserScreen : UserControl
    {
        Data actualUser;

        public UserScreen()
        {
            InitializeComponent();
            DataContext = this;
        }

        public void Init(Data _user)
        {
            actualUser = _user;
            CharacterList.Items.Clear();

            int _size = actualUser.AllCharacters.Count;

            for (int i = 0; i < _size; i++)
            {
                Character _character = actualUser.AllCharacters[i];
                CharacterPanel _panel = new CharacterPanel();

                _panel.Width = 300.0;
                _panel.CharacterName.Text = "Name : " + _character.Name;
                _panel.CharacterClass.Text = "Classe : " +  _character.ClassName;

                ImageBrush _brush = new ImageBrush();

                string _path = $"Sprites/race_human_{(_character.IsMale ? "male" : "female")}.png";

                _brush.ImageSource = new BitmapImage(new Uri(_path, UriKind.Relative));
                _panel.CharacterIcon.Background = _brush;

                CharacterList.Items.Add(_panel);
            }
        }

        private void OnDisconnect_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            MainWindow _mainWindow = Window.GetWindow(App.Current.MainWindow) as MainWindow;
            _mainWindow.SwitchToConnexionScreen();
        }
    }
}
