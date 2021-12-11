using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alpha_Pharma.Forms
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        private void Loading_Shown(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            progres_bar.Value = 0;
            progres_bar.Minimum = 0;
            progres_bar.Maximum = 100;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            progres_bar.Increment(5);
            if (progres_bar.Value == 100)
            {
                timer1.Stop();
                this.Hide();
            }

        }
    }
}
