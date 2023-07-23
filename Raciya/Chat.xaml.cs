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
    /// Логика взаимодействия для Chat.xaml
    /// </summary>
    public partial class Chat : Window
    {
        Communicator communicator = null;
        public Chat(Communicator communicator)
        {
            InitializeComponent();
            this.communicator = communicator;
        }

        private void SendBTN_Click(object sender, RoutedEventArgs e)
        {
            communicator.SendMessage(Send_TB.Text);
            Message_TB.Text += $"{Send_TB.Text}" + "\n";
        }

        private void ReceiveBTN_Click(object sender, RoutedEventArgs e)
        {
            Message_TB.Text += $"{communicator.Recive()}";
        }
    }
}
