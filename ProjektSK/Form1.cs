using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektSK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            SkanerPortow polaczenie = new SkanerPortow();
            polaczenie.Show();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            Chat polaczenie = new Chat();
            polaczenie.Show();
        }

        private void Btn11_Click(object sender, EventArgs e)
        {

        }

        private void Btn12_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            PolaczenieTCPKlient polaczenie = new PolaczenieTCPKlient();
            polaczenie.Show();
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            PolaczenieTCPServer polaczenie = new PolaczenieTCPServer();
            polaczenie.Show();
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            AsynchronicznyServerTCP polaczenie = new AsynchronicznyServerTCP();
            polaczenie.Show();
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            WyslijPing polaczenie = new WyslijPing();
            polaczenie.Show();
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            SkanerPortowLokalnych polaczenie = new SkanerPortowLokalnych();
            polaczenie.Show();
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            SprawdzIP polaczenie = new SprawdzIP();
            polaczenie.Show();
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            Tracerout polaczenie = new Tracerout();
            polaczenie.Show();
        }

        private void Btn10_Click(object sender, EventArgs e)
        {
            KompletnaInformacja polaczenie = new KompletnaInformacja();
            polaczenie.Show();
        }
    }
}
