using safeprojectname;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#region Vault
namespace Vault
{
        #region public partial class
    public partial class Form1 : Form
    {
        Form2 serialMonitorTkes = new Form2();              //connects to the other form

        int counterTkes = 0;                                //creates an int
        string buttonPressedTkes= "";                       //creates a string
        int amountPressedTkes = 0;                          //creates an int
        #endregion

        #region Form1 
        public Form1()
        {
            InitializeComponent();
        }
        #endregion

        #region Cheat
        private void cbxCheatTkes_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxCheatTkes.Checked == true)       //checkes if the checkbox is checked
            {
                MessageBox.Show("The Code Is:\t3,2,3");     //makes a textbox appear with the included text
                cbxCheatTkes.Checked = false;               //sets the checkbox to not checked
            }
        }
        #endregion

        #region About
        private void btnAboutTkes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by:\t\tThijs van Kessel\n" +      //makes a textbox appear with the included text
             "Thanks to:\tMax van den Boom for helping\n" +
             "\t\t me with some troubels.\n\n",
             "About");
        }
        #endregion

        #region SerialMonitor
        private void cbxserialMonitorTkes_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxSerialMonitorTkes.Checked == true)            //checkes if the checkbox is checked
            {
                serialMonitorTkes.Show();     //shows the serial Monitor
            }
            else
            {
                serialMonitorTkes.Hide();     //hides the serial Monitor
            }
        }
        #endregion

        #region Buttons 
        private void btnImputsTkes_Click(object sender, EventArgs e)
        {
            // this is a combined eventhandler so when i press one of the buttons it will act as one function
            // this is counting how many times you have pressed the button if you have pressed the button 3 times it will check if you have the code correct or false.
            counterTkes++;
            amountPressedTkes = amountPressedTkes + 1;
            lblDotsTkes.Text = Convert.ToString(amountPressedTkes);

            if (amountPressedTkes == 4)
            {
                amountPressedTkes = 1; //sets the amount of pressed numbers to 1 for reusability
                lblDotsTkes.Text = Convert.ToString(amountPressedTkes);  //makes the text a string

            }

            if (sender == btnOneTkes)//checks if button 1 is pressed, if pressed it will add "1" to buttonpressedTkes 
            {
                buttonPressedTkes += 1;
                serialMonitorTkes.PrintLnTkes("Button 1 pressed", "B");//this will display "Button pressed" in the serialMonitorTkes
            }
            else if (sender == btnTwoTkes)//checks if button 2 is pressed, if pressed it will add "2" to buttonpressedTkes 
            {
                buttonPressedTkes += 2;
                serialMonitorTkes.PrintLnTkes("Button 2 Pressed", "B");//this will display "Button pressed" in the serialMonitorTkes
            }
            else if (sender == btnThreeTkes)//checks if button 3 is pressed, if pressed it will add "3" to buttonpressedTkes 
            {
                buttonPressedTkes += 3;
                serialMonitorTkes.PrintLnTkes("Button 3 Pressed", "B");//this will display "Button pressed" in the serialMonitorTkes
            }
            if (counterTkes == 3)   /* this if statment checks how many time you have pressed the button 
                                    if you have pressed it 3 times it will reset the counter, and checks if you have the code correct */
            {
                serialMonitorTkes.PrintLnTkes("You have enterred code" + buttonPressedTkes, "W"); //prints the text and adds pressed buttons
                counterTkes = 0;  //sets counter to 0 for later use
            

                if (buttonPressedTkes == "323")
                {
                    //if code is correct it will show in serialMonitorTkes that its correct, resets buttonPressedTkes, activates the timer for the OK light
                    serialMonitorTkes.PrintLnTkes("Code is Correct", "G");//this will display "Code is Correct" in the serialMonitorTkes
                    buttonPressedTkes = "";
                    pbxStatusTkes.BackColor = Color.FromArgb(18, 201, 21);
                }
                else
                {
                    //if code is not correct it will show in serialMonitorTkes that its incorrect, resets buttonPressedTkes, activates the timer for the NOT OK light 
                    serialMonitorTkes.PrintLnTkes("Code is not correct", "R");//this will display "Code not Correct" in the serialMonitorTkes
                    buttonPressedTkes = "";
                    pbxStatusTkes.BackColor = Color.FromArgb(255, 0, 0);
                }
            }
        }
        #endregion
    }
}
#endregion