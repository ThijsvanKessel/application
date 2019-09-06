using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Radio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("winmm.dll")]
        //default audio handling code
        private static extern long mciSendString(
        string strCommand,
        StringBuilder strReturn,
        int iReturnLength,
        IntPtr hwndCallback);

        private void btnStopTkes_Click(object sender, EventArgs e)
        {
            mciSendString("close MediaFile", null, 0, IntPtr.Zero);
        }

        private void btnPianoManTkes_Click(object sender, EventArgs e)
        {
            mciSendString("close MediaFile", null, 0, IntPtr.Zero);
            mciSendString("open \"" + Application.StartupPath
                + "\\..\\..\\Music\\"
                + "Billy Joel - Piano Man (Audio).mp3\" "
                + "type mpegvideo alias MediaFile", null, 0, IntPtr.Zero);
            mciSendString("play MediaFile", null, 0, IntPtr.Zero);
        }

        private void btnHotelCaliforniaTkes_Click(object sender, EventArgs e)
        {
            mciSendString("close MediaFile", null, 0, IntPtr.Zero);
            mciSendString("open \"" + Application.StartupPath
         + "\\..\\..\\Music\\"
         + "Hotel California - The Eagles (1976).mp3\" "
         + "type mpegvideo alias MediaFile", null, 0, IntPtr.Zero);
            mciSendString("play MediaFile", null, 0, IntPtr.Zero);
        }

        private void btnRingOfFireTkes_Click(object sender, EventArgs e)
        {
            mciSendString("close MediaFile", null, 0, IntPtr.Zero);
            mciSendString("open \"" + Application.StartupPath
              + "\\..\\..\\Music\\"
            + "Ring of Fire Johnny Cash.mp3\" "
            + "type mpegvideo alias MediaFile", null, 0, IntPtr.Zero);
            mciSendString("play MediaFile", null, 0, IntPtr.Zero);
        }

        private void btnNeverGonnaGiveYouUpTkes_Click(object sender, EventArgs e)
        {
            mciSendString("close MediaFile", null, 0, IntPtr.Zero);
            mciSendString("open \"" + Application.StartupPath
            + "\\..\\..\\Music\\"
            + "Rick Astley - Never Gonna Give You Up (Video).mp3\" "
            + "type mpegvideo alias MediaFile", null, 0, IntPtr.Zero);
            mciSendString("play MediaFile", null, 0, IntPtr.Zero);
        }
    }
}
