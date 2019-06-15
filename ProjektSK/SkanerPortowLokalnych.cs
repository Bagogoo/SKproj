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
    public partial class SkanerPortowLokalnych : Form
    {
        public SkanerPortowLokalnych()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > numericUpDown2.Value)
            {
                MessageBox.Show("Błędny zakres portów.");
                return;
            }
            listBox1.Items.Add("Rozpoczęcie skanowania ...");
            for (int i = (int)numericUpDown1.Value; i <= (int)numericUpDown2.Value; i++)
            {
                this.Refresh();
                label1.Text = "aktualnie skanowany port: " + i;
                try
                {
                    TcpListener serwer = new TcpListener(IPAddress.Loopback, i);
                    serwer.Start(); serwer.Stop();
                }
                catch
                {
                    listBox1.Items.Add("Port: " + i + " jest zajęty");
                }
            }
            listBox1.Items.Add("Zakończenie skanowania");
        }
    }
}
