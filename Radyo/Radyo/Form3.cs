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
    public partial class Form3 : Form
    {
       
        public Form3()
        {
            InitializeComponent();
        }
        
        private void talkbuton_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://turkmedya.radyotvonline.com/turkmedya/ligradyo.stream/playlist.m3u8 ";
            popbuton.Visible = false;
            button1.Visible = true;
        }

        private void sporbuton_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://46.20.3.210/listen.pls";
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
            popbuton.Visible = true;
            button1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            popbuton.Visible = true;
            button1.Visible = false;
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
    }
}
