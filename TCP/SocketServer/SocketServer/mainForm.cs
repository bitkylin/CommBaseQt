using System;
using System.Text;
using System.Windows.Forms;

using System.Net;
using System.Net.Sockets;

using System.Threading;
namespace SocketText
{
    public partial class mainForm : Form
    {
        Thread serverThread;//开启服务
        Thread serverThreadSub;//接收数据
        Socket serverSocketMain = null;
        Socket serverSocketSub = null;
        static string hostName = Dns.GetHostName();//本机名   
        IPEndPoint ipep;
        IPAddress[] addressList1;

        public mainForm()//初始化函数
        {
            InitializeComponent();
            addressList1 = Dns.GetHostByName(hostName).AddressList;//会返回所有地址，包括IPv4和IPv6   
            IPadress.Items.AddRange(addressList1);//获得的IPV4加入列表框
            IPadress.SelectedIndex = IPadress.Items.Count > 0 ? 0 : -1;
        }

        private void socketServerStart()//单击“监听”按钮，开启服务器
        {
            //创建一个套接字
            ipep = new IPEndPoint(addressList1[IPadress.SelectedIndex], int.Parse(Porttext.Text.ToString()));//IPV4地址、端口号
            serverSocketMain = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //将所创建的套接字与IPEndPoint绑定
            serverSocketMain.Bind(ipep);
            //设置套接字为收听模式
            serverSocketMain.Listen(10);
            try
            {
                //在套接字上接收接入的连接
                controlMessageShow("等待TCP客户端响应");
                serverSocketSub = serverSocketMain.Accept();
                serverThreadSub = new Thread(new ThreadStart(ReceiveData));//新建接收数据线程
                serverThreadSub.Start();//启动线程
            }
            catch (Exception ex)
            {
                controlMessageShow("服务端监听链接中断：" + ex.Message);
            }
        }

        private void ReceiveData()//接收数据
        {
            bool keepalive = true;
            Byte[] buffer = new Byte[1024];//jie
            //根据收听到的客户端套接字向客户端发送信息
            IPEndPoint clientep = (IPEndPoint)serverSocketSub.RemoteEndPoint;
            controlMessageShow("服务端与客户端（" + clientep.Address + " : " + clientep.Port + "）连接成功！");
            controlMessageShow("成功建立与TCP客户端的连接");
            while (keepalive)
            {
                //在套接字上接收客户端发送的信息
                int bufLen = 0;
                try
                {
                    bufLen = serverSocketSub.Available;
                    serverSocketSub.Receive(buffer, 0, bufLen, SocketFlags.None);
                    if (bufLen == 0)
                        continue;
                }
                catch (Exception ex)
                {
                    controlMessageShow("已与TCP客户端断开连接");
                    controlMessageShow("服务端接收链接中断：" + ex.Message);
                    return;
                }
                clientep = (IPEndPoint)serverSocketSub.RemoteEndPoint;
                string clientcommand = Encoding.ASCII.GetString(buffer).Substring(0, bufLen);//转码
                communicateMessageShow(clientcommand.ToString() + " (" + clientep.Address + ")");//显示接收到的信息
            }
        }
        private void controlMessageShow(String Message)//控制信息
        {
            lstControlText.Items.Add(Message);
            lstControlText.SetSelected(lstControlText.Items.Count - 1, true);
        }
        private void communicateMessageShow(String Message)//通信信息
        {
            lstServerCommunicationText.Items.Add(Message);
            lstServerCommunicationText.SetSelected(lstServerCommunicationText.Items.Count - 1, true);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void btnStartServer_Click(object sender, EventArgs e)//开启服务
        {
            if (btnStartServer.Text == "监听")
            {

                if (Porttext.Text != string.Empty && IPadress.Text != string.Empty)//检测IP地址框和端口框是否为空
                {
                    btnStartServer.Text = "断开";
                    serverThread = new Thread(new ThreadStart(socketServerStart));//新建线程
                    serverThread.Start();
                    controlMessageShow("准备开启TCP服务");
                }
                else MessageBox.Show("请输入本地端口号，重新连接", "提示");
            }
            else
            {
                btnStartServer.Text = "监听";
                if (!(serverSocketMain == null))
                    serverSocketMain.Close();
                if (!(serverSocketSub == null))
                    serverSocketSub.Close();
                controlMessageShow("已与TCP客户端断开连接");
                lstControlText.SetSelected(lstControlText.Items.Count - 1, true);
                serverSocketMain = null;
                serverSocketSub = null;
                btnStartServer.Enabled = true;
            }
        }

        byte[] buf = { 1, 2, 3 };
        private void btn_send_Click(object sender, EventArgs e)//发送输入到文本控件的信息
        {
            string message = textBoxSendMessage.Text.ToString();
            serverSocketSub.Send(Encoding.ASCII.GetBytes(message));
            communicateMessageShow(message+" [已发送]");
            textBoxSendMessage.Text = "";
        }

        private void btnClearCommunicateText_Click(object sender, EventArgs e)//清除接收信息
        {
            lstServerCommunicationText.Items.Clear();
        }

        private void btnClearControlText_Click(object sender, EventArgs e)//清除控制信息
        {
            lstControlText.Items.Clear();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)//点击关闭按钮，释放监听端口再退出
        {
            if (MessageBox.Show("确定要关闭？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                e.Cancel = false;
                if (!(serverSocketMain == null))
                    serverSocketMain.Close();
                if (!(serverSocketSub == null))
                    serverSocketSub.Close();
                serverSocketMain = null;
                serverSocketSub = null;
                this.Dispose();
            }
            else
            {
                e.Cancel = true;

            }
        }
    }
}
