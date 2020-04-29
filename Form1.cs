using System;
using System.Diagnostics;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using DirectX.Capture;
using Microsoft.VisualBasic;
using System.IO;
using System.Threading;
using System.Net.Sockets;
using System.Net;

namespace MyVideoChat
{
    public partial class Form1 : Form
    {
        private Capture capture = null;
        private Filters filters = new Filters();
        public static Form1 window = null;
        public static bool onPause;
        public static bool MePaused;
        public Form1()
        {
            InitializeComponent();
            window = this;
            Control.CheckForIllegalCrossThreadCalls = false;
#if DEBUG
            capture = new Capture(filters.VideoInputDevices[0], filters.AudioInputDevices[0]);
#endif
            ChatBox.ChatStart();
            onPause = false;
            MePaused = false;
        }

        private void OnCaptureComplete(object sender, EventArgs e)
        {
            // Demonstrate the Capture.CaptureComplete event.
            Debug.WriteLine("Capture complete.");
        }

        bool isSending = false;
        private void CaptureDone(System.Drawing.Bitmap e)
        {
            try
            {
                this.pictureBox.Image = e;
                if (isSending)
                {

                    ThreadPool.QueueUserWorkItem(new WaitCallback(SendVideoBuffer), pictureBox.Image);
                }
                    
            }
            catch (Exception) { }
        }

        private void P2PVideoCall_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!stoped)
            {
                try
                {
                    isSending = false;
                    server_sock.Close();
                    ServerThread.Abort();
                }
                catch (Exception) { }

                try
                {
                    capture.PreviewWindow = null;
                    if (capture != null)
                        capture.Stop();
                }
                catch (Exception) { }
                AudioSender.Stop_AudioSender();
            }

        }

        private void button_PuchVideo_Click(object sender, EventArgs e)
        {
            try
            {
                // Start Capturing
               if (!MePaused)
                {
                    if (capture != null)
                    {
                        if (capture.PreviewWindow != panelVideo)
                        {
                            capture.PreviewWindow = panelVideo;
                        }
                        capture.FrameEvent2 += new Capture.HeFrame(CaptureDone);
                        capture.GrapImg();

                        PeerIP_TXT.Enabled = false;
                        button_PuchVideo.Enabled = false;
                        mnuDevices.Enabled = false;
                        menuItem7.Enabled = false;
                        isSending = true;
                    }
                    AudioSender.Start_AudioSender();
                }
                else
                {
                    ChatBox.SendMessage("_stop_pause");
                }
                    
            }
            catch (Exception) { }
        }

        Socket server_sock;
        void server()
        {
            try
            {
                server_sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                server_sock.Bind(new IPEndPoint(IPAddress.Any, 6000));
                server_sock.Listen(-1);

                while (true)
                {
                    try
                    {
                        Socket new_socket = server_sock.Accept();
                        NetworkStream ns = new NetworkStream(new_socket);
                        if (!onPause)
                        {
                            pictureBox_Remote.Image = Image.FromStream(ns);
                        }
                        ns.Close();
                        new_socket.Close();
                    }
                    catch (Exception)
                    {
                    }
                }
            }
            catch (Exception) { }

        }
        void SendVideoBuffer(object bufferIn)
        {
            try
            {
                TcpClient tcp = new TcpClient(PeerIP_TXT.Text, 6000);
                NetworkStream ns = tcp.GetStream();
                Image buffer = (Image)bufferIn;
                buffer.Save(ns, System.Drawing.Imaging.ImageFormat.Jpeg);
                ns.Close();
                tcp.Close();
            }
            catch (Exception) { }
        }

        Thread ServerThread;
        private void P2PVideoCall_Load(object sender, EventArgs e)
        {
            try
            {
                PeerIP_TXT.Text = Properties.Settings.Default.P2P_IP;
            }
            catch (Exception) { }

            ServerThread = new Thread(new ThreadStart(server));
            ServerThread.IsBackground = true;
            ServerThread.Start();

            if (capture != null)
            {
                capture.FrameRate = 15;
                capture.FrameSize = new Size(320, 240);
            }
            AudioSender.Initialize_AudioSender();

        }
        bool stoped = false;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                //isSending = false;
                //server_sock.Close();
                //ServerThread.Abort();
                ChatBox.SendMessage("_pause");
                MePaused = true;
            }
            catch (Exception) { }

            try
            {
                PeerIP_TXT.Enabled = true;//
                button_PuchVideo.Enabled = true;
                mnuDevices.Enabled = true;
                menuItem7.Enabled = true;//
                //capture.PreviewWindow = null;
                //if (capture != null)
                //capture.Stop();
            }

            catch (Exception) { }
            try
            {
                //AudioSender.Stop_AudioSender();
            }
            catch (Exception) 
            {
            }
            //stoped = true;
            //System.Environment.Exit(1);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChatBox.SendMessage(this.Message.Text);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
