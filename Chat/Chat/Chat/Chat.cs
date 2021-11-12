using System;
using System.Windows.Forms;

namespace Chat
{
    public partial class Chat : Form
    {
        public User CurrentUser = new User();
        public User UserContext = new User();
        public User State = new User();

        bool alive = false;                 // будет ли работать поток для приема
        //UdpClient client;
        const int LOCALPORT = 8001;         // порт для приема сообщений
        const int REMOTEPORT = 8001;        // порт для отправки сообщений
        const int TTL = 20;
        const string HOST = "235.5.5.1";    // хост для групповой рассылки
        //IPAddress groupAddress;           // адрес для групповой рассылки
        
        public Chat()
        {
            InitializeComponent();
        
            SendButton.Enabled = false;     // кнопка отправки
            ChatTextBox.ReadOnly = true;    // поле для сообщений
           
            //  groupAddress = IPAddress.Parse(HOST);
        }
        // метод приема сообщений
        private void ReceiveMessages()
        {
            alive = true;
            try
            {
                while (alive)
                {
                  //  IPEndPoint remoteIp = null;
                  //  byte[] data = client.Receive(ref remoteIp);
                  //  string message = Encoding.Unicode.GetString(data);

                    // добавляем полученное сообщение в текстовое поле
                    Invoke(new MethodInvoker(() =>
                    {
                        string time = DateTime.Now.ToShortTimeString();
                      //  ChatTextBox.Text = time + " " + message + "\r\n" + ChatTextBox.Text;
                    }));
                }
            }
            catch (ObjectDisposedException)
            {
                if (!alive)
                    return;
                throw;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
                                            // обработчик нажатия кнопки sendButton
        private void SendButton_Click(object sender, EventArgs e)
        {
            try
            {
               // string message = String.Format("{0}: {1}", name, MessageTextBox.Text);
              //  byte[] data = Encoding.Unicode.GetBytes(message);
              //  client.Send(data, data.Length, HOST, REMOTEPORT);
                MessageTextBox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            ExitChat();
        }
                                            // выход из чата
        private void ExitChat()
        {
          //  string message = name + " покидает чат";
          //  byte[] data = Encoding.Unicode.GetBytes(message);
          //  client.Send(data, data.Length, HOST, REMOTEPORT);
          //  client.DropMulticastGroup(groupAddress);

            alive = false;
            //client.Close();

        //    loginButton.Enabled = true;
            SendButton.Enabled = false;
        }
                                            // обработчик события закрытия формы
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (alive)
                ExitChat();
        }
    

        private void Chat_Load(object sender, EventArgs e)
        {
            label2.Text = User.Name;
            
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void ChatTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click_1(object sender, EventArgs e)
        {
            Authorization form1 = new Authorization();
            form1.Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void MessageTextBox_TextChanged(object sender, EventArgs e)
        {
            if (MessageTextBox.Text != "")
            {
                SendButton.Enabled = true;
            }
        }
    }
}
