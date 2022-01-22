using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApp1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.automaticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limitSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button12 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TorqueManualUp = new System.Windows.Forms.Button();
            this.SpeedManualUp = new System.Windows.Forms.Button();
            this.TorqueManualDown = new System.Windows.Forms.Button();
            this.FanSpeedManualUp = new System.Windows.Forms.Button();
            this.SpeedManualDown = new System.Windows.Forms.Button();
            this.FanSpeedManualDown = new System.Windows.Forms.Button();
            this.PressureManualUp = new System.Windows.Forms.Button();
            this.PressureManualDown = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Torque = new System.Windows.Forms.TrackBar();
            this.speed = new System.Windows.Forms.TrackBar();
            this.FanBar = new System.Windows.Forms.TrackBar();
            this.Pressure = new System.Windows.Forms.TrackBar();
            this.button8 = new System.Windows.Forms.Button();
            this.ConditionarManual = new System.Windows.Forms.Button();
            this.StartFanManual = new System.Windows.Forms.Button();
            this.LoadManual = new System.Windows.Forms.Button();
            this.DownManual = new System.Windows.Forms.Button();
            this.UnloadManual = new System.Windows.Forms.Button();
            this.UpManual = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.aGauge1 = new System.Windows.Forms.AGauge();
            this.aGauge2 = new System.Windows.Forms.AGauge();
            this.R0 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.EndButton = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Back = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.ConstP = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.Down = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.Up = new System.Windows.Forms.Label();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.Watering = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.LoadL = new System.Windows.Forms.Label();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.Conditioner = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.HandBrake = new System.Windows.Forms.Label();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.Fan = new System.Windows.Forms.Label();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.Brake = new System.Windows.Forms.Label();
            this.Hydrau = new System.Windows.Forms.Label();
            this.Unload = new System.Windows.Forms.Label();
            this.Unloading = new System.Windows.Forms.Label();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Torque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FanBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pressure)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.testToolStripMenuItem,
            this.settingToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1028, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualToolStripMenuItem,
            this.automaticToolStripMenuItem});
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.testToolStripMenuItem.Text = "Test";
            // 
            // manualToolStripMenuItem
            // 
            this.manualToolStripMenuItem.Name = "manualToolStripMenuItem";
            this.manualToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.manualToolStripMenuItem.Text = "Manual";
            this.manualToolStripMenuItem.Click += new System.EventHandler(this.manualToolStripMenuItem_Click);
            // 
            // automaticToolStripMenuItem
            // 
            this.automaticToolStripMenuItem.Name = "automaticToolStripMenuItem";
            this.automaticToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.automaticToolStripMenuItem.Text = "Automatic";
            this.automaticToolStripMenuItem.Click += new System.EventHandler(this.automaticToolStripMenuItem_Click);
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inputSettingToolStripMenuItem,
            this.limitSetupToolStripMenuItem});
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.settingToolStripMenuItem.Text = "Setting";
            // 
            // inputSettingToolStripMenuItem
            // 
            this.inputSettingToolStripMenuItem.Name = "inputSettingToolStripMenuItem";
            this.inputSettingToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.inputSettingToolStripMenuItem.Text = "Setup Screen";
            // 
            // limitSetupToolStripMenuItem
            // 
            this.limitSetupToolStripMenuItem.Name = "limitSetupToolStripMenuItem";
            this.limitSetupToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.limitSetupToolStripMenuItem.Text = "Limit Setup";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.button12);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.checkBox3);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.button11);
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.TorqueManualUp);
            this.panel1.Controls.Add(this.SpeedManualUp);
            this.panel1.Controls.Add(this.TorqueManualDown);
            this.panel1.Controls.Add(this.FanSpeedManualUp);
            this.panel1.Controls.Add(this.SpeedManualDown);
            this.panel1.Controls.Add(this.FanSpeedManualDown);
            this.panel1.Controls.Add(this.PressureManualUp);
            this.panel1.Controls.Add(this.PressureManualDown);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.Torque);
            this.panel1.Controls.Add(this.speed);
            this.panel1.Controls.Add(this.FanBar);
            this.panel1.Controls.Add(this.Pressure);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.ConditionarManual);
            this.panel1.Controls.Add(this.StartFanManual);
            this.panel1.Controls.Add(this.LoadManual);
            this.panel1.Controls.Add(this.DownManual);
            this.panel1.Controls.Add(this.UnloadManual);
            this.panel1.Controls.Add(this.UpManual);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(12, 570);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 289);
            this.panel1.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(1234, 94);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(60, 20);
            this.textBox3.TabIndex = 16;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(1168, 226);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(126, 23);
            this.button12.TabIndex = 8;
            this.button12.Text = "Quick Test";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(1188, 180);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(60, 20);
            this.textBox4.TabIndex = 16;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1168, 94);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(60, 20);
            this.textBox2.TabIndex = 16;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(1168, 146);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(85, 17);
            this.checkBox3.TabIndex = 15;
            this.checkBox3.Text = "Data Saving";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(1168, 123);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(83, 17);
            this.checkBox2.TabIndex = 15;
            this.checkBox2.Text = "Hand Brake";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(926, 202);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(88, 17);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "Back Run(R)";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(926, 225);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 24);
            this.button11.TabIndex = 14;
            this.button11.Text = "Run";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(1019, 94);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(87, 40);
            this.button10.TabIndex = 13;
            this.button10.Text = "inertia Brake(N)";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(926, 94);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(87, 40);
            this.button9.TabIndex = 12;
            this.button9.Text = "Const Speed Brake(E)";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1167, 185);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(22, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "F : ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1167, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "StaticTorque";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(923, 186);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Direction";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(923, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Brake Mode";
            // 
            // TorqueManualUp
            // 
            this.TorqueManualUp.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Up;
            this.TorqueManualUp.Image = global::WindowsFormsApp1.Properties.Resources.Up1;
            this.TorqueManualUp.Location = new System.Drawing.Point(503, 186);
            this.TorqueManualUp.Name = "TorqueManualUp";
            this.TorqueManualUp.Size = new System.Drawing.Size(30, 20);
            this.TorqueManualUp.TabIndex = 9;
            this.TorqueManualUp.UseVisualStyleBackColor = true;
            this.TorqueManualUp.Click += new System.EventHandler(this.TorqueManualUp_Click);
            // 
            // SpeedManualUp
            // 
            this.SpeedManualUp.Image = global::WindowsFormsApp1.Properties.Resources.Up1;
            this.SpeedManualUp.Location = new System.Drawing.Point(692, 185);
            this.SpeedManualUp.Name = "SpeedManualUp";
            this.SpeedManualUp.Size = new System.Drawing.Size(30, 20);
            this.SpeedManualUp.TabIndex = 9;
            this.SpeedManualUp.UseVisualStyleBackColor = true;
            this.SpeedManualUp.Click += new System.EventHandler(this.SpeedManualUp_Click);
            // 
            // TorqueManualDown
            // 
            this.TorqueManualDown.Image = global::WindowsFormsApp1.Properties.Resources.Down21;
            this.TorqueManualDown.Location = new System.Drawing.Point(503, 205);
            this.TorqueManualDown.Name = "TorqueManualDown";
            this.TorqueManualDown.Size = new System.Drawing.Size(30, 20);
            this.TorqueManualDown.TabIndex = 8;
            this.TorqueManualDown.UseVisualStyleBackColor = true;
            this.TorqueManualDown.Click += new System.EventHandler(this.TorqueManualDown_Click);
            // 
            // FanSpeedManualUp
            // 
            this.FanSpeedManualUp.Image = global::WindowsFormsApp1.Properties.Resources.Up1;
            this.FanSpeedManualUp.Location = new System.Drawing.Point(693, 80);
            this.FanSpeedManualUp.Name = "FanSpeedManualUp";
            this.FanSpeedManualUp.Size = new System.Drawing.Size(30, 20);
            this.FanSpeedManualUp.TabIndex = 9;
            this.FanSpeedManualUp.UseVisualStyleBackColor = true;
            this.FanSpeedManualUp.Click += new System.EventHandler(this.FanSpeedManualUp_Click);
            // 
            // SpeedManualDown
            // 
            this.SpeedManualDown.Image = global::WindowsFormsApp1.Properties.Resources.Down21;
            this.SpeedManualDown.Location = new System.Drawing.Point(692, 204);
            this.SpeedManualDown.Name = "SpeedManualDown";
            this.SpeedManualDown.Size = new System.Drawing.Size(30, 20);
            this.SpeedManualDown.TabIndex = 8;
            this.SpeedManualDown.UseVisualStyleBackColor = true;
            this.SpeedManualDown.Click += new System.EventHandler(this.SpeedManualDown_Click);
            // 
            // FanSpeedManualDown
            // 
            this.FanSpeedManualDown.Image = global::WindowsFormsApp1.Properties.Resources.Down2;
            this.FanSpeedManualDown.Location = new System.Drawing.Point(693, 99);
            this.FanSpeedManualDown.Name = "FanSpeedManualDown";
            this.FanSpeedManualDown.Size = new System.Drawing.Size(30, 20);
            this.FanSpeedManualDown.TabIndex = 8;
            this.FanSpeedManualDown.UseVisualStyleBackColor = true;
            this.FanSpeedManualDown.Click += new System.EventHandler(this.FanSpeedManualDown_Click);
            // 
            // PressureManualUp
            // 
            this.PressureManualUp.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Up1;
            this.PressureManualUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PressureManualUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PressureManualUp.Location = new System.Drawing.Point(503, 78);
            this.PressureManualUp.Name = "PressureManualUp";
            this.PressureManualUp.Size = new System.Drawing.Size(30, 20);
            this.PressureManualUp.TabIndex = 9;
            this.PressureManualUp.UseVisualStyleBackColor = true;
            this.PressureManualUp.Click += new System.EventHandler(this.PressureManualUp_Click);
            // 
            // PressureManualDown
            // 
            this.PressureManualDown.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Down1;
            this.PressureManualDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PressureManualDown.Image = global::WindowsFormsApp1.Properties.Resources.Down21;
            this.PressureManualDown.Location = new System.Drawing.Point(503, 97);
            this.PressureManualDown.Name = "PressureManualDown";
            this.PressureManualDown.Size = new System.Drawing.Size(30, 20);
            this.PressureManualDown.TabIndex = 8;
            this.PressureManualDown.UseVisualStyleBackColor = true;
            this.PressureManualDown.Click += new System.EventHandler(this.PressureManualDown_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(726, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Speed[N/min]";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(536, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Torque[NM]";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(726, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Fan Speed[%]";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(536, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Pressure[MPa]";
            // 
            // Torque
            // 
            this.Torque.Location = new System.Drawing.Point(539, 196);
            this.Torque.Name = "Torque";
            this.Torque.Size = new System.Drawing.Size(140, 45);
            this.Torque.TabIndex = 9;
            this.Torque.ValueChanged += new System.EventHandler(this.Torque_ValueChanged);
            // 
            // speed
            // 
            this.speed.Location = new System.Drawing.Point(729, 196);
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(140, 45);
            this.speed.TabIndex = 9;
            this.speed.ValueChanged += new System.EventHandler(this.speed_ValueChanged);
            // 
            // FanBar
            // 
            this.FanBar.Location = new System.Drawing.Point(729, 89);
            this.FanBar.Maximum = 100;
            this.FanBar.Name = "FanBar";
            this.FanBar.Size = new System.Drawing.Size(140, 45);
            this.FanBar.TabIndex = 9;
            this.FanBar.ValueChanged += new System.EventHandler(this.FanBar_ValueChanged);
            // 
            // Pressure
            // 
            this.Pressure.Location = new System.Drawing.Point(539, 89);
            this.Pressure.Name = "Pressure";
            this.Pressure.Size = new System.Drawing.Size(140, 45);
            this.Pressure.TabIndex = 9;
            this.Pressure.ValueChanged += new System.EventHandler(this.Pressure_ValueChanged);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(375, 206);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 50);
            this.button8.TabIndex = 8;
            this.button8.Text = "Watering(W)";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // ConditionarManual
            // 
            this.ConditionarManual.Location = new System.Drawing.Point(294, 206);
            this.ConditionarManual.Name = "ConditionarManual";
            this.ConditionarManual.Size = new System.Drawing.Size(75, 50);
            this.ConditionarManual.TabIndex = 8;
            this.ConditionarManual.Text = "Conditioner";
            this.ConditionarManual.UseVisualStyleBackColor = true;
            // 
            // StartFanManual
            // 
            this.StartFanManual.Location = new System.Drawing.Point(213, 206);
            this.StartFanManual.Name = "StartFanManual";
            this.StartFanManual.Size = new System.Drawing.Size(75, 50);
            this.StartFanManual.TabIndex = 8;
            this.StartFanManual.Text = "Fan Start";
            this.StartFanManual.UseVisualStyleBackColor = true;
            // 
            // LoadManual
            // 
            this.LoadManual.Location = new System.Drawing.Point(294, 150);
            this.LoadManual.Name = "LoadManual";
            this.LoadManual.Size = new System.Drawing.Size(75, 23);
            this.LoadManual.TabIndex = 2;
            this.LoadManual.Text = "Load(L)";
            this.LoadManual.UseVisualStyleBackColor = true;
            // 
            // DownManual
            // 
            this.DownManual.Location = new System.Drawing.Point(294, 94);
            this.DownManual.Name = "DownManual";
            this.DownManual.Size = new System.Drawing.Size(75, 23);
            this.DownManual.TabIndex = 2;
            this.DownManual.Text = "Down(D)";
            this.DownManual.UseVisualStyleBackColor = true;
            // 
            // UnloadManual
            // 
            this.UnloadManual.Location = new System.Drawing.Point(213, 150);
            this.UnloadManual.Name = "UnloadManual";
            this.UnloadManual.Size = new System.Drawing.Size(75, 23);
            this.UnloadManual.TabIndex = 2;
            this.UnloadManual.Text = "Unload(U)";
            this.UnloadManual.UseVisualStyleBackColor = true;
            // 
            // UpManual
            // 
            this.UpManual.Location = new System.Drawing.Point(213, 94);
            this.UpManual.Name = "UpManual";
            this.UpManual.Size = new System.Drawing.Size(75, 23);
            this.UpManual.TabIndex = 2;
            this.UpManual.Text = "Up(I)";
            this.UpManual.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Static Torque";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Water  Tank";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(56, 206);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 50);
            this.button7.TabIndex = 0;
            this.button7.Text = "Constant Pressure";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(56, 150);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 50);
            this.button6.TabIndex = 0;
            this.button6.Text = "Unloading (X)";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(56, 94);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 50);
            this.button5.TabIndex = 0;
            this.button5.Text = "Hydraulic Station";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(56, 38);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 50);
            this.button4.TabIndex = 0;
            this.button4.Text = "Brake";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chart1);
            this.panel2.Controls.Add(this.richTextBox1);
            this.panel2.Location = new System.Drawing.Point(259, 384);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1413, 180);
            this.panel2.TabIndex = 8;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(536, 2);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(300, 171);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(2, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(528, 305);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.aGauge1);
            this.panel3.Controls.Add(this.aGauge2);
            this.panel3.Controls.Add(this.R0);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.pictureBox5);
            this.panel3.Controls.Add(this.EndButton);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.Back);
            this.panel3.Controls.Add(this.pictureBox9);
            this.panel3.Controls.Add(this.ConstP);
            this.panel3.Controls.Add(this.pictureBox6);
            this.panel3.Controls.Add(this.Down);
            this.panel3.Controls.Add(this.pictureBox7);
            this.panel3.Controls.Add(this.Up);
            this.panel3.Controls.Add(this.pictureBox10);
            this.panel3.Controls.Add(this.Watering);
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Controls.Add(this.LoadL);
            this.panel3.Controls.Add(this.pictureBox11);
            this.panel3.Controls.Add(this.Conditioner);
            this.panel3.Controls.Add(this.pictureBox8);
            this.panel3.Controls.Add(this.HandBrake);
            this.panel3.Controls.Add(this.pictureBox12);
            this.panel3.Controls.Add(this.Fan);
            this.panel3.Controls.Add(this.pictureBox13);
            this.panel3.Controls.Add(this.Brake);
            this.panel3.Controls.Add(this.Hydrau);
            this.panel3.Controls.Add(this.Unload);
            this.panel3.Controls.Add(this.Unloading);
            this.panel3.Location = new System.Drawing.Point(0, 27);
            this.panel3.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1250, 354);
            this.panel3.TabIndex = 9;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // aGauge1
            // 
            this.aGauge1.BaseArcColor = System.Drawing.Color.Gray;
            this.aGauge1.BaseArcRadius = 80;
            this.aGauge1.BaseArcStart = 180;
            this.aGauge1.BaseArcSweep = 180;
            this.aGauge1.BaseArcWidth = 2;
            this.aGauge1.GaugeAutoSize = false;
            this.aGauge1.Location = new System.Drawing.Point(0, 34);
            this.aGauge1.MaxValue = 2000F;
            this.aGauge1.MinValue = 0F;
            this.aGauge1.Name = "aGauge1";
            this.aGauge1.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Gray;
            this.aGauge1.NeedleColor2 = System.Drawing.Color.DimGray;
            this.aGauge1.NeedleRadius = 80;
            this.aGauge1.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.aGauge1.NeedleWidth = 2;
            this.aGauge1.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGauge1.ScaleLinesInterInnerRadius = 73;
            this.aGauge1.ScaleLinesInterOuterRadius = 80;
            this.aGauge1.ScaleLinesInterWidth = 1;
            this.aGauge1.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGauge1.ScaleLinesMajorInnerRadius = 70;
            this.aGauge1.ScaleLinesMajorOuterRadius = 80;
            this.aGauge1.ScaleLinesMajorStepValue = 500F;
            this.aGauge1.ScaleLinesMajorWidth = 2;
            this.aGauge1.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.aGauge1.ScaleLinesMinorInnerRadius = 75;
            this.aGauge1.ScaleLinesMinorOuterRadius = 80;
            this.aGauge1.ScaleLinesMinorTicks = 9;
            this.aGauge1.ScaleLinesMinorWidth = 1;
            this.aGauge1.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge1.ScaleNumbersFormat = null;
            this.aGauge1.ScaleNumbersRadius = 95;
            this.aGauge1.ScaleNumbersRotation = 0;
            this.aGauge1.ScaleNumbersStartScaleLine = 0;
            this.aGauge1.ScaleNumbersStepScaleLines = 1;
            this.aGauge1.Size = new System.Drawing.Size(208, 106);
            this.aGauge1.TabIndex = 0;
            this.aGauge1.Text = "aGauge1";
            this.aGauge1.Value = 0F;
            // 
            // aGauge2
            // 
            this.aGauge2.BaseArcColor = System.Drawing.Color.Gray;
            this.aGauge2.BaseArcRadius = 80;
            this.aGauge2.BaseArcStart = 180;
            this.aGauge2.BaseArcSweep = 180;
            this.aGauge2.BaseArcWidth = 2;
            this.aGauge2.GaugeAutoSize = false;
            this.aGauge2.Location = new System.Drawing.Point(0, 186);
            this.aGauge2.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.aGauge2.MaxValue = 160F;
            this.aGauge2.MinValue = 0F;
            this.aGauge2.Name = "aGauge2";
            this.aGauge2.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Gray;
            this.aGauge2.NeedleColor2 = System.Drawing.Color.DimGray;
            this.aGauge2.NeedleRadius = 80;
            this.aGauge2.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.aGauge2.NeedleWidth = 2;
            this.aGauge2.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGauge2.ScaleLinesInterInnerRadius = 73;
            this.aGauge2.ScaleLinesInterOuterRadius = 80;
            this.aGauge2.ScaleLinesInterWidth = 1;
            this.aGauge2.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGauge2.ScaleLinesMajorInnerRadius = 70;
            this.aGauge2.ScaleLinesMajorOuterRadius = 80;
            this.aGauge2.ScaleLinesMajorStepValue = 40F;
            this.aGauge2.ScaleLinesMajorWidth = 2;
            this.aGauge2.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.aGauge2.ScaleLinesMinorInnerRadius = 75;
            this.aGauge2.ScaleLinesMinorOuterRadius = 80;
            this.aGauge2.ScaleLinesMinorTicks = 9;
            this.aGauge2.ScaleLinesMinorWidth = 1;
            this.aGauge2.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge2.ScaleNumbersFormat = null;
            this.aGauge2.ScaleNumbersRadius = 95;
            this.aGauge2.ScaleNumbersRotation = 0;
            this.aGauge2.ScaleNumbersStartScaleLine = 0;
            this.aGauge2.ScaleNumbersStepScaleLines = 1;
            this.aGauge2.Size = new System.Drawing.Size(208, 127);
            this.aGauge2.TabIndex = 0;
            this.aGauge2.Text = "aGauge1";
            this.aGauge2.Value = 0F;
            // 
            // R0
            // 
            this.R0.Location = new System.Drawing.Point(252, 313);
            this.R0.Name = "R0";
            this.R0.Size = new System.Drawing.Size(74, 20);
            this.R0.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "RPM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(216, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "R0 : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "SPEED";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.RedLight_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(215, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(1090, 34);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 30);
            this.button2.TabIndex = 4;
            this.button2.Text = "Pause";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.RedLight_removebg_preview;
            this.pictureBox2.Location = new System.Drawing.Point(281, 34);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Location = new System.Drawing.Point(1090, 70);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 35);
            this.button3.TabIndex = 4;
            this.button3.Text = "Stop";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::WindowsFormsApp1.Properties.Resources.RedLight_removebg_preview;
            this.pictureBox5.Location = new System.Drawing.Point(473, 34);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(50, 50);
            this.pictureBox5.TabIndex = 2;
            this.pictureBox5.TabStop = false;
            // 
            // EndButton
            // 
            this.EndButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EndButton.Location = new System.Drawing.Point(1171, 34);
            this.EndButton.Name = "EndButton";
            this.EndButton.Size = new System.Drawing.Size(75, 30);
            this.EndButton.TabIndex = 4;
            this.EndButton.Text = "End";
            this.EndButton.UseVisualStyleBackColor = true;
            this.EndButton.Click += new System.EventHandler(this.End_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsApp1.Properties.Resources.RedLight_removebg_preview;
            this.pictureBox3.Location = new System.Drawing.Point(347, 33);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // Back
            // 
            this.Back.AutoSize = true;
            this.Back.Location = new System.Drawing.Point(1003, 88);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(32, 13);
            this.Back.TabIndex = 3;
            this.Back.Text = "Back";
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::WindowsFormsApp1.Properties.Resources.RedLight_removebg_preview;
            this.pictureBox9.Location = new System.Drawing.Point(800, 34);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(50, 50);
            this.pictureBox9.TabIndex = 2;
            this.pictureBox9.TabStop = false;
            // 
            // ConstP
            // 
            this.ConstP.AutoSize = true;
            this.ConstP.Location = new System.Drawing.Point(934, 88);
            this.ConstP.Name = "ConstP";
            this.ConstP.Size = new System.Drawing.Size(41, 13);
            this.ConstP.TabIndex = 3;
            this.ConstP.Text = "ConstP";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::WindowsFormsApp1.Properties.Resources.RedLight_removebg_preview;
            this.pictureBox6.Location = new System.Drawing.Point(538, 34);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(50, 50);
            this.pictureBox6.TabIndex = 2;
            this.pictureBox6.TabStop = false;
            // 
            // Down
            // 
            this.Down.AutoSize = true;
            this.Down.Location = new System.Drawing.Point(810, 88);
            this.Down.Name = "Down";
            this.Down.Size = new System.Drawing.Size(33, 13);
            this.Down.TabIndex = 3;
            this.Down.Text = "down";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::WindowsFormsApp1.Properties.Resources.RedLight_removebg_preview;
            this.pictureBox7.Location = new System.Drawing.Point(603, 34);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(50, 50);
            this.pictureBox7.TabIndex = 2;
            this.pictureBox7.TabStop = false;
            // 
            // Up
            // 
            this.Up.AutoSize = true;
            this.Up.Location = new System.Drawing.Point(748, 88);
            this.Up.Name = "Up";
            this.Up.Size = new System.Drawing.Size(21, 13);
            this.Up.TabIndex = 3;
            this.Up.Text = "Up";
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::WindowsFormsApp1.Properties.Resources.RedLight_removebg_preview;
            this.pictureBox10.Location = new System.Drawing.Point(864, 34);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(50, 50);
            this.pictureBox10.TabIndex = 2;
            this.pictureBox10.TabStop = false;
            // 
            // Watering
            // 
            this.Watering.AutoSize = true;
            this.Watering.Location = new System.Drawing.Point(866, 88);
            this.Watering.Name = "Watering";
            this.Watering.Size = new System.Drawing.Size(50, 13);
            this.Watering.TabIndex = 3;
            this.Watering.Text = "Watering";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WindowsFormsApp1.Properties.Resources.RedLight_removebg_preview;
            this.pictureBox4.Location = new System.Drawing.Point(409, 34);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(50, 50);
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // LoadL
            // 
            this.LoadL.AutoSize = true;
            this.LoadL.Location = new System.Drawing.Point(484, 88);
            this.LoadL.Name = "LoadL";
            this.LoadL.Size = new System.Drawing.Size(31, 13);
            this.LoadL.TabIndex = 3;
            this.LoadL.Text = "Load";
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::WindowsFormsApp1.Properties.Resources.RedLight_removebg_preview;
            this.pictureBox11.Location = new System.Drawing.Point(928, 34);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(50, 50);
            this.pictureBox11.TabIndex = 2;
            this.pictureBox11.TabStop = false;
            // 
            // Conditioner
            // 
            this.Conditioner.AutoSize = true;
            this.Conditioner.Location = new System.Drawing.Point(664, 87);
            this.Conditioner.Name = "Conditioner";
            this.Conditioner.Size = new System.Drawing.Size(60, 13);
            this.Conditioner.TabIndex = 3;
            this.Conditioner.Text = "Conditioner";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::WindowsFormsApp1.Properties.Resources.RedLight_removebg_preview;
            this.pictureBox8.Location = new System.Drawing.Point(667, 33);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(50, 50);
            this.pictureBox8.TabIndex = 2;
            this.pictureBox8.TabStop = false;
            // 
            // HandBrake
            // 
            this.HandBrake.AutoSize = true;
            this.HandBrake.Location = new System.Drawing.Point(404, 88);
            this.HandBrake.Name = "HandBrake";
            this.HandBrake.Size = new System.Drawing.Size(64, 13);
            this.HandBrake.TabIndex = 3;
            this.HandBrake.Text = "Hand Brake";
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = global::WindowsFormsApp1.Properties.Resources.RedLight_removebg_preview;
            this.pictureBox12.Location = new System.Drawing.Point(733, 34);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(50, 50);
            this.pictureBox12.TabIndex = 2;
            this.pictureBox12.TabStop = false;
            // 
            // Fan
            // 
            this.Fan.AutoSize = true;
            this.Fan.Location = new System.Drawing.Point(617, 86);
            this.Fan.Name = "Fan";
            this.Fan.Size = new System.Drawing.Size(25, 13);
            this.Fan.TabIndex = 3;
            this.Fan.Text = "Fan";
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = global::WindowsFormsApp1.Properties.Resources.RedLight_removebg_preview;
            this.pictureBox13.Location = new System.Drawing.Point(992, 34);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(50, 50);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox13.TabIndex = 2;
            this.pictureBox13.TabStop = false;
            this.pictureBox13.Click += new System.EventHandler(this.pictureBox13_Click);
            // 
            // Brake
            // 
            this.Brake.AutoSize = true;
            this.Brake.Location = new System.Drawing.Point(356, 88);
            this.Brake.Name = "Brake";
            this.Brake.Size = new System.Drawing.Size(35, 13);
            this.Brake.TabIndex = 3;
            this.Brake.Text = "Brake";
            // 
            // Hydrau
            // 
            this.Hydrau.AutoSize = true;
            this.Hydrau.Location = new System.Drawing.Point(221, 87);
            this.Hydrau.Name = "Hydrau";
            this.Hydrau.Size = new System.Drawing.Size(41, 13);
            this.Hydrau.TabIndex = 3;
            this.Hydrau.Text = "Hydrau";
            this.Hydrau.Click += new System.EventHandler(this.Hydrau_Click);
            // 
            // Unload
            // 
            this.Unload.AutoSize = true;
            this.Unload.Location = new System.Drawing.Point(545, 86);
            this.Unload.Name = "Unload";
            this.Unload.Size = new System.Drawing.Size(41, 13);
            this.Unload.TabIndex = 3;
            this.Unload.Text = "Unload";
            // 
            // Unloading
            // 
            this.Unloading.AutoSize = true;
            this.Unloading.Location = new System.Drawing.Point(280, 88);
            this.Unloading.Name = "Unloading";
            this.Unloading.Size = new System.Drawing.Size(55, 13);
            this.Unloading.TabIndex = 3;
            this.Unloading.Text = "Unloading";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Torque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FanBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pressure)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button LoadManual;
        private System.Windows.Forms.Button DownManual;
        private System.Windows.Forms.Button UnloadManual;
        private System.Windows.Forms.Button UpManual;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button StartFanManual;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button ConditionarManual;
        private System.Windows.Forms.TrackBar Pressure;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar Torque;
        private System.Windows.Forms.TrackBar FanBar;
        private System.Windows.Forms.Button TorqueManualUp;
        private System.Windows.Forms.Button SpeedManualUp;
        private System.Windows.Forms.Button TorqueManualDown;
        private System.Windows.Forms.Button FanSpeedManualUp;
        private System.Windows.Forms.Button SpeedManualDown;
        private System.Windows.Forms.Button FanSpeedManualDown;
        private System.Windows.Forms.Button PressureManualUp;
        private System.Windows.Forms.Button PressureManualDown;
        private System.Windows.Forms.TrackBar speed;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private ToolStripMenuItem manualToolStripMenuItem;
        private ToolStripMenuItem automaticToolStripMenuItem;
        private Button button12;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private ToolStripMenuItem inputSettingToolStripMenuItem;
        private ToolStripMenuItem limitSetupToolStripMenuItem;
        private Panel panel3;
        private AGauge aGauge1;
        private AGauge aGauge2;
        private TextBox R0;
        private Label label1;
        private Label label5;
        private Label label2;
        private PictureBox pictureBox1;
        private Button button2;
        private PictureBox pictureBox2;
        private Button button3;
        private PictureBox pictureBox5;
        private Button EndButton;
        private PictureBox pictureBox3;
        private Label Back;
        private PictureBox pictureBox9;
        private Label ConstP;
        private PictureBox pictureBox6;
        private Label Down;
        private PictureBox pictureBox7;
        private Label Up;
        private PictureBox pictureBox10;
        private Label Watering;
        private PictureBox pictureBox4;
        private Label LoadL;
        private PictureBox pictureBox11;
        private Label Conditioner;
        private PictureBox pictureBox8;
        private Label HandBrake;
        private PictureBox pictureBox12;
        private Label Fan;
        private PictureBox pictureBox13;
        private Label Brake;
        private Label Hydrau;
        private Label Unload;
        private Label Unloading;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem reportToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem1;
    }
}

