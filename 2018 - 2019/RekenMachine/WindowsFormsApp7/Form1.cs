using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class frmCalculatorTkes : Form
    {
        //creates a counter//
        int counterTkes = 0;

        public frmCalculatorTkes()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnPlusTkes_Click(object sender, EventArgs e)
        {
            //sets the counter & progressbar value to 1//
            counterTkes = 1;
            progressBar1.Value = 1;

            //creates the 2 ints, firstNumberTkes & secondNumberTkes and sets them to 0//
            int firstNumberTkes = 0;
            int secondNumberTkes = 0;

            try
            {
                //converts the 2 ints to int32s//
                firstNumberTkes = Convert.ToInt32(tbxFirstnumberTkes.Text);
                secondNumberTkes = Convert.ToInt32(tbxSecondnumberTkes.Text);
            }

            catch
            {
                //makes gives a message so that it doesn't crash and let's you know you did something wrong//
                MessageBox.Show("You did something wrong, Try again");
            }
            //creates the awnser & shows it//
            int awnserTkes = firstNumberTkes + secondNumberTkes;
            tbxOutputTkes.Text = Convert.ToString(awnserTkes);

            //makes the message that shows what you're calculating//
            lblDotsTkes.Text = (firstNumberTkes + " + " + secondNumberTkes + " = " + awnserTkes);
        }

        private void btnMinusTkes_Click(object sender, EventArgs e)
        {
            //sets the counter & progressbar value to 2//
            counterTkes = 2;
            progressBar1.Value = 2;

            int firstNumberTkes, secondNumberTkes;
            NewMethod(out firstNumberTkes, out secondNumberTkes);
            //creates the awnser & shows it//
            int awnserTkes = firstNumberTkes - secondNumberTkes;
            tbxOutputTkes.Text = Convert.ToString(awnserTkes);

            //makes the message that shows what you're calculating//
            lblDotsTkes.Text = (firstNumberTkes + " - " + secondNumberTkes + " = " + awnserTkes);
        }

        private void NewMethod(out int firstNumberTkes, out int secondNumberTkes)
        {
            //creates the 2 ints, firstNumberTkes & secondNumberTkes and sets them to 0//
            firstNumberTkes = 0;
            secondNumberTkes = 0;
            try
            {
                //converts the 2 ints to int32s//
                firstNumberTkes = Convert.ToInt32(tbxFirstnumberTkes.Text);
                secondNumberTkes = Convert.ToInt32(tbxSecondnumberTkes.Text);
            }

            catch
            {
                //makes gives a message so that it doesn't crash and let's you know you did something wrong//
                MessageBox.Show("You did something wrong, Try again");
            }
        }

        private void btnTimesTkes_Click(object sender, EventArgs e)
        {
            //sets the counter & progressbar value to 3//
            counterTkes = 3;
            progressBar1.Value = 3;

            //creates the 2 ints, firstNumberTkes & secondNumberTkes and sets them to 0//
            int firstNumberTkes = 0;
            int secondNumberTkes = 0;

            try
            {
                //converts the 2 ints to int32s//
                firstNumberTkes = Convert.ToInt32(tbxFirstnumberTkes.Text);
                secondNumberTkes = Convert.ToInt32(tbxSecondnumberTkes.Text);
            }

            catch
            {
                //makes gives a message so that it doesn't crash and let's you know you did something wrong//
                MessageBox.Show("You did something wrong, Try again");
            }
            //creates the awnser & shows it//
            int awnserTkes = firstNumberTkes * secondNumberTkes;
            tbxOutputTkes.Text = Convert.ToString(awnserTkes);

            //makes the message that shows what you're calculating//
            lblDotsTkes.Text = (firstNumberTkes + " X " + secondNumberTkes + " = " + awnserTkes);
        }

        private void btnDevideTkes_Click(object sender, EventArgs e)
        {
            //sets the counter & progressbar value to 4//
            counterTkes = 4;
            progressBar1.Value = 4;

            //creates the 2 ints, firstNumberTkes & secondNumberTkes and sets them to 0//
            int firstNumberTkes = 0;
            int secondNumberTkes = 0;

            try
            {
                //converts the 2 ints to int32s//
                firstNumberTkes = Convert.ToInt32(tbxFirstnumberTkes.Text);
                secondNumberTkes = Convert.ToInt32(tbxSecondnumberTkes.Text);
            }

            catch
            {
                //makes gives a message so that it doesn't crash and let's you know you did something wrong//
                MessageBox.Show("You did something wrong, Try again");
            }

            //creates the awnser & shows it//
            int awnserTkes = firstNumberTkes / secondNumberTkes;
            tbxOutputTkes.Text = Convert.ToString(awnserTkes);

            //makes the message that shows what you're calculating//
            lblDotsTkes.Text = (firstNumberTkes + " : " + secondNumberTkes + " = " + awnserTkes);
        }

        private void btnRootTkes_Click(object sender, EventArgs e)
        {
            //sets the counter & progressbar value to 5//
            counterTkes = 5;
            progressBar1.Value = 5;

            //creates a double and sets it to 0//
            double firstNumberTkes = 0;
                       
            try
            {
                //converts the double to text//
                firstNumberTkes = Convert.ToDouble(tbxFirstnumberTkes.Text);
            }

            catch
            {
                //makes gives a message so that it doesn't crash and let's you know you did something wrong//
                MessageBox.Show("You did something wrong, Try again");
            }

            //creates the awnser & shows it//
            string awnserTkes = Convert.ToString(Math.Sqrt(firstNumberTkes));
            tbxOutputTkes.Text = Convert.ToString(awnserTkes);

            //makes the message that shows what you're calculating//
            lblDotsTkes.Text = (" √ " + firstNumberTkes +  " = " + awnserTkes);
        }

        private void btnSquareTkes_Click(object sender, EventArgs e)
        {
            //sets the counter & progressbar value to 4//
            counterTkes = 6;
            progressBar1.Value = 6;

            //creates the 2 ints, firstNumberTkes & secondNumberTkes and sets them to 0//
            double firstNumberTkes = 0;
            double secondNumberTkes = 0;


            try
            {
                //converts the two numbers to doubles//
                firstNumberTkes = Convert.ToDouble(tbxFirstnumberTkes.Text);
                secondNumberTkes = Convert.ToDouble(tbxSecondnumberTkes.Text);
            }

            catch
            {
                //makes gives a message so that it doesn't crash and let's you know you did something wrong//
                MessageBox.Show("You did something wrong, Try again");
            }
            //creates the awnser & shows it//
            string awnserTkes = Convert.ToString(Math.Pow(firstNumberTkes, secondNumberTkes));
            tbxOutputTkes.Text = Convert.ToString(awnserTkes);

            //makes the message that shows what you're calculating//
            lblDotsTkes.Text = (firstNumberTkes + " ^ " + secondNumberTkes + " = " + awnserTkes);
        }

        private void btnColorTkes_Click(object sender, EventArgs e)
        {
            //opens a color menu and makes sure that it works//
            cldMenuTkes.ShowDialog();
            this.BackColor = cldMenuTkes.Color;
        }

        private void btnAboutTkes_Click(object sender, EventArgs e)
        {
            //makes a pop-up message that shows who made the program//
            MessageBox.Show("Thanks to: Thijs van Kessel");
        }

        private void btnLocateTkes_Click(object sender, EventArgs e)
        {
            //gives you a pop-up that shows where on the computer the program is//
            MessageBox.Show(Application.ExecutablePath);
        }

        private void btnFunTkes_Click(object sender, EventArgs e)
        {
            //gives a pop-up that shows a recent spicy meme//
            MessageBox.Show("Coconuts aren't spices");
        }

        private void btnClearTkes_Click(object sender, EventArgs e)
        {
            //clears everything//
            tbxFirstnumberTkes.Clear();
            tbxSecondnumberTkes.Clear();
            tbxOutputTkes.Clear();
            progressBar1.Value = 0;
            lblDotsTkes.Text = "...";
            BackColor = Color.WhiteSmoke;
            counterTkes = 0;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            //shows a pop-up with a fun easer egg//
            MessageBox.Show("Don't click me");
        }

        private void btnStepTkes_Click(object sender, EventArgs e)
        {
            //makes the counter value one higher when you click the step button//
            counterTkes = counterTkes + 1;
            
            //resets the counter if it is above the value of 6//
            if (counterTkes == 7)
            {
                progressBar1.Value = 0;
                counterTkes = 1;
            }

            //if you want more information about this bit look at the part above when you click the plus button//
            if (counterTkes == 1)
            {
                int firstNumberTkes = 0;
                int secondNumberTkes = 0;
                progressBar1.Value = 1;

                try
                {
                    firstNumberTkes = Convert.ToInt32(tbxFirstnumberTkes.Text);
                    secondNumberTkes = Convert.ToInt32(tbxSecondnumberTkes.Text);
                }

                catch
                {
                    MessageBox.Show("You did something wrong, Try again");
                }
                int awnserTkes = firstNumberTkes + secondNumberTkes;
                tbxOutputTkes.Text = Convert.ToString(awnserTkes);

                lblDotsTkes.Text = (firstNumberTkes + " + " + secondNumberTkes + " = " + awnserTkes);
            }


            //if you want more information about this bit look at the part above when you click the minus button//
            if (counterTkes == 2)
            {
                int firstNumberTkes = 0;
                int secondNumberTkes = 0;
                progressBar1.Value = 2;

                try
                {
                    firstNumberTkes = Convert.ToInt32(tbxFirstnumberTkes.Text);
                    secondNumberTkes = Convert.ToInt32(tbxSecondnumberTkes.Text);
                }

                catch
                {
                    MessageBox.Show("You did something wrong, Try again");
                }
                int awnserTkes = firstNumberTkes - secondNumberTkes;
                tbxOutputTkes.Text = Convert.ToString(awnserTkes);

                lblDotsTkes.Text = (firstNumberTkes + " - " + secondNumberTkes + " = " + awnserTkes);
            }

            //if you want more information about this bit look at the part above when you click the times button//
            if (counterTkes == 3)
            {
                int firstNumberTkes = 0;
                int secondNumberTkes = 0;
                progressBar1.Value = 3;

                try
                {
                    firstNumberTkes = Convert.ToInt32(tbxFirstnumberTkes.Text);
                    secondNumberTkes = Convert.ToInt32(tbxSecondnumberTkes.Text);
                }

                catch
                {
                    MessageBox.Show("You did something wrong, Try again");
                }
                int awnserTkes = firstNumberTkes * secondNumberTkes;
                tbxOutputTkes.Text = Convert.ToString(awnserTkes);

                lblDotsTkes.Text = (firstNumberTkes + " X " + secondNumberTkes + " = " + awnserTkes);
            }

            //if you want more information about this bit look at the part above when you click the devide button//
            if (counterTkes == 4)
            {
                int firstNumberTkes = 0;
                int secondNumberTkes = 0;
                progressBar1.Value = 4;

                try
                {
                    firstNumberTkes = Convert.ToInt32(tbxFirstnumberTkes.Text);
                    secondNumberTkes = Convert.ToInt32(tbxSecondnumberTkes.Text);
                }

                catch
                {
                    MessageBox.Show("You did something wrong, Try again");
                }
                int awnserTkes = firstNumberTkes / secondNumberTkes;
                tbxOutputTkes.Text = Convert.ToString(awnserTkes);

                lblDotsTkes.Text = (firstNumberTkes + " : " + secondNumberTkes + " = " + awnserTkes);
            }

            //if you want more information about this bit look at the part above when you click the root button//
            if (counterTkes == 5)
            {
                double firstNumberTkes = 0;
                double secondNumberTkes;
                progressBar1.Value = 5;

                try
                {
                    firstNumberTkes = Convert.ToDouble(tbxFirstnumberTkes.Text);
                    secondNumberTkes = Convert.ToDouble(tbxSecondnumberTkes.Text);
                }

                catch
                {
                    MessageBox.Show("You did something wrong, Try again");
                }
                string awnserTkes = Convert.ToString(Math.Sqrt(firstNumberTkes));
                tbxOutputTkes.Text = Convert.ToString(awnserTkes);

                lblDotsTkes.Text = (" √ " + firstNumberTkes + " = " + awnserTkes);
            }

            //if you want more information about this bit look at the part above when you click the square button//
            if (counterTkes == 6)
            {
                double firstNumberTkes = 0;
                double secondNumberTkes = 0;
                progressBar1.Value = 6;

                try
                {
                    firstNumberTkes = Convert.ToDouble(tbxFirstnumberTkes.Text);
                    secondNumberTkes = Convert.ToDouble(tbxSecondnumberTkes.Text);
                }

                catch
                {
                    MessageBox.Show("You did something wrong, Try again");
                }
                string awnserTkes = Convert.ToString(Math.Pow(firstNumberTkes, secondNumberTkes));
                tbxOutputTkes.Text = Convert.ToString(awnserTkes);

                lblDotsTkes.Text = (firstNumberTkes + " ^ " + secondNumberTkes + " = " + awnserTkes);
            }
        }
    }
}
