using System;
using System.Windows.Forms;

namespace Chat
{
    public partial class Authorization : Form
    {
        public User name = new User();
        public User CurrentUser = new User();
        public User UserContext = new User();
        public User State = new User();

        //   public UserState name = new UserState();

        public Authorization()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            User.Name = textBoxName.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void loginButon_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
             Chat form2 = new Chat();
             form2.Show();
             Hide();
            //State.CurrentUser = new Common.User
            {
                // Id = Guild.NewGuild(),
                //  Name = $"{textBoxName.Text ?? "<login>"}"
             };

            loginButton.Enabled = true;
            textBoxName.ReadOnly = true;

            try
            {
                // client = new UdpClient(LOCALPORT);
                // присоединяемся к групповой рассылке
                // client.JoinMulticastGroup(groupAddress, TTL);

                // запускаем задачу на прием сообщений
                //Task receiveTask = new Task(ReceiveMessages);
               // receiveTask.Start();

                // отправляем первое сообщение о входе нового пользователя
                string message = name + " вошел в чат";
               // byte[] data = Encoding.Unicode.GetBytes(message);
               // client.Send(data, data.Length, HOST, REMOTEPORT);

                loginButton.Enabled = false;
                //logoutButton.Enabled = true;
                //sendButton.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
