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

namespace Raciya
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ConnectBTN_Click(object sender, RoutedEventArgs e)
        {
            ConnectSetting win = new ConnectSetting();
            win.ShowDialog();
            using(ClientService client = new ClientService(win.ip, win.port))
            {
                Chat chat = new Chat(client.commun);
                chat.ShowDialog();
            }
        }

        private void WConnectBTN_Click(object sender, RoutedEventArgs e)
        {
            ConnectSetting win = new ConnectSetting();
            win.ShowDialog();
            using (ServerService server = new ServerService(win.ip, win.port))
            {
                Chat chat = new Chat(server.Communicator);
                chat.ShowDialog();
            }
        }

        private void ExintBTN_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
