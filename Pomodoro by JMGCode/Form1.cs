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
        TimeSpan timeSet;

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
                LblToMenu.Visible = false;
                BtnStart.Text = "Reset";
                timeNow = TimeSpan.FromSeconds(timeFocused);
                time = timeFocused;
                LblTime.Text = timeNow.ToString("mm':'ss");
                PBackground.BackColor = Color.Tomato;
                timer1.Start();
            }
            else
            {
                LblToMenu.Visible = true;
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
            timeFocused = (Convert.ToInt32(TxtFocusedTime.Text) * 60 ) + (Convert.ToInt32(TxtSegFocus.Text));
            timeReset = (Convert.ToInt32(TxtRestTime.Text) * 60 ) + (Convert.ToInt32(TxtSegRest.Text));

            //update time
            timeNow = TimeSpan.FromSeconds(timeFocused);
            time = timeFocused;
            LblTime.Text = timeNow.ToString("mm':'ss");
        }



        private void TxtSegRest_Leave(object sender, EventArgs e)
        {
            if (TxtSegRest.Text.Length == 1)
            {
                TxtSegRest.Text = "0" + TxtSegRest.Text;
            }
            if (TxtSegRest.Text.Length == 0)
            {
                TxtSegRest.Text = "00";
            }
            if (Convert.ToInt32(TxtSegRest.Text) > 59) { TxtSegRest.Text = "59"; }
        }

        private void TxtRestTime_Leave(object sender, EventArgs e)
        {
            if (TxtRestTime.Text.Length == 1)
            {
                TxtRestTime.Text = "0" + TxtRestTime.Text;
            }
            if (TxtRestTime.Text.Length == 0)
            {
                TxtRestTime.Text = "00";
            }
            if (Convert.ToInt32(TxtRestTime.Text) > 59) { TxtRestTime.Text = "59"; }
        }

        private void TxtFocusedTime_Leave(object sender, EventArgs e)
        {
            if (TxtFocusedTime.Text.Length == 1)
            {
                TxtFocusedTime.Text = "0" + TxtFocusedTime.Text;
            }
            if (TxtFocusedTime.Text.Length == 0)
            {
                TxtFocusedTime.Text = "00";
            }
            if (Convert.ToInt32(TxtFocusedTime.Text) > 59) { TxtFocusedTime.Text = "59"; }
        }

        private void TxtSegFocus_Leave(object sender, EventArgs e)
        {
            if (TxtSegFocus.Text.Length == 1)
            {
                TxtSegFocus.Text = "0" + TxtSegFocus.Text;
            }
            if (TxtSegFocus.Text.Length == 0)
            {
                TxtSegFocus.Text = "00";
            }
            if (Convert.ToInt32(TxtSegFocus.Text) > 59) { TxtSegFocus.Text = "59"; }
        }
    }
}
