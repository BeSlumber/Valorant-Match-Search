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

using Valorant_Match_search.Model;

namespace Valorant_Match_search
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
        }
        public List<Player> PlayerList = new List<Player>();
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
            var SearchText = txtPlayerId.Text;

            if (string.IsNullOrEmpty(SearchText))
            {
                PlayerPanel.Visibility = Visibility.Hidden;
                return;
            }
            PlayerPanel.Visibility = Visibility.Visible;

            //var SearchText = txtPlayerId.Text;
            //调用API得到PlayList
            PlayerList = new List<Player>();
                
        }
        //查询按钮点击事件
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //主页面加载
            mainFrame.Navigate(new Uri("Page1.xaml", UriKind.Relative));
        }
    }
}