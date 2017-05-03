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
    public partial class Form2 : Form
    {
       
        public Form2()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form10 haber = new Form10();
            this.Close();
            haber.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void rockbuton_Click(object sender, EventArgs e)
        {
            Form6 rock = new Form6();
            this.Close();
            rock.Show();
        }

        private void slowbuton_Click(object sender, EventArgs e)
        {
            Form7 slow = new Form7();
            this.Close();
            slow.Show();
        }

        private void talkbuton_Click(object sender, EventArgs e)
        {
            Form4 talk = new Form4();
            this.Close();
            talk.Show();
        }

        private void sporbuton_Click(object sender, EventArgs e)
        {
            Form3 spor = new Form3();
            this.Close();
            spor.Show();

        }

        private void yabancibuton_Click(object sender, EventArgs e)
        {
            Form9 yabanci = new Form9();
            this.Close();
            yabanci.Show();
        }

        private void Arabeskbuton_Click(object sender, EventArgs e)
        {
            Form8 arabesk = new Form8();
            this.Close();
            arabesk.Show();
        }

        private void popbuton_Click(object sender, EventArgs e)
        {
            Form5 pop = new Form5();
            this.Close();
            pop.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
