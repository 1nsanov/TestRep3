using System.Net;
using System.Net.Sockets;
using System.Text;

namespace MyChat
{
    public partial class Form1 : Form
    {
        private string IpAddress;
        private int Port;
        private TcpClient TcpClient;
        private Thread MainThread;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetNetworkData();
            OpenTheard();
        }

        private void OpenTheard()
        {
            MainThread = new Thread(Recieve);
            MainThread.Start();
        }

        private void SetNetworkData()
        {
            IpAddress = GetLocalIPAddress();
            Port = 1111;
            textBoxRO_IP.Text = IpAddress;
            textBoxRO_Port.Text = Port.ToString();
        }

        private void Recieve()
        {
            var listener = new TcpListener(IPAddress.Any, Port);
            listener.Start();
            while (true)
            {
                var client = listener.AcceptTcpClient();
                var ns = client.GetStream();
                var byteTime = Encoding.ASCII.GetBytes(DateTime.Now.ToString());
                try
                {
                    richTextBoxOutput.Invoke((MethodInvoker)delegate
                    {
                        var data = new byte[256];
                        var bytes = ns.Read(data, 0, data.Length);
                        var str = Encoding.UTF8.GetString(data, 0, bytes);
                        richTextBoxOutput.Text += $"{IpAddress} send message({DateTime.Now:hh:mm:ss}):\n{str}\n";
                    });

                    ns.Write(byteTime, 0, byteTime.Length);
                    ns.Close();
                    client.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
            listener.Stop();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (richTextBoxMessage.Text == "") return;
            try
            {
                TcpClient = new TcpClient();
                var ip = textBoxIp.Text;
                var port = Convert.ToInt32(textBoxPort.Text);
                var response = richTextBoxMessage.Text;
                TcpClient.Connect(ip, port);
                NetworkStream stream = TcpClient.GetStream();
                var data = Encoding.UTF8.GetBytes(response);
                stream.Write(data, 0, data.Length);
            }
            catch (Exception error)
            {
                MessageBox.Show("Failed to send message.\n" + error.Message);
            }
            richTextBoxMessage.Clear();
        }

        private static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork) return ip.ToString();
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainThread.Abort();
            Application.Exit();
        }
    }
}