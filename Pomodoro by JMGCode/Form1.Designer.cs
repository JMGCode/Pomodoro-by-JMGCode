namespace Pomodoro_by_JMGCode
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PBackground = new System.Windows.Forms.Panel();
            this.LblToMenu = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnStart = new System.Windows.Forms.Button();
            this.LblState = new System.Windows.Forms.Label();
            this.LblTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Pmenu = new System.Windows.Forms.Panel();
            this.TxtSegRest = new System.Windows.Forms.TextBox();
            this.TxtSegFocus = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TxtFocusedTime = new System.Windows.Forms.TextBox();
            this.LblToPomodoro = new System.Windows.Forms.Label();
            this.TxtRestTime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LblFocusedTime = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PBackground.SuspendLayout();
            this.Pmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // PBackground
            // 
            this.PBackground.BackColor = System.Drawing.Color.Tomato;
            this.PBackground.Controls.Add(this.LblToMenu);
            this.PBackground.Controls.Add(this.label2);
            this.PBackground.Controls.Add(this.label1);
            this.PBackground.Controls.Add(this.BtnStart);
            this.PBackground.Controls.Add(this.LblState);
            this.PBackground.Controls.Add(this.LblTime);
            this.PBackground.Location = new System.Drawing.Point(12, 12);
            this.PBackground.Name = "PBackground";
            this.PBackground.Size = new System.Drawing.Size(260, 237);
            this.PBackground.TabIndex = 0;
            this.PBackground.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PBackground_MouseDown);
            // 
            // LblToMenu
            // 
            this.LblToMenu.AutoSize = true;
            this.LblToMenu.BackColor = System.Drawing.Color.Transparent;
            this.LblToMenu.Font = new System.Drawing.Font("Wingdings 3", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.LblToMenu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblToMenu.Location = new System.Drawing.Point(3, 3);
            this.LblToMenu.Name = "LblToMenu";
            this.LblToMenu.Size = new System.Drawing.Size(28, 23);
            this.LblToMenu.TabIndex = 7;
            this.LblToMenu.Text = "3";
            this.LblToMenu.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(214, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "-";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(236, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "x";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BtnStart
            // 
            this.BtnStart.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStart.Location = new System.Drawing.Point(74, 176);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(129, 42);
            this.BtnStart.TabIndex = 4;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // LblState
            // 
            this.LblState.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold);
            this.LblState.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblState.Location = new System.Drawing.Point(22, 12);
            this.LblState.Name = "LblState";
            this.LblState.Size = new System.Drawing.Size(223, 67);
            this.LblState.TabIndex = 3;
            this.LblState.Text = "Focus ";
            this.LblState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblTime
            // 
            this.LblTime.AutoSize = true;
            this.LblTime.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTime.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblTime.Location = new System.Drawing.Point(33, 79);
            this.LblTime.Name = "LblTime";
            this.LblTime.Size = new System.Drawing.Size(195, 77);
            this.LblTime.TabIndex = 2;
            this.LblTime.Text = "25:00";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Pmenu
            // 
            this.Pmenu.BackColor = System.Drawing.Color.DarkGreen;
            this.Pmenu.Controls.Add(this.TxtSegRest);
            this.Pmenu.Controls.Add(this.TxtSegFocus);
            this.Pmenu.Controls.Add(this.textBox2);
            this.Pmenu.Controls.Add(this.textBox1);
            this.Pmenu.Controls.Add(this.TxtFocusedTime);
            this.Pmenu.Controls.Add(this.LblToPomodoro);
            this.Pmenu.Controls.Add(this.TxtRestTime);
            this.Pmenu.Controls.Add(this.label4);
            this.Pmenu.Controls.Add(this.LblFocusedTime);
            this.Pmenu.Controls.Add(this.label5);
            this.Pmenu.Controls.Add(this.label6);
            this.Pmenu.Location = new System.Drawing.Point(318, 12);
            this.Pmenu.Name = "Pmenu";
            this.Pmenu.Size = new System.Drawing.Size(260, 237);
            this.Pmenu.TabIndex = 8;
            // 
            // TxtSegRest
            // 
            this.TxtSegRest.BackColor = System.Drawing.Color.DarkGreen;
            this.TxtSegRest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtSegRest.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.TxtSegRest.ForeColor = System.Drawing.SystemColors.Menu;
            this.TxtSegRest.Location = new System.Drawing.Point(158, 155);
            this.TxtSegRest.MaxLength = 2;
            this.TxtSegRest.Name = "TxtSegRest";
            this.TxtSegRest.Size = new System.Drawing.Size(46, 40);
            this.TxtSegRest.TabIndex = 14;
            this.TxtSegRest.Text = "00";
            this.TxtSegRest.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtSegRest.Leave += new System.EventHandler(this.TxtSegRest_Leave);
            // 
            // TxtSegFocus
            // 
            this.TxtSegFocus.BackColor = System.Drawing.Color.DarkGreen;
            this.TxtSegFocus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtSegFocus.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.TxtSegFocus.ForeColor = System.Drawing.SystemColors.Menu;
            this.TxtSegFocus.Location = new System.Drawing.Point(158, 66);
            this.TxtSegFocus.MaxLength = 2;
            this.TxtSegFocus.Name = "TxtSegFocus";
            this.TxtSegFocus.Size = new System.Drawing.Size(46, 40);
            this.TxtSegFocus.TabIndex = 13;
            this.TxtSegFocus.Text = "00";
            this.TxtSegFocus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtSegFocus.Leave += new System.EventHandler(this.TxtSegFocus_Leave);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.DarkGreen;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.textBox2.ForeColor = System.Drawing.SystemColors.Menu;
            this.textBox2.Location = new System.Drawing.Point(129, 155);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(23, 40);
            this.textBox2.TabIndex = 12;
            this.textBox2.Text = ":";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DarkGreen;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.textBox1.ForeColor = System.Drawing.SystemColors.Menu;
            this.textBox1.Location = new System.Drawing.Point(129, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(23, 40);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = ":";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtFocusedTime
            // 
            this.TxtFocusedTime.BackColor = System.Drawing.Color.DarkGreen;
            this.TxtFocusedTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtFocusedTime.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.TxtFocusedTime.ForeColor = System.Drawing.SystemColors.Menu;
            this.TxtFocusedTime.Location = new System.Drawing.Point(77, 66);
            this.TxtFocusedTime.MaxLength = 2;
            this.TxtFocusedTime.Name = "TxtFocusedTime";
            this.TxtFocusedTime.Size = new System.Drawing.Size(46, 40);
            this.TxtFocusedTime.TabIndex = 7;
            this.TxtFocusedTime.Text = "25";
            this.TxtFocusedTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtFocusedTime.Leave += new System.EventHandler(this.TxtFocusedTime_Leave);
            // 
            // LblToPomodoro
            // 
            this.LblToPomodoro.AutoSize = true;
            this.LblToPomodoro.BackColor = System.Drawing.Color.Transparent;
            this.LblToPomodoro.Font = new System.Drawing.Font("Wingdings 3", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.LblToPomodoro.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblToPomodoro.Location = new System.Drawing.Point(3, 4);
            this.LblToPomodoro.Name = "LblToPomodoro";
            this.LblToPomodoro.Size = new System.Drawing.Size(28, 23);
            this.LblToPomodoro.TabIndex = 9;
            this.LblToPomodoro.Text = "3";
            this.LblToPomodoro.Click += new System.EventHandler(this.label7_Click);
            // 
            // TxtRestTime
            // 
            this.TxtRestTime.BackColor = System.Drawing.Color.DarkGreen;
            this.TxtRestTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtRestTime.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.TxtRestTime.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TxtRestTime.Location = new System.Drawing.Point(77, 155);
            this.TxtRestTime.MaxLength = 2;
            this.TxtRestTime.Name = "TxtRestTime";
            this.TxtRestTime.Size = new System.Drawing.Size(46, 40);
            this.TxtRestTime.TabIndex = 9;
            this.TxtRestTime.Text = "05";
            this.TxtRestTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtRestTime.Leave += new System.EventHandler(this.TxtRestTime_Leave);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(33, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 43);
            this.label4.TabIndex = 10;
            this.label4.Text = "Rest Time";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblFocusedTime
            // 
            this.LblFocusedTime.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFocusedTime.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblFocusedTime.Location = new System.Drawing.Point(33, 26);
            this.LblFocusedTime.Name = "LblFocusedTime";
            this.LblFocusedTime.Size = new System.Drawing.Size(197, 43);
            this.LblFocusedTime.TabIndex = 8;
            this.LblFocusedTime.Text = "Focus Time";
            this.LblFocusedTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(214, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "-";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(236, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "x";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(175, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "by @JMGCode";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(612, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "284, 272";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 272);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Pmenu);
            this.Controls.Add(this.PBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.PBackground.ResumeLayout(false);
            this.PBackground.PerformLayout();
            this.Pmenu.ResumeLayout(false);
            this.Pmenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PBackground;
        private System.Windows.Forms.Label LblState;
        private System.Windows.Forms.Label LblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblToMenu;
        private System.Windows.Forms.Panel Pmenu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtRestTime;
        private System.Windows.Forms.TextBox TxtFocusedTime;
        private System.Windows.Forms.Label LblToPomodoro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtSegRest;
        private System.Windows.Forms.TextBox TxtSegFocus;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblFocusedTime;
    }
}

