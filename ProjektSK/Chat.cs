using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektSK
{
    public partial class Chat : Form
    {
        Socket socket;
        EndPoint epLocal, epRemote;
        byte[] bufor;
        public Chat()
        {
            InitializeComponent();
        }
      
        private void Chat_Load_1(object sender, EventArgs e)
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            txt_ip1.Text = GetIP();
            txt_ip2.Text = GetIP();
        }
        private string GetIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                    return ip.ToString();
            }
            return "127.0.0.1";
        }
        private void Btn_zapisz_Click(object sender, EventArgs e)
        {
            //Ustawienie gniazda
            epLocal = new IPEndPoint(IPAddress.Parse(txt_ip1.Text), Convert.ToInt32(txt_port1.Text));
            socket.Bind(epLocal);
            //Połącznie
            epRemote = new IPEndPoint(IPAddress.Parse(txt_ip2.Text), Convert.ToInt32(txt_port2.Text));
            socket.Connect(epRemote);
            //Nasłuchiwanie
            bufor = new byte[2000];
            socket.BeginReceiveFrom(bufor, 0, bufor.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), bufor);
        }
        private void MessageCallBack(IAsyncResult aResult)
        {
            try
            {
                byte[] received = new byte[2000];
                received = (byte[])aResult.AsyncState;
                ASCIIEncoding aEncoding = new ASCIIEncoding();
                string receivedMessage = aEncoding.GetString(received);

                lst_wiad.Items.Add("Kolega: " + receivedMessage);

                bufor = new byte[2000];
                socket.BeginReceiveFrom(bufor, 0, bufor.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), bufor);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void Txt_wiad_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_send.PerformClick();
            }
        }

        private void Btn_send_Click_1(object sender, EventArgs e)
        {
            ASCIIEncoding aEncoding = new ASCIIEncoding();
            byte[] wysylanie = new byte[2000];
            wysylanie = aEncoding.GetBytes(txt_wiad.Text);
            socket.Send(wysylanie);
            lst_wiad.Items.Add("Ja:" + txt_wiad.Text);
            txt_wiad.Text = "";
        }

      

    }
}

