using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pomodoro_by_JMGCode
{
    public partial class Form1 : Form
    {
        int timeFocused = 1500;//25*60;
        int timeReset = 300;//5*60;
        int time = 0;
        bool focused = true;
        TimeSpan timeNow ;

        System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\jebus\Downloads\beep-07.wav");

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();



        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time--;
       
            if (time == 0)
            {
                if(focused)
                {
                    focused = false;
                    time = timeReset;
                    PBackground.BackColor = SystemColors.Highlight;
                    LblState.Text = "Rest";
                    this.Icon = Properties.Resources.iconfinder_smiley__16_2291000;
                }
                else
                {
                    focused = true;
                    time = timeFocused;
                    PBackground.BackColor = Color.Tomato;
                    LblState.Text = "Focus";
                    this.Icon = Properties.Resources.iconfinder_bag_3131965;
                }
                player.Play();
            }

            //update time
            timeNow = TimeSpan.FromSeconds(time);
            LblTime.Text = timeNow.ToString("mm':'ss");

        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            if(BtnStart.Text == "Start")
            {
                BtnStart.Text = "Reset";
                timeNow = TimeSpan.FromSeconds(timeFocused);
                time = timeFocused;
                LblTime.Text = timeNow.ToString("mm':'ss");
                PBackground.BackColor = Color.Tomato;
                timer1.Start();
            }
            else
            {
                BtnStart.Text = "Start";
                timeNow = TimeSpan.FromSeconds(timeFocused);
                time = timeFocused;
                LblTime.Text = timeNow.ToString("mm':'ss");
                PBackground.BackColor = Color.Tomato;
                timer1.Stop();
            }
            LblState.Text = "Focus";
            this.Icon = Properties.Resources.iconfinder_bag_3131965;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; 
        }

        private void PBackground_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            PBackground.Location = new Point(318,12);
            Pmenu.Location = new Point(12,12);

        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PBackground.Location = new Point(12, 12);
            Pmenu.Location = new Point(318, 12);
        }

        private void label7_Click(object sender, EventArgs e)
        {
            PBackground.Location = new Point(12, 12);
            Pmenu.Location = new Point(318, 12);
            timeFocused = Convert.ToInt32(TxtFocusedTime.Text) * 60;
            timeReset = Convert.ToInt32(TxtRestTime.Text) * 60;
        }
    }
}
