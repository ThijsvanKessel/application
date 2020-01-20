using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace safeprojectname
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void initApplication()
        {
            this.Left = 200;
            this.Top = 200;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Text = "Serial Monitor"; //gives it the text on top
            this.ControlBox = false; //switch off the control buttons in the title bar
            initApplication();
        }

        public void PrintLnTkes(string a_textTkes, string a_colorTkes)
        {
            string m_colorTkes;

            m_colorTkes = a_colorTkes.ToUpper();//eliminate a possible problem of the letter casing

            switch (a_colorTkes)
            {
                case "R": rtbSerialMonitorTkes.SelectionColor = Color.Red; break;       //when the case R is the color is red
                case "G": rtbSerialMonitorTkes.SelectionColor = Color.Green; break;     //when the case G is the color is green
                case "B": rtbSerialMonitorTkes.SelectionColor = Color.Blue; break;      //when the case B is the color is blue
                default: rtbSerialMonitorTkes.SelectionColor = Color.White; break;      //when the case is something different the color is white
            }

            rtbSerialMonitorTkes.AppendText(a_textTkes + "\n");
            rtbSerialMonitorTkes.ScrollToCaret();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rtbSerialMonitorTkes.Clear();  //clears the serial monitor
        }
    }
}