using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektSK
{
    public partial class Tracerout : Form
    {
        public Tracerout()
        {
            InitializeComponent();
        }
        private Ping ping = new Ping();
        private byte[] bufor;
        private int i = 1;
        void ping_PingCompleted(object sender, PingCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                listBox1.Items.Add(e.Error.Message);
                return;
            }
            if (e.Cancelled)
            {
                listBox1.Items.Add("Przerwano operację na życzenie użytkownika.");
            }
            else
            {
                if (e.Reply.Status == IPStatus.TtlExpired) listBox1.Items.Add("Skok " + i.ToString() + " host: " + e.Reply.Address.ToString());
                if (e.Reply.Status == IPStatus.TimedOut) listBox1.Items.Add("Skok " + i.ToString() + " host: * Upłynął limit czasu żądania.");
                if (e.Reply.Status == IPStatus.Success)
                {
                    listBox1.Items.Add("Skok " + i.ToString() + " host: " + e.Reply.Address.ToString());

                   Button1.Enabled = true;
                 
                }
                if (i++ < (int)numericUpDown1.Value)
                {
                    PingOptions opcjePing = new PingOptions(i, true);
                    ping.SendAsync(textBox1.Text, (int)numericUpDown2.Value, bufor, opcjePing, null);
                }
                else
                {
                    listBox1.Items.Add("Przekroczono maksymalną liczbę skoków (parametr TTL = " + numericUpDown1.Value.ToString());
                    Button1.Enabled = true;


                }
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            i = 1;
            PingOptions opcjePing = new PingOptions(i, true);
            string s = null;
            int wielkoscBuforu = 32;
            if (textBox1.Text != "" && textBox1.Text.Trim() != "")
            {
                //int wielkoscBuforu = 32;
                try
                {
                    wielkoscBuforu = System.Convert.ToInt16(comboBox1.Text);
                }
                catch
                {
                    wielkoscBuforu = 32;

                }
                comboBox1.Text = "32";
            }
            for (int j = 0; j < wielkoscBuforu; j++)
            {
                s += "a";
            }
            bufor = Encoding.ASCII.GetBytes(s);
            ping.SendAsync(textBox1.Text, (int)numericUpDown2.Value, bufor, opcjePing, null);
            listBox1.Items.Add("Rozpoczęcie badania drogi do " + textBox1.Text);
            Button1.Enabled = false;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ping.SendAsyncCancel();
            Button1.Enabled = true;
        }

        private void Tracerout_Load(object sender, EventArgs e)
        {

        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NumericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
