using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Radyo
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 yeni = new Form2();
            this.Close();
            yeni.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            popbuton.Visible = true;
            button1.Visible = false;
        }

        private void popbuton_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
            popbuton.Visible = false;
            button1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
            button1.Visible = false;
            popbuton.Visible = true;

        }

        private void ligradyo_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://icast.powergroup.com.tr/PowerFM/mpeg/128/home";
            popbuton.Visible = false;
            button1.Visible = true;
        }

        private void rockbuton_Click(object sender, EventArgs e)
        {
            //axWindowsMediaPlayer1.URL = "http://provisioning.streamtheworld.com/pls/VIRGIN_RADIOAAC.pls";
            popbuton.Visible = false;
            button1.Visible = true;
        }

        private void slowbuton_Click(object sender, EventArgs e)
        {
            popbuton.Visible = false;
            button1.Visible = true;
        }

        private void yabancibuton_Click(object sender, EventArgs e)
        {
            popbuton.Visible = false;
            button1.Visible = true;
        }

        private void haberbuton_Click(object sender, EventArgs e)
        {
            popbuton.Visible = false;
            button1.Visible = true;
        }

        private void sporbuton_Click(object sender, EventArgs e)
        {
            popbuton.Visible = false;
            button1.Visible = true;
        }

        private void Arabeskbuton_Click(object sender, EventArgs e)
        {
            popbuton.Visible = false;
            button1.Visible = true;
        }
    }
}
