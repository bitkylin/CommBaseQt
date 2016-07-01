using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;

using System.Threading;
namespace SocketText
{
    public partial class mainForm : Form
    {
        //wifi设置
        Thread serverThread;//开启服务
        Thread serverThreadSub;//接收数据
        Socket serverSocketMain = null;
        Socket serverSocketSub = null;
        static string hostName = Dns.GetHostName();//本机名   

        IPEndPoint ipep = new IPEndPoint((Dns.GetHostByName(hostName).AddressList[0]), 1520);//1520为连接端口
        public mainForm()
        {
            InitializeComponent();
            System.Net.IPAddress[] addressList = Dns.GetHostByName(hostName).AddressList;//会警告GetHostByName()已过期，我运行时且只返回了一个IPv4的地址   
            IPAddress NewAddress = IPAddress.Parse(addressList[0].ToString());//本机的IP地址
            IPADDress.Text = NewAddress.ToString();
        }

        private void WifiSocketServerStart()
        //单击“开启服务”按钮，开启服务器
        {
            //创建一个套接字
            serverSocketMain = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //将所创建的套接字与IPEndPoint绑定
            serverSocketMain.Bind(ipep);
            //设置套接字为收听模式
            serverSocketMain.Listen(10);
            try
            {
                //在套接字上接收接入的连接
                //labelServerStartOrEnd.Text = "等待TCP客户端响应";
                controlMessageShow("等待TCP客户端响应");
                // btnStartServer.Enabled = false;           
                serverSocketSub = serverSocketMain.Accept();
                serverThreadSub = new Thread(new ThreadStart(ReceiveData));//新建接收数据线程
                serverThreadSub.Start();//启动线程
            }
            catch (Exception ex)
            {
                //  MessageBox.Show("服务端监听链接中断：" + ex.Message);
                controlMessageShow("服务端监听链接中断：" + ex.Message);

            }
        }

        private void ReceiveData()
        {
            bool keepalive = true;
            Byte[] buffer = new Byte[1024];

            //根据收听到的客户端套接字向客户端发送信息
            IPEndPoint clientep = (IPEndPoint)serverSocketSub.RemoteEndPoint;
            //MessageIPAndPort.Text = (clientep.Address + "");
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
                    //MessageIPAndPort.Text = "无状态信息";
                    // MessageBox.Show("服务端接收链接中断：" + ex.Message);
                    controlMessageShow("服务端接收链接中断：" + ex.Message);
                    return;
                }
                clientep = (IPEndPoint)serverSocketSub.RemoteEndPoint;
                string clientcommand = Encoding.ASCII.GetString(buffer).Substring(0, bufLen);//转码

                communicateMessageShow(clientcommand.ToString() + "\r\n" + "(" + clientep.Address + ")");//显示接收到的信息
            }
        }
        private void controlMessageShow(String Message)
        {
            lstControlText.Items.Add(Message);
            lstControlText.SetSelected(lstControlText.Items.Count - 1, true);
        }
        private void communicateMessageShow(String Message)
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
                try
                {
                    ipep.Port = Convert.ToInt32(Porttext.Text);//修改端口
                    if (btnStartServer.Text != string.Empty)
                    {
                        btnStartServer.Text = "断开";
                        serverThread = new Thread(new ThreadStart(WifiSocketServerStart));//新建线程
                        serverThread.Start();
                        controlMessageShow("准备开启TCP服务");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("请输入本地端口号，重新连接", "提示");
                }
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
        }

        private void btnClearCommunicateText_Click(object sender, EventArgs e)//清除接收信息
        {
            lstServerCommunicationText.Items.Clear();
        }

        private void btnClearControlText_Click(object sender, EventArgs e)//清除控制信息
        {
            lstControlText.Items.Clear();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
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
                Dispose();

            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
