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
    public partial class Ali : Form
    {
        public Ali()
        {
            InitializeComponent();
        }

        Form2 menu = new Form2();
        
        int sayac = 1; //Açılış formu gösterim sayacı.
        private void timer1_Tick(object sender, EventArgs e) //Açılış formunu kapayıp ana menüyü açacak.
        {
            sayac++;
            if (label2.Text==". . . ") //Program açılırken sanal yükleme görseli
            {
                label2.ResetText();
            }
            else
                label2.Text += ". ";      
            if (sayac == 10)
            {
                this.Hide();
                menu.Show();
            }
        }

        
    }
}
