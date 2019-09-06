using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class frmColorTkes : Form
    {
        int counterTkes = 0;

        public frmColorTkes()
        {
            InitializeComponent();
        }

        private void btnGreenTkes_Click(object sender, EventArgs e)
        {
            pcbkleurTkes.BackColor = Color.Green;
            lblDots2Tkes.Text = "Green";
            counterTkes = 2;
            pgbBarTkes.Value = 2;
        }

        private void btnStepTkes_Click(object sender, EventArgs e)
        {
            counterTkes = counterTkes + 1;

            if (counterTkes == 4)
            {
                pgbBarTkes.Value = 0;
                counterTkes = 1;
            }

            lblDotsTkes.Text = Convert.ToString(counterTkes);
            pgbBarTkes.Value = pgbBarTkes.Value + 1;

            if (counterTkes == 1)
            {
                pcbkleurTkes.BackColor = Color.Blue;
                lblDots2Tkes.Text = "Blue";
            }

            if (counterTkes == 2)
            {
                pcbkleurTkes.BackColor = Color.Green;
                lblDots2Tkes.Text = "Green";
            }

            if (counterTkes == 3)
            {
                pcbkleurTkes.BackColor = Color.Red;
                lblDots2Tkes.Text = "Red";
            }
        }

        private void btnBlueTkes_Click(object sender, EventArgs e)
        {
            pcbkleurTkes.BackColor = Color.Blue;
            lblDots2Tkes.Text = "Blue";
            counterTkes = 1;
            pgbBarTkes.Value = 1;
        }

        private void btnRedTkes_Click(object sender, EventArgs e)
        {
            pcbkleurTkes.BackColor = Color.Red;
            lblDots2Tkes.Text = "Red";
            counterTkes = 3;
            pgbBarTkes.Value = 3;
        }
    }
}
