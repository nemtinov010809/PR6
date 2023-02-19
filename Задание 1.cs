using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание_1
{
    public partial class Lab6_1 : Form
    {
        public Lab6_1()
        {
            InitializeComponent();
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            if (Width >= pct.Left + 20 + pct.Width)
            {
                pct.Left = pct.Left + 20;
            }
           
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (tmr.Enabled == true)
            {
                tmr.Enabled = false;
                btnStart.Text = "Старт";
            }
            else
            {
                tmr.Enabled = true;
                btnStart.Text = "Стоп";
            }
            tmr.Interval = 80;
        }

        private void btnExite_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
