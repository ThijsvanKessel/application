using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragRaceTkes2
{
    public partial class Form1 : Form
    {
        Form2 SerialMonitor = new Form2();

        public Form1()
        {
            InitializeComponent();
        }

        #region Form Load
        private void Form1_Load(object sender, EventArgs e)
        {
            ResetTkes();

            //verwijdert de 3d effecten van de tabs
            tbcMainTkes.Appearance = TabAppearance.FlatButtons;
            //maakt de tabs super dun
            tbcMainTkes.ItemSize = new Size(0, 1);
            tbcMainTkes.SizeMode = TabSizeMode.Fixed;

            lblPlayer1ScoreNameTkes.Text = player1NameTkes + " " + "Score:";
            lblPlayer2ScoreNameTkes.Text = player2NameTkes + " " + "Score:";
            lblPlayer3ScoreNameTkes.Text = player3NameTkes + " " + "Score:";
            lblPlayer4ScoreNameTkes.Text = player4NameTkes + " " + "Score:";
        }
        #endregion
        #region Objects

        DragRaceTkes obPlayer1Tkes = new DragRaceTkes(27, 0);
        DragRaceTkes obPlayer2Tkes = new DragRaceTkes(27, 0);
        DragRaceTkes obPlayer3Tkes = new DragRaceTkes(27, 0);
        DragRaceTkes obPlayer4Tkes = new DragRaceTkes(27, 0);

        #endregion
        #region local variables


        double totalTimeTkes = 0;
        int finishCounterTkes = 1;
        string finishPositionTkes = "";

        bool car1RaceTkes = false;
        bool car2RaceTkes = false;
        bool car3RaceTkes = false;
        bool car4RaceTkes = false;

        //   bool totalTimeOnOffTkes = false;

        string player1NameTkes = "Thijs";
        string player2NameTkes = "Jari";
        string player3NameTkes = "Bart";
        string player4NameTkes = "Tijn";

        int player1ScoreTkes = 0;
        int player2ScoreTkes = 0;
        int player3ScoreTkes = 0;
        int player4ScoreTkes = 0;
        int playerAddScoreTkes = 1;

        #endregion
        #region Button GO

        private void btnGoTkes_Click(object sender, EventArgs e)
        {
            tmrRaceTimerTkes.Enabled = true;
            tmrRaceTimerTkes.Interval = 50;

            obPlayer1Tkes.SetRandomTkes();
            obPlayer2Tkes.SetRandomTkes();
            obPlayer3Tkes.SetRandomTkes();
            obPlayer4Tkes.SetRandomTkes();
            SerialMonitor.PrintLn("Button Go Pressed", "b");

            // totalTimeOnOffTkes = true;

        }
        #endregion
        #region Timer

        private void tmrRaceTimerTkes_Tick(object sender, EventArgs e)
        {
            #region Total Time
            //Total time of all cars 
            //this wil check if any car is still racing and if a car is racing it will continue counting 
            // if all cars are finished the timer will stop 
            //   if (totalTimeOnOffTkes == true)
            //  {
            if (obPlayer1Tkes.TimeStopTkes() == true || obPlayer2Tkes.TimeStopTkes() == true || obPlayer3Tkes.TimeStopTkes() == true || obPlayer4Tkes.TimeStopTkes() == true)
            {
                totalTimeTkes = totalTimeTkes + 0.05;
                lblTotalTimeTkes.Text = Convert.ToString(Math.Round(totalTimeTkes, 1));
                btnGoTkes.Enabled = false;
                btnResetTkes.Enabled = false;
            }


            // }
            #endregion
            #region movement cars
            //this moves the car's via the class 
            //Car1 
            pcbCar1Tkes.Left = obPlayer1Tkes.GrowTkes();
            lblCar1TimeTkes.Text = Convert.ToString(Math.Round(obPlayer1Tkes.timeTkes(), 1));

            //Car2
            pcbCar2Tkes.Left = obPlayer2Tkes.GrowTkes();
            lblCar2TimeTkes.Text = Convert.ToString(Math.Round(obPlayer2Tkes.timeTkes(), 1));

            //Car 3
            pcbCar3Tkes.Left = obPlayer3Tkes.GrowTkes();
            lblCar3TimeTkes.Text = Convert.ToString(Math.Round(obPlayer3Tkes.timeTkes(), 1));

            //Car 3
            pcbCar4Tkes.Left = obPlayer4Tkes.GrowTkes();
            lblCar4TimeTkes.Text = Convert.ToString(Math.Round(obPlayer4Tkes.timeTkes(), 1));


            #endregion
            #region Posistion
            //car 1 
            if (obPlayer1Tkes.TimeStopTkes() == false && car1RaceTkes == false)
            {
                finishCounterTkes++;
                lblPlace1Tkes.Text = player1NameTkes + " " + finishPositionTkes;
                car1RaceTkes = true;
                player1ScoreTkes = player1ScoreTkes + playerAddScoreTkes;
                lblCar1ScoreTkes.Text = Convert.ToString(player1ScoreTkes);
                SerialMonitor.PrintLn(player1NameTkes + " " + "finished", "b");
            }
            //car 2
            if (obPlayer2Tkes.TimeStopTkes() == false && car2RaceTkes == false)
            {
                finishCounterTkes++;
                lblPlace2Tkes.Text = player2NameTkes + " " + finishPositionTkes;
                car2RaceTkes = true;
                player2ScoreTkes = player2ScoreTkes + playerAddScoreTkes;
                lblCar2ScoreTkes.Text = Convert.ToString(player2ScoreTkes);
                SerialMonitor.PrintLn(player2NameTkes + " " + "finished", "b");
            }

            //car 3
            if (obPlayer3Tkes.TimeStopTkes() == false && car3RaceTkes == false)
            {
                finishCounterTkes++;
                lblPlace3Tkes.Text = player3NameTkes + " " + finishPositionTkes;
                car3RaceTkes = true;
                player3ScoreTkes = player3ScoreTkes + playerAddScoreTkes;
                lblCar3ScoreTkes.Text = Convert.ToString(player3ScoreTkes);
                SerialMonitor.PrintLn(player3NameTkes + " " + "finished", "b");
            }

            //car 4
            if (obPlayer4Tkes.TimeStopTkes() == false && car4RaceTkes == false)
            {
                finishCounterTkes++;
                lblPlace4Tkes.Text = player4NameTkes + " " + finishPositionTkes;
                car4RaceTkes = true;
                player4ScoreTkes = player4ScoreTkes + playerAddScoreTkes;
                lblCar4ScoreTkes.Text = Convert.ToString(player4ScoreTkes);
                SerialMonitor.PrintLn(player4NameTkes + " " + "finished", "b");

            }
            switch (finishCounterTkes)
            {
                case 1:
                    finishPositionTkes = "1st";
                    playerAddScoreTkes = 3;
                    break;
                case 2:
                    finishPositionTkes = "2nd";
                    playerAddScoreTkes = 2;
                    break;
                case 3:
                    finishPositionTkes = "3rd";
                    playerAddScoreTkes = 1;
                    break;
                case 4:
                    finishPositionTkes = "4th";
                    playerAddScoreTkes = 0;
                    break;
                case 5:
                    tmrRaceTimerTkes.Enabled = false;
                    //this enables the button reset/go again 
                    btnGoTkes.Enabled = true;
                    btnResetTkes.Enabled = true;
                    break;
            }

        }

        #endregion
        #endregion
        #region Reset

        private void btnResetTkes_Click(object sender, EventArgs e)
        {

            ResetTkes();
        }

        private void ResetTkes()
        {
            car1RaceTkes = false;
            car2RaceTkes = false;
            car3RaceTkes = false;
            car4RaceTkes = false;

            totalTimeTkes = 0;
            finishCounterTkes = 1;
            finishPositionTkes = "";

            pcbCar1Tkes.Left = 27;
            pcbCar2Tkes.Left = 27;
            pcbCar3Tkes.Left = 27;
            pcbCar4Tkes.Left = 27;

            obPlayer1Tkes.ResetCounterTkes(27, 0, 0, true);
            obPlayer2Tkes.ResetCounterTkes(27, 0, 0, true);
            obPlayer3Tkes.ResetCounterTkes(27, 0, 0, true);
            obPlayer4Tkes.ResetCounterTkes(27, 0, 0, true);

            obPlayer1Tkes.ResetTimeTkes();
            obPlayer2Tkes.ResetTimeTkes();
            obPlayer3Tkes.ResetTimeTkes();
            obPlayer4Tkes.ResetTimeTkes();

            lblCar1TimeTkes.Text = "--";
            lblCar2TimeTkes.Text = "--";

            lblCar3TimeTkes.Text = "--";
            lblCar4TimeTkes.Text = "--";

            lblTotalTimeTkes.Text = "--";

            lblPlace1Tkes.Text = "--";
            lblPlace2Tkes.Text = "--";
            lblPlace3Tkes.Text = "--";
            lblPlace4Tkes.Text = "--";

            //totalTimeOnOffTkes = false;
        }

        #endregion
        #region Menu Bar

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by:\t\tThijs van Kessel\n" +
                            "Date:\t\t22 jan 2019\n" +
                            "Special Thanks to:\t Julse Zwarts and Max van den Boom \n\n");
        }

        private void locateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Application.StartupPath);
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit the program?", "Are you sure?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void raceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbcMainTkes.SelectedTab = tbpRaceTkes;
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbcMainTkes.SelectedTab = tbpSettingsTkes;
        }

        private void serialMonitorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SerialMonitor.Show();
        }

        private void scoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbcMainTkes.SelectedTab = tbcScoresTkes;
        }


        #endregion
        private void btnSetNameTkes_Click(object sender, EventArgs e)
        {

            player1NameTkes = txbCar1NameTkes.Text;
            player2NameTkes = txbCar2NameTkes.Text;
            player3NameTkes = txbCar3NameTkes.Text;
            player4NameTkes = txbCar4NameTkes.Text;

            lblPlayer1ScoreNameTkes.Text = player1NameTkes + " " + "Score:";
            lblPlayer2ScoreNameTkes.Text = player2NameTkes + " " + "Score:";
            lblPlayer3ScoreNameTkes.Text = player3NameTkes + " " + "Score:";
            lblPlayer4ScoreNameTkes.Text = player4NameTkes + " " + "Score:";



        }

    }
}





