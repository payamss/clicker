namespace Clicker
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
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtHour = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.txtSec = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblRemaining = new System.Windows.Forms.Label();
            this.ddList = new System.Windows.Forms.ComboBox();
            this.txtInterval = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMouseX = new System.Windows.Forms.TextBox();
            this.txtMouseY = new System.Windows.Forms.TextBox();
            this.btnGrab = new System.Windows.Forms.Button();
            this.txtMouseX2 = new System.Windows.Forms.TextBox();
            this.txtMouseY2 = new System.Windows.Forms.TextBox();
            this.btnGrab2 = new System.Windows.Forms.Button();
            this.delay = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Hour = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cb1 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(375, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // txtHour
            // 
            this.txtHour.Location = new System.Drawing.Point(76, 36);
            this.txtHour.Margin = new System.Windows.Forms.Padding(2);
            this.txtHour.Name = "txtHour";
            this.txtHour.Size = new System.Drawing.Size(32, 20);
            this.txtHour.TabIndex = 1;
            this.txtHour.Text = "11";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Time to Start";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 36);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Time to Start";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 64);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "x";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(91, 64);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "y";
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(128, 36);
            this.txtMin.Margin = new System.Windows.Forms.Padding(2);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(32, 20);
            this.txtMin.TabIndex = 2;
            this.txtMin.Text = "30";
            // 
            // txtSec
            // 
            this.txtSec.Location = new System.Drawing.Point(180, 36);
            this.txtSec.Margin = new System.Windows.Forms.Padding(2);
            this.txtSec.Name = "txtSec";
            this.txtSec.Size = new System.Drawing.Size(32, 20);
            this.txtSec.TabIndex = 3;
            this.txtSec.Text = "11";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(172, 14);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Seconds";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.SteelBlue;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Location = new System.Drawing.Point(343, 64);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(112, 90);
            this.btnStart.TabIndex = 13;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblRemaining
            // 
            this.lblRemaining.AutoSize = true;
            this.lblRemaining.Location = new System.Drawing.Point(375, 40);
            this.lblRemaining.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRemaining.Name = "lblRemaining";
            this.lblRemaining.Size = new System.Drawing.Size(24, 13);
            this.lblRemaining.TabIndex = 5;
            this.lblRemaining.Text = "test";
            // 
            // ddList
            // 
            this.ddList.FormattingEnabled = true;
            this.ddList.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.ddList.Location = new System.Drawing.Point(225, 36);
            this.ddList.Margin = new System.Windows.Forms.Padding(2);
            this.ddList.Name = "ddList";
            this.ddList.Size = new System.Drawing.Size(62, 21);
            this.ddList.TabIndex = 4;
            this.ddList.Text = "PM";
            // 
            // txtInterval
            // 
            this.txtInterval.Location = new System.Drawing.Point(307, 37);
            this.txtInterval.Margin = new System.Windows.Forms.Padding(2);
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.Size = new System.Drawing.Size(53, 20);
            this.txtInterval.TabIndex = 5;
            this.txtInterval.Text = "100";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(302, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Interval (ms)";
            // 
            // txtMouseX
            // 
            this.txtMouseX.Location = new System.Drawing.Point(31, 91);
            this.txtMouseX.Margin = new System.Windows.Forms.Padding(2);
            this.txtMouseX.Name = "txtMouseX";
            this.txtMouseX.Size = new System.Drawing.Size(42, 20);
            this.txtMouseX.TabIndex = 6;
            this.txtMouseX.Text = "500";
            // 
            // txtMouseY
            // 
            this.txtMouseY.Location = new System.Drawing.Point(86, 91);
            this.txtMouseY.Margin = new System.Windows.Forms.Padding(2);
            this.txtMouseY.Name = "txtMouseY";
            this.txtMouseY.Size = new System.Drawing.Size(44, 20);
            this.txtMouseY.TabIndex = 7;
            this.txtMouseY.Text = "500";
            // 
            // btnGrab
            // 
            this.btnGrab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrab.Location = new System.Drawing.Point(138, 85);
            this.btnGrab.Margin = new System.Windows.Forms.Padding(2);
            this.btnGrab.Name = "btnGrab";
            this.btnGrab.Size = new System.Drawing.Size(124, 32);
            this.btnGrab.TabIndex = 8;
            this.btnGrab.Text = "Grab";
            this.btnGrab.UseVisualStyleBackColor = true;
            this.btnGrab.Click += new System.EventHandler(this.btnGrab_Click);
            // 
            // txtMouseX2
            // 
            this.txtMouseX2.Location = new System.Drawing.Point(31, 128);
            this.txtMouseX2.Margin = new System.Windows.Forms.Padding(2);
            this.txtMouseX2.Name = "txtMouseX2";
            this.txtMouseX2.Size = new System.Drawing.Size(42, 20);
            this.txtMouseX2.TabIndex = 9;
            this.txtMouseX2.Text = "500";
            // 
            // txtMouseY2
            // 
            this.txtMouseY2.Location = new System.Drawing.Point(86, 128);
            this.txtMouseY2.Margin = new System.Windows.Forms.Padding(2);
            this.txtMouseY2.Name = "txtMouseY2";
            this.txtMouseY2.Size = new System.Drawing.Size(44, 20);
            this.txtMouseY2.TabIndex = 10;
            this.txtMouseY2.Text = "500";
            // 
            // btnGrab2
            // 
            this.btnGrab2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrab2.Location = new System.Drawing.Point(138, 122);
            this.btnGrab2.Margin = new System.Windows.Forms.Padding(2);
            this.btnGrab2.Name = "btnGrab2";
            this.btnGrab2.Size = new System.Drawing.Size(124, 32);
            this.btnGrab2.TabIndex = 11;
            this.btnGrab2.Text = "Grab";
            this.btnGrab2.UseVisualStyleBackColor = true;
            this.btnGrab2.Click += new System.EventHandler(this.btnGrab2_Click);
            // 
            // delay
            // 
            this.delay.Location = new System.Drawing.Point(279, 109);
            this.delay.Margin = new System.Windows.Forms.Padding(2);
            this.delay.Name = "delay";
            this.delay.Size = new System.Drawing.Size(53, 20);
            this.delay.TabIndex = 12;
            this.delay.Text = "2000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(278, 89);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Delay (ms)";
            // 
            // Hour
            // 
            this.Hour.AutoSize = true;
            this.Hour.Location = new System.Drawing.Point(75, 14);
            this.Hour.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Hour.Name = "Hour";
            this.Hour.Size = new System.Drawing.Size(35, 13);
            this.Hour.TabIndex = 4;
            this.Hour.Text = "Hours";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(122, 14);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Minutes";
            // 
            // cb1
            // 
            this.cb1.AutoSize = true;
            this.cb1.Location = new System.Drawing.Point(9, 131);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(15, 14);
            this.cb1.TabIndex = 14;
            this.cb1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 11);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(35, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "100";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, -2);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Opacity";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(464, 164);
            this.Controls.Add(this.cb1);
            this.Controls.Add(this.ddList);
            this.Controls.Add(this.btnGrab2);
            this.Controls.Add(this.btnGrab);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblRemaining);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Hour);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSec);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.delay);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtInterval);
            this.Controls.Add(this.txtMouseY2);
            this.Controls.Add(this.txtMouseY);
            this.Controls.Add(this.txtMouseX2);
            this.Controls.Add(this.txtMouseX);
            this.Controls.Add(this.txtHour);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Auto Clicker";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtHour;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.TextBox txtSec;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblRemaining;
        private System.Windows.Forms.ComboBox ddList;
        private System.Windows.Forms.TextBox txtInterval;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMouseX;
        private System.Windows.Forms.TextBox txtMouseY;
        private System.Windows.Forms.Button btnGrab;
        private System.Windows.Forms.TextBox txtMouseX2;
        private System.Windows.Forms.TextBox txtMouseY2;
        private System.Windows.Forms.Button btnGrab2;
        private System.Windows.Forms.TextBox delay;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Hour;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox cb1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
    }
}

