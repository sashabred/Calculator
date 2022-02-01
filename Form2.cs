using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form2 : Calculator.Calc
    {
        public Form2()
        {
            InitializeComponent();
            this.ClientSize = new System.Drawing.Size(370,351);
           
            baseMenuStrip.Visible = false;
            standartFormToolStripMenuItem.Visible = true;
        }
        

        private void but_pow_Click(object sender, EventArgs e)
        {
            mehanizmcalkulyatora.DeystvieCalculatora(mehanizmcalkulyatora.Deystvie.Pow);
        }

       

        private void but_sqrt_Click_1(object sender, EventArgs e)
        {
            mehanizmcalkulyatora.DeystvieCalculatora(mehanizmcalkulyatora.Deystvie.Sqrt);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mehanizmcalkulyatora.DeystvieCalculatora(mehanizmcalkulyatora.Deystvie.X2);
        }

        private void butt_recnum_Click(object sender, EventArgs e)
        {
            mehanizmcalkulyatora.DeystvieCalculatora(mehanizmcalkulyatora.Deystvie.Recnum);
        }
    }
}
