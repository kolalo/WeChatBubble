using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WeChatBubble
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<ChatMessage> chatMessage = new ObservableCollection<ChatMessage>()
        {
            new ChatMessage()
            {
                Message="你好",
                MessageLocation=TypeLocalMessageLocation.chatRecv,
            },
            new ChatMessage()
            {
                Message="好久不见,老铁",
                MessageLocation=TypeLocalMessageLocation.chatSend,
            },
            new ChatMessage()
            {
                Message="来杯二锅头",
                MessageLocation =TypeLocalMessageLocation.chatSend,
            },
            new ChatMessage()
            {
                Message="gogogo",
                MessageLocation =TypeLocalMessageLocation.chatRecv,
            },
            new ChatMessage()
            {
                Message="000000000000000000000000000000000000000000000000000",
                MessageLocation=TypeLocalMessageLocation.chatSend,
            },
            new ChatMessage()
            {
                Message="0000000000000000000000000000000000000000000000000000000000000",
                MessageLocation=TypeLocalMessageLocation.chatRecv,
            },
            new ChatMessage()
            {
                Message="000000000000000000000000000000000000000000000000000",
                MessageLocation=TypeLocalMessageLocation.chatSend,
            },
            new ChatMessage()
            {
                Message="0000000000000000000000000000000000000000000000000000000000000",
                MessageLocation=TypeLocalMessageLocation.chatRecv,
            },
            new ChatMessage()
            {
                Message="000000000000000000000000000000000000000000000000000",
                MessageLocation=TypeLocalMessageLocation.chatSend,
            },
            new ChatMessage()
            {
                Message="0000000000000000000000000000000000000000000000000000000000000",
                MessageLocation=TypeLocalMessageLocation.chatRecv,
            },
            new ChatMessage()
            {
                Message="000000000000000000000000000000000000000000000000000",
                MessageLocation=TypeLocalMessageLocation.chatSend,
            },
            new ChatMessage()
            {
                Message="0000000000000000000000000000000000000000000000000000000000000",
                MessageLocation=TypeLocalMessageLocation.chatRecv,
            },
            new ChatMessage()
            {
                Message="000000000000000000000000000000000000000000000000000",
                MessageLocation=TypeLocalMessageLocation.chatSend,
            },
            new ChatMessage()
            {
                Message="0000000000000000000000000000000000000000000000000000000000000",
                MessageLocation=TypeLocalMessageLocation.chatRecv,
            },

        };
        public MainWindow()
        {
            InitializeComponent();
            ListBoxChat.ItemsSource = chatMessage;
        }

        private void BtnSend_Click(object sender, RoutedEventArgs e)
        {
            chatMessage.Add(new ChatMessage()
            {
                Message = textBox.Text,
                MessageLocation = Receive.IsChecked != null && Receive.IsChecked == true ? TypeLocalMessageLocation.chatRecv : TypeLocalMessageLocation.chatSend
            });
        }
    }
}
