using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Audio DLL import
using System.Runtime.InteropServices;

namespace RaadhetGetalTkes
{
    public partial class frmMysteryTkes : Form
    {
        int MaxValueTkes;
        int MinValueTkes;
        int randomNumberTkes;
        int GuessTkes = 0;
        int OldGuessTkes;
        int AttempsTkes;
        int DifTkes;
        int OldDifTkes;
        int PreviousGuessTkes;
        Random randomTkes = new Random();
        string soundNameTkes = "";

        //Start default audio handling code
        //dll import to add audio
        [DllImport("winmm.dll")]

        private static extern long mciSendString(
        string strCommand,
        StringBuilder strReturn,
        int iReturnLength,
        IntPtr hwndCallback);
        //End default audio handling code
        public frmMysteryTkes()
        {
            InitializeComponent();
            #region methodes
        }
        #region Readinputs
        private void ReadMaxAndMinTkes()
        ///read all the inputs from Value
        {
            MaxValueTkes = Convert.ToInt32(nudMaxValueTkes.Text);
            MinValueTkes = Convert.ToInt32(nudMinValueTkes.Text);
            AttempsTkes = Convert.ToInt32(cxbAttemptsTkes.Text);
            if (MinValueTkes > MaxValueTkes)
            {// if de value is higher as the minium value
                MessageBox.Show("Your max value needs to be higher than the min value. I've switched it for you. you can now play further.", "INFO");

            }
            #endregion
        }
        #region Audio
        private void PlayAudio()
        {
            //play audio
            mciSendString("open \"" +
                          Application.StartupPath +
                          "\\..\\..\\snd\\"
                          + soundNameTkes
                          + ".mp3"
                          + "\" type mpegvideo alias MediaFile", null, 0, IntPtr.Zero);

            mciSendString("play MediaFile", null, 0, IntPtr.Zero);
        }
        private static void StopAudio()
        {
            //Stop audio if audio already played
            mciSendString("close MediaFile", null, 0, IntPtr.Zero);
        }
        #endregion
        #region Random number
        private void btnGenerateTkes_Click(object sender, EventArgs e)
        {
            ReadMaxAndMinTkes();
            Random r = new Random();
            randomNumberTkes = randomTkes.Next(Math.Min(MinValueTkes, MaxValueTkes), Math.Max(MinValueTkes, MaxValueTkes)); //for ints
            tbxCheatValueTkes.Text = Convert.ToString(randomNumberTkes);
            pgbAttemptsTkes.Maximum = Convert.ToInt32(cxbAttemptsTkes.Text);
            pgbAttemptsTkes.Value = Convert.ToInt32(cxbAttemptsTkes.Text);
            lblAttemtsLeftTkes.Text = Convert.ToString(pgbAttemptsTkes.Maximum);
            gbxInputsTkes.Enabled = false;
            gbxGuessTkes.Enabled = true;
            // radomnumber is generated if you press generate, in the meanwhile de groupbox of inputs is disabled and the geuss groupbox is enabled

        }
        #endregion
        #region Reset
        private void ResetTkes()
        {
            nudMaxValueTkes.Text = "100";
            nudMinValueTkes.Text = "1";
            nudGuessTkes.Text = "0";
            tbxDiffrenceTkes.Text = "";
            tbxCheatValueTkes.Text = "";
            lblAttemtsLeftTkes.Text = "--";
            lblPreviousGuessTkes.Text = "--";
            lblWarmColdTkes.Text = "Not started";
            tbrColdWarmTkes.Maximum = 3;
            tbrColdWarmTkes.Minimum = 1;
            tbrColdWarmTkes.Value = 1;
            pgbAttemptsTkes.Value = 0;
            cxbAttemptsTkes.Text = "10";
            gbxGuessTkes.Enabled = false;
            gbxInputsTkes.Enabled = true;
            // every thing is set to 0 or standart value
        }
        #endregion
        #endregion

        #region Guess
        private void btnCheckGuessTkes_Click(object sender, EventArgs e)
        {
            OldGuessTkes = GuessTkes;// the old guess is given a value
            GuessTkes = Convert.ToInt32(nudGuessTkes.Text);
            OldDifTkes = DifTkes;// i have a diffrent to work with cold/warm system

            lblPreviousGuessTkes.Text = Convert.ToString(OldGuessTkes);

            PreviousGuessTkes = DifTkes;
            #region Win/Lose
            if (pgbAttemptsTkes.Value == 1)//this is if you lost the game
            {
                lblAttemtsLeftTkes.Text = "0";
                pgbAttemptsTkes.Value = 0;
                soundNameTkes = "MarioDeath";
                PlayAudio();
                DialogResult l_MessageboxOutputTkes = MessageBox.Show("The number was " + tbxCheatValueTkes.Text + "\nTry Again?",
                    "YOU HAVE LOST", MessageBoxButtons.YesNo);
                {
                    if (l_MessageboxOutputTkes == DialogResult.Yes)
                    {
                        ResetTkes();
                        StopAudio();
                    }
                    else if (l_MessageboxOutputTkes == DialogResult.No)
                    {
                        Application.Exit();
                        StopAudio();
                    }
                }
            }
            else
            {
                pgbAttemptsTkes.Value--;
                lblAttemtsLeftTkes.Text = Convert.ToString(pgbAttemptsTkes.Value);
            }

            if (GuessTkes == randomNumberTkes)//this is if you won the game
            {
                soundNameTkes = "aplause";
                PlayAudio();
                DialogResult l_MessageboxOutputTkes = MessageBox.Show("You guessed the number with  " + lblAttemtsLeftTkes.Text + " attempts left. Do You Want To Play Again?", "YOU HAVE WON", MessageBoxButtons.YesNo);
                {
                    if (l_MessageboxOutputTkes == DialogResult.Yes)
                    {

                        ResetTkes();
                        StopAudio();
                    }
                    else if (l_MessageboxOutputTkes == DialogResult.No)
                    {
                        Application.Exit();
                        StopAudio();
                    }
                }
            }
            else
            {
                #endregion
                #region trackbar
                DifTkes = Math.Max(randomNumberTkes, GuessTkes) - Math.Min(randomNumberTkes, GuessTkes);// the highest number minus de lowest number is the Diffrence
                tbrColdWarmTkes.Minimum = Math.Min(MinValueTkes, randomNumberTkes);
                tbrColdWarmTkes.Maximum = Math.Max(randomNumberTkes, MaxValueTkes);
                tbxDiffrenceTkes.Text = Convert.ToString(DifTkes);
                tbrColdWarmTkes.Value = (DifTkes);


                if (GuessTkes > MaxValueTkes)
                {
                    MessageBox.Show("Your guess was higher athen the Maximum value you have entered, You now have spilled one attempt.", "INFO");
                }
                else if (GuessTkes < MinValueTkes)
                {
                    MessageBox.Show("Your guess was lower then the Minimum value you have entered, You now have spilled one attempt.", "INFO");
                }
                else
                {

                }
                #endregion
                #region Warm/Cold
                if (OldDifTkes < DifTkes)//the warm/cold is controlled by the diffrence and the old diffrence
                {
                    lblWarmColdTkes.Text = "Colder";
                    lblWarmColdTkes.ForeColor = Color.Blue;
                }
                else if (OldDifTkes > DifTkes)
                {
                    lblWarmColdTkes.Text = "Warmer";
                    lblWarmColdTkes.ForeColor = Color.Red;
                    #endregion
                }
            }
        }
        #endregion



        #region Menu
        //this everything in the menu
        private void btnShowMenuTkes_Click(object sender, EventArgs e)
        {
            Width = 172;
            gbxMenuTkes.Enabled = true;
        }

        private void btnHideMenuTkes_Click(object sender, EventArgs e)
        {
            Width = 505;
            Height = 265;
            gbxMenuTkes.Enabled = false;
        }

        private void btnStopTkes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnResetTkes_Click(object sender, EventArgs e)
        {
            ResetTkes();
        }

        private void btnHideCheats_Click(object sender, EventArgs e)
        {
            Width = 505;
        }
        #region Settings
        private void btnSettingsTkes_Click(object sender, EventArgs e)
        {
            this.Height = 368;
            gbxMenuTkes.Enabled = false;
        }

        private void btnHideSettingsTkes_Click(object sender, EventArgs e)
        {
            this.Height = 210;
            gbxMenuTkes.Enabled = true;
        }
        #endregion
        #endregion
        #region Cheats

        private void tbxCheatsTkes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {

                if (tbxCheatsTkes.Text == "bringiton")
                {
                    Width = 652;
                    CheatActivatedTkes();
                }
                else if (tbxCheatsTkes.Text == "fullclip")
                {
                    cxbAttemptsTkes.Text = Convert.ToString(99999999);
                    CheatActivatedTkes();
                }
                else if (tbxCheatsTkes.Text == "naturaltalent")

                {
                    nudGuessTkes.Text = Convert.ToString(randomNumberTkes);
                    CheatActivatedTkes();
                }
                else if (tbxCheatsTkes.Text == "goodbyecruelworld")

                {
                    Application.Exit();
                    CheatActivatedTkes();
                }
                else if (tbxCheatsTkes.Text == "takearandomshot")
                {
                    int l_randomGuessTkes;
                    Random l_randomGTkes = new Random();
                    l_randomGuessTkes = l_randomGTkes.Next(Math.Min(MinValueTkes, MaxValueTkes), Math.Max(MinValueTkes, MaxValueTkes)); //for ints
                    nudGuessTkes.Text = Convert.ToString(l_randomGuessTkes);
                    CheatActivatedTkes();
                }
                else
                {
                    tbxCheatsTkes.Text = "Cheat Invalid";
                }
            }
        }

        private void CheatActivatedTkes()
        {
            tbxCheatsTkes.Text = "Cheat Activated";
        }
        #endregion
        #region Extra
        private void btnAboutTkes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by:\t\tThijs van Kessel\n" +
                           "Date: \t\t31 Okt 2018\n" +
                           "Special thanks to:\tMax van den Boom & Ruben Rutjens for helping me with some troubels.\n\n",
                           "About");
        }

        private void btnColorTkes_Click(object sender, EventArgs e)
        {
            // here will pop-up a color picker to chance the background
            if (cldBackColorTkes.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = cldBackColorTkes.Color;
            }
        }

        private void btnLocateTkes_Click(object sender, EventArgs e)
        {
            // to locate the savefile
            MessageBox.Show(Application.StartupPath);
        }

        private void btnManualTkes_Click(object sender, EventArgs e)
        {
            string m_locationTkes;
            m_locationTkes = Application.StartupPath;
            m_locationTkes = m_locationTkes + "\\..\\..\\Data\\Manual.pdf";
            System.Diagnostics.Process.Start(@m_locationTkes);
        }
        private void btnCheatCodesTkes_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                            "bringiton\t\tKrijg Cheat venster\n" +
                            "fullclip\t\t\tKrijg oneindig attempts\n" +
                            "naturaltalent\t\tgok meteen goed\n" +
                            "goodbyecruelworld\tsluit de game\n\n" +
                            "takearandomshot\t\tgok een random nummer\n");
        }
        #endregion

    }

}