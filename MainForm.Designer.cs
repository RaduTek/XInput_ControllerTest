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
            this.LogBox = new System.Windows.Forms.TextBox();
            this.LogPanel = new System.Windows.Forms.Panel();
            this.PollingTimer = new System.Windows.Forms.Timer(this.components);
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
            this.AnalogGroup = new System.Windows.Forms.GroupBox();
            this.RightTriggerVal = new System.Windows.Forms.Label();
            this.RightYVal = new System.Windows.Forms.Label();
            this.RightXVal = new System.Windows.Forms.Label();
            this.LeftTriggerVal = new System.Windows.Forms.Label();
            this.LeftYVal = new System.Windows.Forms.Label();
            this.LeftXVal = new System.Windows.Forms.Label();
            this.ButtonsGroup = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
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
            this.SelectedControllerIndex = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.EnablePolling = new System.Windows.Forms.CheckBox();
            this.TestVibration = new System.Windows.Forms.CheckBox();
            this.ReconnectBtn = new System.Windows.Forms.Button();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.InputsTab = new System.Windows.Forms.TabPage();
            this.VibrationTab = new System.Windows.Forms.TabPage();
            this.VibrationGroup = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.RightVibrationValue = new System.Windows.Forms.Label();
            this.LeftVibrationValue = new System.Windows.Forms.Label();
            this.LeftVibration = new System.Windows.Forms.TrackBar();
            this.RightVibration = new System.Windows.Forms.TrackBar();
            this.label12 = new System.Windows.Forms.Label();
            this.VibrationSupported = new System.Windows.Forms.CheckBox();
            this.LogPanel.SuspendLayout();
            this.AnalogGroup.SuspendLayout();
            this.ButtonsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedControllerIndex)).BeginInit();
            this.MainTabControl.SuspendLayout();
            this.InputsTab.SuspendLayout();
            this.VibrationTab.SuspendLayout();
            this.VibrationGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LeftVibration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightVibration)).BeginInit();
            this.SuspendLayout();
            // 
            // LogBox
            // 
            this.LogBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LogBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogBox.Location = new System.Drawing.Point(0, 0);
            this.LogBox.Multiline = true;
            this.LogBox.Name = "LogBox";
            this.LogBox.ReadOnly = true;
            this.LogBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LogBox.Size = new System.Drawing.Size(534, 149);
            this.LogBox.TabIndex = 0;
            // 
            // LogPanel
            // 
            this.LogPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LogPanel.Controls.Add(this.LogBox);
            this.LogPanel.Location = new System.Drawing.Point(12, 315);
            this.LogPanel.Name = "LogPanel";
            this.LogPanel.Size = new System.Drawing.Size(538, 153);
            this.LogPanel.TabIndex = 1;
            // 
            // PollingTimer
            // 
            this.PollingTimer.Interval = 10;
            this.PollingTimer.Tick += new System.EventHandler(this.PollingTimer_Tick);
            // 
            // LeftX
            // 
            this.LeftX.ForeColor = System.Drawing.Color.Green;
            this.LeftX.Location = new System.Drawing.Point(108, 19);
            this.LeftX.Maximum = 65535;
            this.LeftX.Name = "LeftX";
            this.LeftX.Size = new System.Drawing.Size(100, 18);
            this.LeftX.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.LeftX.TabIndex = 3;
            // 
            // LeftY
            // 
            this.LeftY.ForeColor = System.Drawing.Color.Green;
            this.LeftY.Location = new System.Drawing.Point(108, 43);
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
            this.LeftTrigger.Location = new System.Drawing.Point(108, 67);
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
            this.label1.Location = new System.Drawing.Point(57, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Left X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 46);
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
            this.label5.Location = new System.Drawing.Point(31, 70);
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
            // AnalogGroup
            // 
            this.AnalogGroup.Controls.Add(this.RightTriggerVal);
            this.AnalogGroup.Controls.Add(this.RightYVal);
            this.AnalogGroup.Controls.Add(this.RightXVal);
            this.AnalogGroup.Controls.Add(this.LeftTriggerVal);
            this.AnalogGroup.Controls.Add(this.LeftYVal);
            this.AnalogGroup.Controls.Add(this.LeftXVal);
            this.AnalogGroup.Controls.Add(this.RightX);
            this.AnalogGroup.Controls.Add(this.label6);
            this.AnalogGroup.Controls.Add(this.LeftX);
            this.AnalogGroup.Controls.Add(this.label5);
            this.AnalogGroup.Controls.Add(this.LeftY);
            this.AnalogGroup.Controls.Add(this.label4);
            this.AnalogGroup.Controls.Add(this.RightY);
            this.AnalogGroup.Controls.Add(this.label3);
            this.AnalogGroup.Controls.Add(this.LeftTrigger);
            this.AnalogGroup.Controls.Add(this.label2);
            this.AnalogGroup.Controls.Add(this.RightTrigger);
            this.AnalogGroup.Controls.Add(this.label1);
            this.AnalogGroup.Location = new System.Drawing.Point(6, 6);
            this.AnalogGroup.Name = "AnalogGroup";
            this.AnalogGroup.Size = new System.Drawing.Size(518, 97);
            this.AnalogGroup.TabIndex = 15;
            this.AnalogGroup.TabStop = false;
            this.AnalogGroup.Text = "Analog";
            // 
            // RightTriggerVal
            // 
            this.RightTriggerVal.AutoSize = true;
            this.RightTriggerVal.Location = new System.Drawing.Point(451, 70);
            this.RightTriggerVal.Name = "RightTriggerVal";
            this.RightTriggerVal.Size = new System.Drawing.Size(10, 13);
            this.RightTriggerVal.TabIndex = 20;
            this.RightTriggerVal.Text = "-";
            // 
            // RightYVal
            // 
            this.RightYVal.AutoSize = true;
            this.RightYVal.Location = new System.Drawing.Point(451, 46);
            this.RightYVal.Name = "RightYVal";
            this.RightYVal.Size = new System.Drawing.Size(10, 13);
            this.RightYVal.TabIndex = 19;
            this.RightYVal.Text = "-";
            // 
            // RightXVal
            // 
            this.RightXVal.AutoSize = true;
            this.RightXVal.Location = new System.Drawing.Point(451, 22);
            this.RightXVal.Name = "RightXVal";
            this.RightXVal.Size = new System.Drawing.Size(10, 13);
            this.RightXVal.TabIndex = 18;
            this.RightXVal.Text = "-";
            // 
            // LeftTriggerVal
            // 
            this.LeftTriggerVal.AutoSize = true;
            this.LeftTriggerVal.Location = new System.Drawing.Point(214, 70);
            this.LeftTriggerVal.Name = "LeftTriggerVal";
            this.LeftTriggerVal.Size = new System.Drawing.Size(10, 13);
            this.LeftTriggerVal.TabIndex = 17;
            this.LeftTriggerVal.Text = "-";
            // 
            // LeftYVal
            // 
            this.LeftYVal.AutoSize = true;
            this.LeftYVal.Location = new System.Drawing.Point(214, 46);
            this.LeftYVal.Name = "LeftYVal";
            this.LeftYVal.Size = new System.Drawing.Size(10, 13);
            this.LeftYVal.TabIndex = 16;
            this.LeftYVal.Text = "-";
            // 
            // LeftXVal
            // 
            this.LeftXVal.AutoSize = true;
            this.LeftXVal.Location = new System.Drawing.Point(214, 22);
            this.LeftXVal.Name = "LeftXVal";
            this.LeftXVal.Size = new System.Drawing.Size(10, 13);
            this.LeftXVal.TabIndex = 15;
            this.LeftXVal.Text = "-";
            // 
            // ButtonsGroup
            // 
            this.ButtonsGroup.Controls.Add(this.label10);
            this.ButtonsGroup.Controls.Add(this.label9);
            this.ButtonsGroup.Controls.Add(this.label8);
            this.ButtonsGroup.Controls.Add(this.RightThumb);
            this.ButtonsGroup.Controls.Add(this.LeftThumb);
            this.ButtonsGroup.Controls.Add(this.RightBumper);
            this.ButtonsGroup.Controls.Add(this.LeftBumper);
            this.ButtonsGroup.Controls.Add(this.RightBtn);
            this.ButtonsGroup.Controls.Add(this.DownBtn);
            this.ButtonsGroup.Controls.Add(this.UpBtn);
            this.ButtonsGroup.Controls.Add(this.LeftBtn);
            this.ButtonsGroup.Controls.Add(this.BBtn);
            this.ButtonsGroup.Controls.Add(this.ABtn);
            this.ButtonsGroup.Controls.Add(this.YBtn);
            this.ButtonsGroup.Controls.Add(this.XBtn);
            this.ButtonsGroup.Controls.Add(this.StartBtn);
            this.ButtonsGroup.Controls.Add(this.BackBtn);
            this.ButtonsGroup.Location = new System.Drawing.Point(6, 109);
            this.ButtonsGroup.Name = "ButtonsGroup";
            this.ButtonsGroup.Size = new System.Drawing.Size(518, 125);
            this.ButtonsGroup.TabIndex = 16;
            this.ButtonsGroup.TabStop = false;
            this.ButtonsGroup.Text = "Buttons";
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
            // SelectedControllerIndex
            // 
            this.SelectedControllerIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedControllerIndex.Location = new System.Drawing.Point(507, 15);
            this.SelectedControllerIndex.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.SelectedControllerIndex.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SelectedControllerIndex.Name = "SelectedControllerIndex";
            this.SelectedControllerIndex.Size = new System.Drawing.Size(43, 20);
            this.SelectedControllerIndex.TabIndex = 17;
            this.SelectedControllerIndex.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SelectedControllerIndex.ValueChanged += new System.EventHandler(this.SelectedControllerIndex_ValueChanged);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(418, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Controller Index:";
            // 
            // EnablePolling
            // 
            this.EnablePolling.Appearance = System.Windows.Forms.Appearance.Button;
            this.EnablePolling.Location = new System.Drawing.Point(14, 12);
            this.EnablePolling.Name = "EnablePolling";
            this.EnablePolling.Size = new System.Drawing.Size(104, 23);
            this.EnablePolling.TabIndex = 19;
            this.EnablePolling.Text = "Enable polling";
            this.EnablePolling.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EnablePolling.UseVisualStyleBackColor = true;
            this.EnablePolling.CheckedChanged += new System.EventHandler(this.EnablePolling_CheckedChanged);
            // 
            // TestVibration
            // 
            this.TestVibration.Appearance = System.Windows.Forms.Appearance.Button;
            this.TestVibration.Location = new System.Drawing.Point(9, 120);
            this.TestVibration.Name = "TestVibration";
            this.TestVibration.Size = new System.Drawing.Size(104, 23);
            this.TestVibration.TabIndex = 20;
            this.TestVibration.Text = "Test vibration";
            this.TestVibration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TestVibration.UseVisualStyleBackColor = true;
            this.TestVibration.CheckedChanged += new System.EventHandler(this.TestVibration_CheckedChanged);
            // 
            // ReconnectBtn
            // 
            this.ReconnectBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ReconnectBtn.Location = new System.Drawing.Point(324, 12);
            this.ReconnectBtn.Name = "ReconnectBtn";
            this.ReconnectBtn.Size = new System.Drawing.Size(85, 23);
            this.ReconnectBtn.TabIndex = 21;
            this.ReconnectBtn.Text = "Reconnect";
            this.ReconnectBtn.UseVisualStyleBackColor = true;
            this.ReconnectBtn.Click += new System.EventHandler(this.ReconnectBtn_Click);
            // 
            // MainTabControl
            // 
            this.MainTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainTabControl.Controls.Add(this.InputsTab);
            this.MainTabControl.Controls.Add(this.VibrationTab);
            this.MainTabControl.Location = new System.Drawing.Point(12, 41);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(540, 268);
            this.MainTabControl.TabIndex = 22;
            // 
            // InputsTab
            // 
            this.InputsTab.Controls.Add(this.AnalogGroup);
            this.InputsTab.Controls.Add(this.ButtonsGroup);
            this.InputsTab.Location = new System.Drawing.Point(4, 22);
            this.InputsTab.Name = "InputsTab";
            this.InputsTab.Padding = new System.Windows.Forms.Padding(3);
            this.InputsTab.Size = new System.Drawing.Size(532, 242);
            this.InputsTab.TabIndex = 0;
            this.InputsTab.Text = "Inputs";
            this.InputsTab.UseVisualStyleBackColor = true;
            // 
            // VibrationTab
            // 
            this.VibrationTab.Controls.Add(this.VibrationGroup);
            this.VibrationTab.Controls.Add(this.VibrationSupported);
            this.VibrationTab.Location = new System.Drawing.Point(4, 22);
            this.VibrationTab.Name = "VibrationTab";
            this.VibrationTab.Padding = new System.Windows.Forms.Padding(3);
            this.VibrationTab.Size = new System.Drawing.Size(532, 242);
            this.VibrationTab.TabIndex = 1;
            this.VibrationTab.Text = "Vibration";
            this.VibrationTab.UseVisualStyleBackColor = true;
            // 
            // VibrationGroup
            // 
            this.VibrationGroup.Controls.Add(this.label11);
            this.VibrationGroup.Controls.Add(this.RightVibrationValue);
            this.VibrationGroup.Controls.Add(this.TestVibration);
            this.VibrationGroup.Controls.Add(this.LeftVibrationValue);
            this.VibrationGroup.Controls.Add(this.LeftVibration);
            this.VibrationGroup.Controls.Add(this.RightVibration);
            this.VibrationGroup.Controls.Add(this.label12);
            this.VibrationGroup.Location = new System.Drawing.Point(6, 34);
            this.VibrationGroup.Name = "VibrationGroup";
            this.VibrationGroup.Size = new System.Drawing.Size(520, 159);
            this.VibrationGroup.TabIndex = 29;
            this.VibrationGroup.TabStop = false;
            this.VibrationGroup.Text = "Vibration";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Left motor";
            // 
            // RightVibrationValue
            // 
            this.RightVibrationValue.AutoSize = true;
            this.RightVibrationValue.Location = new System.Drawing.Point(320, 73);
            this.RightVibrationValue.Name = "RightVibrationValue";
            this.RightVibrationValue.Size = new System.Drawing.Size(37, 13);
            this.RightVibrationValue.TabIndex = 28;
            this.RightVibrationValue.Text = "32768";
            // 
            // LeftVibrationValue
            // 
            this.LeftVibrationValue.AutoSize = true;
            this.LeftVibrationValue.Location = new System.Drawing.Point(320, 22);
            this.LeftVibrationValue.Name = "LeftVibrationValue";
            this.LeftVibrationValue.Size = new System.Drawing.Size(37, 13);
            this.LeftVibrationValue.TabIndex = 26;
            this.LeftVibrationValue.Text = "32768";
            // 
            // LeftVibration
            // 
            this.LeftVibration.LargeChange = 2048;
            this.LeftVibration.Location = new System.Drawing.Point(81, 18);
            this.LeftVibration.Maximum = 65535;
            this.LeftVibration.Name = "LeftVibration";
            this.LeftVibration.Size = new System.Drawing.Size(233, 45);
            this.LeftVibration.SmallChange = 1024;
            this.LeftVibration.TabIndex = 22;
            this.LeftVibration.TickFrequency = 2048;
            this.LeftVibration.Value = 32768;
            this.LeftVibration.Scroll += new System.EventHandler(this.LeftVibration_Scroll);
            // 
            // RightVibration
            // 
            this.RightVibration.LargeChange = 2048;
            this.RightVibration.Location = new System.Drawing.Point(81, 69);
            this.RightVibration.Maximum = 65535;
            this.RightVibration.Name = "RightVibration";
            this.RightVibration.Size = new System.Drawing.Size(233, 45);
            this.RightVibration.SmallChange = 1024;
            this.RightVibration.TabIndex = 25;
            this.RightVibration.TickFrequency = 2048;
            this.RightVibration.Value = 32768;
            this.RightVibration.Scroll += new System.EventHandler(this.RightVibration_Scroll);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 73);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Right motor";
            // 
            // VibrationSupported
            // 
            this.VibrationSupported.AutoCheck = false;
            this.VibrationSupported.AutoSize = true;
            this.VibrationSupported.Location = new System.Drawing.Point(8, 11);
            this.VibrationSupported.Name = "VibrationSupported";
            this.VibrationSupported.Size = new System.Drawing.Size(117, 17);
            this.VibrationSupported.TabIndex = 21;
            this.VibrationSupported.Text = "Vibration supported";
            this.VibrationSupported.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 480);
            this.Controls.Add(this.MainTabControl);
            this.Controls.Add(this.ReconnectBtn);
            this.Controls.Add(this.EnablePolling);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SelectedControllerIndex);
            this.Controls.Add(this.LogPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XInput Controller Test";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.LogPanel.ResumeLayout(false);
            this.LogPanel.PerformLayout();
            this.AnalogGroup.ResumeLayout(false);
            this.AnalogGroup.PerformLayout();
            this.ButtonsGroup.ResumeLayout(false);
            this.ButtonsGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedControllerIndex)).EndInit();
            this.MainTabControl.ResumeLayout(false);
            this.InputsTab.ResumeLayout(false);
            this.VibrationTab.ResumeLayout(false);
            this.VibrationTab.PerformLayout();
            this.VibrationGroup.ResumeLayout(false);
            this.VibrationGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LeftVibration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightVibration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LogBox;
        private System.Windows.Forms.Panel LogPanel;
        private System.Windows.Forms.Timer PollingTimer;
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
        private System.Windows.Forms.GroupBox AnalogGroup;
        private System.Windows.Forms.GroupBox ButtonsGroup;
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
        private System.Windows.Forms.NumericUpDown SelectedControllerIndex;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox EnablePolling;
        private System.Windows.Forms.CheckBox TestVibration;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox RightThumb;
        private System.Windows.Forms.CheckBox LeftThumb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button ReconnectBtn;
        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage InputsTab;
        private System.Windows.Forms.TabPage VibrationTab;
        private System.Windows.Forms.Label RightTriggerVal;
        private System.Windows.Forms.Label RightYVal;
        private System.Windows.Forms.Label RightXVal;
        private System.Windows.Forms.Label LeftTriggerVal;
        private System.Windows.Forms.Label LeftYVal;
        private System.Windows.Forms.Label LeftXVal;
        private System.Windows.Forms.TrackBar LeftVibration;
        private System.Windows.Forms.CheckBox VibrationSupported;
        private System.Windows.Forms.TrackBar RightVibration;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label RightVibrationValue;
        private System.Windows.Forms.Label LeftVibrationValue;
        private System.Windows.Forms.GroupBox VibrationGroup;
    }
}

