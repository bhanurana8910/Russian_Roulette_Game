using Russian_Roulette_Game.view;

namespace Russian_Roulette_Game
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            _ = MainFrame.Navigate(content: new Home(this));
        }
    }
}
