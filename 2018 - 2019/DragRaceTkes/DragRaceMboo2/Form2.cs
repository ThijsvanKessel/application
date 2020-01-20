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
            this.Text = "Serial Monitor";
            this.ControlBox = false; //switch off the control buttons in the title bar
            initApplication();
        }

        public void PrintLn(string a_text, string a_color)
        {
            string m_color;

            m_color = a_color.ToUpper();//eliminate a possible problem of the letter casing

            switch (a_color)
            {
                case "R": rtbSerialMonitor.SelectionColor = Color.DarkRed; break;
                case "G": rtbSerialMonitor.SelectionColor = Color.LightGreen; break;
                case "B": rtbSerialMonitor.SelectionColor = Color.LightBlue; break;
                default: rtbSerialMonitor.SelectionColor = Color.White; break;
            }

            rtbSerialMonitor.AppendText(a_text + "\n");
            rtbSerialMonitor.ScrollToCaret();
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {

            rtbSerialMonitor.Clear();
        }
    }
}

