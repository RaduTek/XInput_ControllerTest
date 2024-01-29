namespace ControllerTest
{
    partial class MainForm
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
            this.logBox = new System.Windows.Forms.TextBox();
            this.logPanel = new System.Windows.Forms.Panel();
            this.pollingTimer = new System.Windows.Forms.Timer(this.components);
            this.LeftX = new System.Windows.Forms.ProgressBar();
            this.LeftY = new System.Windows.Forms.ProgressBar();
            this.RightX = new System.Windows.Forms.ProgressBar();
            this.RightY = new System.Windows.Forms.ProgressBar();
            this.LeftTrigger = new System.Windows.Forms.ProgressBar();
            this.RightTrigger = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.analogGroup = new System.Windows.Forms.GroupBox();
            this.buttonsGroup = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.RightThumb = new System.Windows.Forms.CheckBox();
            this.LeftThumb = new System.Windows.Forms.CheckBox();
            this.RightBumper = new System.Windows.Forms.CheckBox();
            this.LeftBumper = new System.Windows.Forms.CheckBox();
            this.RightBtn = new System.Windows.Forms.CheckBox();
            this.DownBtn = new System.Windows.Forms.CheckBox();
            this.UpBtn = new System.Windows.Forms.CheckBox();
            this.LeftBtn = new System.Windows.Forms.CheckBox();
            this.BBtn = new System.Windows.Forms.CheckBox();
            this.ABtn = new System.Windows.Forms.CheckBox();
            this.YBtn = new System.Windows.Forms.CheckBox();
            this.XBtn = new System.Windows.Forms.CheckBox();
            this.StartBtn = new System.Windows.Forms.CheckBox();
            this.BackBtn = new System.Windows.Forms.CheckBox();
            this.selectedController = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.enablePolling = new System.Windows.Forms.CheckBox();
            this.testVibration = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.reconnectBtn = new System.Windows.Forms.Button();
            this.logPanel.SuspendLayout();
            this.analogGroup.SuspendLayout();
            this.buttonsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectedController)).BeginInit();
            this.SuspendLayout();
            // 
            // logBox
            // 
            this.logBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logBox.Location = new System.Drawing.Point(0, 0);
            this.logBox.Multiline = true;
            this.logBox.Name = "logBox";
            this.logBox.ReadOnly = true;
            this.logBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logBox.Size = new System.Drawing.Size(516, 118);
            this.logBox.TabIndex = 0;
            // 
            // logPanel
            // 
            this.logPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.logPanel.Controls.Add(this.logBox);
            this.logPanel.Location = new System.Drawing.Point(12, 275);
            this.logPanel.Name = "logPanel";
            this.logPanel.Size = new System.Drawing.Size(520, 122);
            this.logPanel.TabIndex = 1;
            // 
            // pollingTimer
            // 
            this.pollingTimer.Interval = 10;
            this.pollingTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LeftX
            // 
            this.LeftX.ForeColor = System.Drawing.Color.Green;
            this.LeftX.Location = new System.Drawing.Point(134, 19);
            this.LeftX.Maximum = 65535;
            this.LeftX.Name = "LeftX";
            this.LeftX.Size = new System.Drawing.Size(100, 18);
            this.LeftX.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.LeftX.TabIndex = 3;
            // 
            // LeftY
            // 
            this.LeftY.ForeColor = System.Drawing.Color.Green;
            this.LeftY.Location = new System.Drawing.Point(134, 43);
            this.LeftY.Maximum = 65535;
            this.LeftY.Name = "LeftY";
            this.LeftY.Size = new System.Drawing.Size(100, 18);
            this.LeftY.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.LeftY.TabIndex = 4;
            // 
            // RightX
            // 
            this.RightX.ForeColor = System.Drawing.Color.Purple;
            this.RightX.Location = new System.Drawing.Point(345, 19);
            this.RightX.Maximum = 65535;
            this.RightX.Name = "RightX";
            this.RightX.Size = new System.Drawing.Size(100, 18);
            this.RightX.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.RightX.TabIndex = 5;
            // 
            // RightY
            // 
            this.RightY.ForeColor = System.Drawing.Color.Purple;
            this.RightY.Location = new System.Drawing.Point(345, 43);
            this.RightY.Maximum = 65535;
            this.RightY.Name = "RightY";
            this.RightY.Size = new System.Drawing.Size(100, 18);
            this.RightY.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.RightY.TabIndex = 6;
            // 
            // LeftTrigger
            // 
            this.LeftTrigger.ForeColor = System.Drawing.Color.Green;
            this.LeftTrigger.Location = new System.Drawing.Point(134, 67);
            this.LeftTrigger.Maximum = 255;
            this.LeftTrigger.Name = "LeftTrigger";
            this.LeftTrigger.Size = new System.Drawing.Size(100, 18);
            this.LeftTrigger.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.LeftTrigger.TabIndex = 7;
            // 
            // RightTrigger
            // 
            this.RightTrigger.ForeColor = System.Drawing.Color.Purple;
            this.RightTrigger.Location = new System.Drawing.Point(345, 67);
            this.RightTrigger.Maximum = 255;
            this.RightTrigger.Name = "RightTrigger";
            this.RightTrigger.Size = new System.Drawing.Size(100, 18);
            this.RightTrigger.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.RightTrigger.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Left X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Left Y:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Right X:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(294, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Right Y:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Left Trigger:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(268, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Right Trigger:";
            // 
            // analogGroup
            // 
            this.analogGroup.Controls.Add(this.RightX);
            this.analogGroup.Controls.Add(this.label6);
            this.analogGroup.Controls.Add(this.LeftX);
            this.analogGroup.Controls.Add(this.label5);
            this.analogGroup.Controls.Add(this.LeftY);
            this.analogGroup.Controls.Add(this.label4);
            this.analogGroup.Controls.Add(this.RightY);
            this.analogGroup.Controls.Add(this.label3);
            this.analogGroup.Controls.Add(this.LeftTrigger);
            this.analogGroup.Controls.Add(this.label2);
            this.analogGroup.Controls.Add(this.RightTrigger);
            this.analogGroup.Controls.Add(this.label1);
            this.analogGroup.Location = new System.Drawing.Point(14, 41);
            this.analogGroup.Name = "analogGroup";
            this.analogGroup.Size = new System.Drawing.Size(518, 97);
            this.analogGroup.TabIndex = 15;
            this.analogGroup.TabStop = false;
            this.analogGroup.Text = "Analog Input";
            // 
            // buttonsGroup
            // 
            this.buttonsGroup.Controls.Add(this.label10);
            this.buttonsGroup.Controls.Add(this.label9);
            this.buttonsGroup.Controls.Add(this.label8);
            this.buttonsGroup.Controls.Add(this.RightThumb);
            this.buttonsGroup.Controls.Add(this.LeftThumb);
            this.buttonsGroup.Controls.Add(this.RightBumper);
            this.buttonsGroup.Controls.Add(this.LeftBumper);
            this.buttonsGroup.Controls.Add(this.RightBtn);
            this.buttonsGroup.Controls.Add(this.DownBtn);
            this.buttonsGroup.Controls.Add(this.UpBtn);
            this.buttonsGroup.Controls.Add(this.LeftBtn);
            this.buttonsGroup.Controls.Add(this.BBtn);
            this.buttonsGroup.Controls.Add(this.ABtn);
            this.buttonsGroup.Controls.Add(this.YBtn);
            this.buttonsGroup.Controls.Add(this.XBtn);
            this.buttonsGroup.Controls.Add(this.StartBtn);
            this.buttonsGroup.Controls.Add(this.BackBtn);
            this.buttonsGroup.Location = new System.Drawing.Point(14, 144);
            this.buttonsGroup.Name = "buttonsGroup";
            this.buttonsGroup.Size = new System.Drawing.Size(518, 125);
            this.buttonsGroup.TabIndex = 16;
            this.buttonsGroup.TabStop = false;
            this.buttonsGroup.Text = "Buttons";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Enabled = false;
            this.label9.Location = new System.Drawing.Point(426, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Bumper";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Enabled = false;
            this.label8.Location = new System.Drawing.Point(48, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Bumper";
            // 
            // RightThumb
            // 
            this.RightThumb.Appearance = System.Windows.Forms.Appearance.Button;
            this.RightThumb.AutoCheck = false;
            this.RightThumb.Location = new System.Drawing.Point(305, 24);
            this.RightThumb.Name = "RightThumb";
            this.RightThumb.Size = new System.Drawing.Size(40, 24);
            this.RightThumb.TabIndex = 14;
            this.RightThumb.Text = "R";
            this.RightThumb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RightThumb.UseVisualStyleBackColor = true;
            // 
            // LeftThumb
            // 
            this.LeftThumb.Appearance = System.Windows.Forms.Appearance.Button;
            this.LeftThumb.AutoCheck = false;
            this.LeftThumb.Location = new System.Drawing.Point(174, 24);
            this.LeftThumb.Name = "LeftThumb";
            this.LeftThumb.Size = new System.Drawing.Size(40, 24);
            this.LeftThumb.TabIndex = 13;
            this.LeftThumb.Text = "L";
            this.LeftThumb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LeftThumb.UseVisualStyleBackColor = true;
            // 
            // RightBumper
            // 
            this.RightBumper.Appearance = System.Windows.Forms.Appearance.Button;
            this.RightBumper.AutoCheck = false;
            this.RightBumper.Location = new System.Drawing.Point(475, 24);
            this.RightBumper.Name = "RightBumper";
            this.RightBumper.Size = new System.Drawing.Size(30, 24);
            this.RightBumper.TabIndex = 12;
            this.RightBumper.Text = "R";
            this.RightBumper.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RightBumper.UseVisualStyleBackColor = true;
            // 
            // LeftBumper
            // 
            this.LeftBumper.Appearance = System.Windows.Forms.Appearance.Button;
            this.LeftBumper.AutoCheck = false;
            this.LeftBumper.Location = new System.Drawing.Point(12, 24);
            this.LeftBumper.Name = "LeftBumper";
            this.LeftBumper.Size = new System.Drawing.Size(30, 24);
            this.LeftBumper.TabIndex = 11;
            this.LeftBumper.Text = "L";
            this.LeftBumper.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LeftBumper.UseVisualStyleBackColor = true;
            // 
            // RightBtn
            // 
            this.RightBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.RightBtn.AutoCheck = false;
            this.RightBtn.Location = new System.Drawing.Point(96, 75);
            this.RightBtn.Name = "RightBtn";
            this.RightBtn.Size = new System.Drawing.Size(30, 24);
            this.RightBtn.TabIndex = 10;
            this.RightBtn.Text = ">";
            this.RightBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RightBtn.UseVisualStyleBackColor = true;
            // 
            // DownBtn
            // 
            this.DownBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.DownBtn.AutoCheck = false;
            this.DownBtn.Location = new System.Drawing.Point(60, 91);
            this.DownBtn.Name = "DownBtn";
            this.DownBtn.Size = new System.Drawing.Size(30, 24);
            this.DownBtn.TabIndex = 9;
            this.DownBtn.Text = "v";
            this.DownBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DownBtn.UseVisualStyleBackColor = true;
            // 
            // UpBtn
            // 
            this.UpBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.UpBtn.AutoCheck = false;
            this.UpBtn.Location = new System.Drawing.Point(60, 61);
            this.UpBtn.Name = "UpBtn";
            this.UpBtn.Size = new System.Drawing.Size(30, 24);
            this.UpBtn.TabIndex = 8;
            this.UpBtn.Text = "^";
            this.UpBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UpBtn.UseVisualStyleBackColor = true;
            // 
            // LeftBtn
            // 
            this.LeftBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.LeftBtn.AutoCheck = false;
            this.LeftBtn.Location = new System.Drawing.Point(24, 75);
            this.LeftBtn.Name = "LeftBtn";
            this.LeftBtn.Size = new System.Drawing.Size(30, 24);
            this.LeftBtn.TabIndex = 7;
            this.LeftBtn.Text = "<";
            this.LeftBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LeftBtn.UseVisualStyleBackColor = true;
            // 
            // BBtn
            // 
            this.BBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.BBtn.AutoCheck = false;
            this.BBtn.BackColor = System.Drawing.Color.Red;
            this.BBtn.Location = new System.Drawing.Point(463, 75);
            this.BBtn.Name = "BBtn";
            this.BBtn.Size = new System.Drawing.Size(30, 24);
            this.BBtn.TabIndex = 6;
            this.BBtn.Text = "B";
            this.BBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BBtn.UseVisualStyleBackColor = false;
            // 
            // ABtn
            // 
            this.ABtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.ABtn.AutoCheck = false;
            this.ABtn.BackColor = System.Drawing.Color.LimeGreen;
            this.ABtn.Location = new System.Drawing.Point(427, 91);
            this.ABtn.Name = "ABtn";
            this.ABtn.Size = new System.Drawing.Size(30, 24);
            this.ABtn.TabIndex = 5;
            this.ABtn.Text = "A";
            this.ABtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ABtn.UseVisualStyleBackColor = false;
            // 
            // YBtn
            // 
            this.YBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.YBtn.AutoCheck = false;
            this.YBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.YBtn.Location = new System.Drawing.Point(427, 61);
            this.YBtn.Name = "YBtn";
            this.YBtn.Size = new System.Drawing.Size(30, 24);
            this.YBtn.TabIndex = 4;
            this.YBtn.Text = "Y";
            this.YBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.YBtn.UseVisualStyleBackColor = false;
            // 
            // XBtn
            // 
            this.XBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.XBtn.AutoCheck = false;
            this.XBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.XBtn.Location = new System.Drawing.Point(391, 75);
            this.XBtn.Name = "XBtn";
            this.XBtn.Size = new System.Drawing.Size(30, 24);
            this.XBtn.TabIndex = 3;
            this.XBtn.Text = "X";
            this.XBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.XBtn.UseVisualStyleBackColor = false;
            // 
            // StartBtn
            // 
            this.StartBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.StartBtn.AutoCheck = false;
            this.StartBtn.Location = new System.Drawing.Point(292, 75);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(53, 24);
            this.StartBtn.TabIndex = 2;
            this.StartBtn.Text = "Start";
            this.StartBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.StartBtn.UseVisualStyleBackColor = true;
            // 
            // BackBtn
            // 
            this.BackBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.BackBtn.AutoCheck = false;
            this.BackBtn.Location = new System.Drawing.Point(174, 75);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(53, 24);
            this.BackBtn.TabIndex = 0;
            this.BackBtn.Text = "Back";
            this.BackBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BackBtn.UseVisualStyleBackColor = true;
            // 
            // selectedController
            // 
            this.selectedController.Location = new System.Drawing.Point(479, 15);
            this.selectedController.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.selectedController.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.selectedController.Name = "selectedController";
            this.selectedController.Size = new System.Drawing.Size(43, 20);
            this.selectedController.TabIndex = 17;
            this.selectedController.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.selectedController.ValueChanged += new System.EventHandler(this.selectedController_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(390, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Controller Index:";
            // 
            // enablePolling
            // 
            this.enablePolling.Appearance = System.Windows.Forms.Appearance.Button;
            this.enablePolling.Location = new System.Drawing.Point(14, 12);
            this.enablePolling.Name = "enablePolling";
            this.enablePolling.Size = new System.Drawing.Size(104, 23);
            this.enablePolling.TabIndex = 19;
            this.enablePolling.Text = "Enable polling";
            this.enablePolling.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.enablePolling.UseVisualStyleBackColor = true;
            this.enablePolling.CheckedChanged += new System.EventHandler(this.enablePolling_CheckedChanged);
            // 
            // testVibration
            // 
            this.testVibration.Appearance = System.Windows.Forms.Appearance.Button;
            this.testVibration.Location = new System.Drawing.Point(124, 12);
            this.testVibration.Name = "testVibration";
            this.testVibration.Size = new System.Drawing.Size(104, 23);
            this.testVibration.TabIndex = 20;
            this.testVibration.Text = "Test vibration";
            this.testVibration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.testVibration.UseVisualStyleBackColor = true;
            this.testVibration.CheckedChanged += new System.EventHandler(this.testVibration_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Enabled = false;
            this.label10.Location = new System.Drawing.Point(220, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Thumb buttons";
            // 
            // reconnectBtn
            // 
            this.reconnectBtn.Location = new System.Drawing.Point(296, 12);
            this.reconnectBtn.Name = "reconnectBtn";
            this.reconnectBtn.Size = new System.Drawing.Size(85, 23);
            this.reconnectBtn.TabIndex = 21;
            this.reconnectBtn.Text = "Reconnect";
            this.reconnectBtn.UseVisualStyleBackColor = true;
            this.reconnectBtn.Click += new System.EventHandler(this.reconnectBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 409);
            this.Controls.Add(this.reconnectBtn);
            this.Controls.Add(this.testVibration);
            this.Controls.Add(this.enablePolling);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.selectedController);
            this.Controls.Add(this.buttonsGroup);
            this.Controls.Add(this.analogGroup);
            this.Controls.Add(this.logPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XInput Controller Test";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.logPanel.ResumeLayout(false);
            this.logPanel.PerformLayout();
            this.analogGroup.ResumeLayout(false);
            this.analogGroup.PerformLayout();
            this.buttonsGroup.ResumeLayout(false);
            this.buttonsGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectedController)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox logBox;
        private System.Windows.Forms.Panel logPanel;
        private System.Windows.Forms.Timer pollingTimer;
        private System.Windows.Forms.ProgressBar LeftX;
        private System.Windows.Forms.ProgressBar LeftY;
        private System.Windows.Forms.ProgressBar RightX;
        private System.Windows.Forms.ProgressBar RightY;
        private System.Windows.Forms.ProgressBar LeftTrigger;
        private System.Windows.Forms.ProgressBar RightTrigger;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox analogGroup;
        private System.Windows.Forms.GroupBox buttonsGroup;
        private System.Windows.Forms.CheckBox BBtn;
        private System.Windows.Forms.CheckBox ABtn;
        private System.Windows.Forms.CheckBox YBtn;
        private System.Windows.Forms.CheckBox XBtn;
        private System.Windows.Forms.CheckBox StartBtn;
        private System.Windows.Forms.CheckBox BackBtn;
        private System.Windows.Forms.CheckBox RightBumper;
        private System.Windows.Forms.CheckBox LeftBumper;
        private System.Windows.Forms.CheckBox RightBtn;
        private System.Windows.Forms.CheckBox DownBtn;
        private System.Windows.Forms.CheckBox UpBtn;
        private System.Windows.Forms.CheckBox LeftBtn;
        private System.Windows.Forms.NumericUpDown selectedController;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox enablePolling;
        private System.Windows.Forms.CheckBox testVibration;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox RightThumb;
        private System.Windows.Forms.CheckBox LeftThumb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button reconnectBtn;
    }
}

