namespace Autoclicker
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.customcoords = new System.Windows.Forms.RadioButton();
            this.trackptr = new System.Windows.Forms.RadioButton();
            this.tracktimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cursorY = new System.Windows.Forms.NumericUpDown();
            this.cursorX = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.clicknumber = new System.Windows.Forms.NumericUpDown();
            this.clickforever = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.clickduration = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.clickfreq = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.clicktimer = new System.Windows.Forms.Timer(this.components);
            this.keepclicking = new System.Windows.Forms.Timer(this.components);
            this.sendclicks = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cursorY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursorX)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clicknumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clickduration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clickfreq)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "X:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Y:";
            // 
            // customcoords
            // 
            this.customcoords.AutoSize = true;
            this.customcoords.Location = new System.Drawing.Point(12, 77);
            this.customcoords.Name = "customcoords";
            this.customcoords.Size = new System.Drawing.Size(119, 17);
            this.customcoords.TabIndex = 6;
            this.customcoords.TabStop = true;
            this.customcoords.Text = "Custom Coordinates";
            this.customcoords.UseVisualStyleBackColor = true;
            this.customcoords.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // trackptr
            // 
            this.trackptr.AutoSize = true;
            this.trackptr.Location = new System.Drawing.Point(12, 100);
            this.trackptr.Name = "trackptr";
            this.trackptr.Size = new System.Drawing.Size(89, 17);
            this.trackptr.TabIndex = 7;
            this.trackptr.TabStop = true;
            this.trackptr.Text = "Track Pointer";
            this.trackptr.UseVisualStyleBackColor = true;
            this.trackptr.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // tracktimer
            // 
            this.tracktimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cursorY);
            this.groupBox1.Controls.Add(this.cursorX);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.customcoords);
            this.groupBox1.Controls.Add(this.trackptr);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(163, 156);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mouse Coordinates";
            // 
            // cursorY
            // 
            this.cursorY.Location = new System.Drawing.Point(32, 46);
            this.cursorY.Name = "cursorY";
            this.cursorY.Size = new System.Drawing.Size(75, 20);
            this.cursorY.TabIndex = 9;
            // 
            // cursorX
            // 
            this.cursorX.Location = new System.Drawing.Point(32, 20);
            this.cursorX.Name = "cursorX";
            this.cursorX.Size = new System.Drawing.Size(75, 20);
            this.cursorX.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(9, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "[Space] to lock coordinates";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.clicknumber);
            this.groupBox2.Controls.Add(this.clickforever);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.clickduration);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.clickfreq);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(182, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(163, 156);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Click Settings";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(7, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Hover anywhere to stop";
            this.label9.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "every";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(102, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "click(s)";
            // 
            // clicknumber
            // 
            this.clicknumber.Location = new System.Drawing.Point(41, 18);
            this.clicknumber.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.clicknumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.clicknumber.Name = "clicknumber";
            this.clicknumber.Size = new System.Drawing.Size(58, 20);
            this.clicknumber.TabIndex = 6;
            this.clicknumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // clickforever
            // 
            this.clickforever.AutoSize = true;
            this.clickforever.Location = new System.Drawing.Point(10, 97);
            this.clickforever.Name = "clickforever";
            this.clickforever.Size = new System.Drawing.Size(101, 17);
            this.clickforever.TabIndex = 5;
            this.clickforever.Text = "Click indefinitely";
            this.clickforever.UseVisualStyleBackColor = true;
            this.clickforever.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "second(s)";
            // 
            // clickduration
            // 
            this.clickduration.Location = new System.Drawing.Point(10, 70);
            this.clickduration.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.clickduration.Name = "clickduration";
            this.clickduration.Size = new System.Drawing.Size(58, 20);
            this.clickduration.TabIndex = 3;
            this.clickduration.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(102, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "msec for";
            // 
            // clickfreq
            // 
            this.clickfreq.Location = new System.Drawing.Point(41, 44);
            this.clickfreq.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.clickfreq.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.clickfreq.Name = "clickfreq";
            this.clickfreq.Size = new System.Drawing.Size(58, 20);
            this.clickfreq.TabIndex = 1;
            this.clickfreq.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Send";
            // 
            // clicktimer
            // 
            this.clicktimer.Tick += new System.EventHandler(this.clicktimer_Tick);
            // 
            // keepclicking
            // 
            this.keepclicking.Tick += new System.EventHandler(this.keepclicking_Tick);
            // 
            // sendclicks
            // 
            this.sendclicks.Location = new System.Drawing.Point(12, 169);
            this.sendclicks.Name = "sendclicks";
            this.sendclicks.Size = new System.Drawing.Size(333, 23);
            this.sendclicks.TabIndex = 10;
            this.sendclicks.Text = "Send Clicks!";
            this.sendclicks.UseVisualStyleBackColor = true;
            this.sendclicks.EnabledChanged += new System.EventHandler(this.sendclicks_EnabledChanged);
            this.sendclicks.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(357, 201);
            this.Controls.Add(this.sendclicks);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Clickinator v1";
            this.TopMost = true;
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.Form1_HelpButtonClicked);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cursorY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursorX)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clicknumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clickduration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clickfreq)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton customcoords;
        private System.Windows.Forms.RadioButton trackptr;
        private System.Windows.Forms.Timer tracktimer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown cursorX;
        private System.Windows.Forms.NumericUpDown cursorY;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown clickduration;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown clickfreq;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox clickforever;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown clicknumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer clicktimer;
        private System.Windows.Forms.Timer keepclicking;
        private System.Windows.Forms.Button sendclicks;
        private System.Windows.Forms.Label label9;
    }
}

