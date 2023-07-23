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
using System.Windows.Shapes;

namespace Raciya
{
    /// <summary>
    /// Логика взаимодействия для ConnectSetting.xaml
    /// </summary>
    public partial class ConnectSetting : Window
    {
        public string ip;
        public int port;
        public ConnectSetting()
        {
            InitializeComponent();
            ip = null; port = 0;
        }

        private void OKBTN_Click(object sender, RoutedEventArgs e)
        {
            ip = IP_TB.Text;
            port = Convert.ToInt32(Port_TB.Text);
            Close();
        }

        private void CancelBTN_Click(object sender, RoutedEventArgs e)
        {
            Close(); 
        }
    }
}
