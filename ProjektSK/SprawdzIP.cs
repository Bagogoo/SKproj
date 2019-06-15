using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektSK
{
    public partial class SprawdzIP : Form
    {
        public SprawdzIP()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string NazwaHosta = Dns.GetHostName();
            IPHostEntry AdresyIP = Dns.GetHostEntry(NazwaHosta);
            listBox1.Items.Add("nazwa komputera: " + NazwaHosta);
            int licznik = 0;
            foreach (IPAddress AdresIP in AdresyIP.AddressList)
            {
                if (AdresIP.ToString() == "127.0.0.1")
                    listBox1.Items.Add("Komputer nie jest podłączony do sieci. Adres IP: " + AdresIP.ToString());
                else listBox1.Items.Add(" adres IP #" + ++licznik + ": " + AdresIP.ToString());
            }
        }
    }
}
