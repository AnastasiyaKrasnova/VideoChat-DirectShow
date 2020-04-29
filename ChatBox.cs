using System;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace MyVideoChat
{
    class ChatBox
    {
        private static string remoteAddress; // хост для отправки данных
        private static int remotePort; // порт для отправки данных
        private static int localPort; // локальный порт для прослушивания входящих подключений
        private static UdpClient sender = new UdpClient(); // создаем UdpClient для отправки сообщений
        private static UdpClient receiver; // UdpClient для получения данных
        private static IPEndPoint remoteIp = null; // адрес входящего подключения
        private static Thread receiveThread;
        public struct UserInfo
        {
            public string Url;
            public int Port;
            public string Name;
            public string Message;
        }
        public static UserInfo _client_Info;

        public static void ChatStart()
        {
            localPort = 900;
            remotePort = 900;
            receiveThread = new Thread(new ThreadStart(ReceiveMessage));
            receiveThread.IsBackground = true;
            receiveThread.Start();
            //SendMessage("_start"); // отправляем сообщение
        }

        private static void ReceiveMessage()
        {
            UdpClient receiver = new UdpClient(localPort); // UdpClient для получения данных
            IPEndPoint remoteIp  = null;  // адрес входящего подключения
            try
            {
                while (true)
                {
                    byte[] data = receiver.Receive(ref remoteIp); // получаем данные
                    string message = Encoding.Unicode.GetString(data);
                    if (message != "_pause"&& message != "_stop_pause")
                    {
                        if (Form1.window.Message.InvokeRequired) //Проверка на инвок
                            Form1.window.Message.BeginInvoke(new Action<string>((s) => Form1.window.ChatTable.Text = s), message);
                        else
                            Form1.window.Message.Text = message;
                    }
                    else if(message == "_pause")
                    {
                        
                        Form1.onPause = true;
                        MessageBox.Show("_pause");
                    }

                    else
                    {
                        Form1.onPause = false;
                        MessageBox.Show("_stop_pause");
                    }
                        
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                receiver.Close();
            }
           
        }
        public static void SendMessage(string Message)
        {
            // создаем UdpClient для отправки сообщений
            remoteAddress = Form1.window.PeerIP_TXT.Text;
            UdpClient sender = new UdpClient();
            try
            {
                    byte[] data = Encoding.Unicode.GetBytes(Message);
                    sender.Send(data, data.Length, remoteAddress, remotePort); // отправка
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sender.Close();
            }
        }
    }
}
