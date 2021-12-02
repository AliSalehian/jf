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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Hydrau = new System.Windows.Forms.Label();
            this.Unloading = new System.Windows.Forms.Label();
            this.Brake = new System.Windows.Forms.Label();
            this.HandBrake = new System.Windows.Forms.Label();
            this.LoadL = new System.Windows.Forms.Label();
            this.Unload = new System.Windows.Forms.Label();
            this.Fan = new System.Windows.Forms.Label();
            this.Conditioner = new System.Windows.Forms.Label();
            this.Up = new System.Windows.Forms.Label();
            this.Down = new System.Windows.Forms.Label();
            this.Watering = new System.Windows.Forms.Label();
            this.ConstP = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Label();
            this.EndButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.automaticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.aGauge2 = new System.Windows.Forms.AGauge();
            this.aGauge1 = new System.Windows.Forms.AGauge();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Torque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FanBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pressure)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 206);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "RPM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 417);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "SPEED";
            // 
            // Hydrau
            // 
            this.Hydrau.AutoSize = true;
            this.Hydrau.Location = new System.Drawing.Point(460, 135);
            this.Hydrau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Hydrau.Name = "Hydrau";
            this.Hydrau.Size = new System.Drawing.Size(51, 16);
            this.Hydrau.TabIndex = 3;
            this.Hydrau.Text = "Hydrau";
            // 
            // Unloading
            // 
            this.Unloading.AutoSize = true;
            this.Unloading.Location = new System.Drawing.Point(535, 135);
            this.Unloading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Unloading.Name = "Unloading";
            this.Unloading.Size = new System.Drawing.Size(69, 16);
            this.Unloading.TabIndex = 3;
            this.Unloading.Text = "Unloading";
            // 
            // Brake
            // 
            this.Brake.AutoSize = true;
            this.Brake.Location = new System.Drawing.Point(609, 135);
            this.Brake.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Brake.Name = "Brake";
            this.Brake.Size = new System.Drawing.Size(43, 16);
            this.Brake.TabIndex = 3;
            this.Brake.Text = "Brake";
            // 
            // HandBrake
            // 
            this.HandBrake.AutoSize = true;
            this.HandBrake.Location = new System.Drawing.Point(684, 135);
            this.HandBrake.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HandBrake.Name = "HandBrake";
            this.HandBrake.Size = new System.Drawing.Size(79, 16);
            this.HandBrake.TabIndex = 3;
            this.HandBrake.Text = "Hand Brake";
            // 
            // LoadL
            // 
            this.LoadL.AutoSize = true;
            this.LoadL.Location = new System.Drawing.Point(759, 135);
            this.LoadL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LoadL.Name = "LoadL";
            this.LoadL.Size = new System.Drawing.Size(38, 16);
            this.LoadL.TabIndex = 3;
            this.LoadL.Text = "Load";
            // 
            // Unload
            // 
            this.Unload.AutoSize = true;
            this.Unload.Location = new System.Drawing.Point(833, 135);
            this.Unload.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Unload.Name = "Unload";
            this.Unload.Size = new System.Drawing.Size(51, 16);
            this.Unload.TabIndex = 3;
            this.Unload.Text = "Unload";
            // 
            // Fan
            // 
            this.Fan.AutoSize = true;
            this.Fan.Location = new System.Drawing.Point(932, 135);
            this.Fan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Fan.Name = "Fan";
            this.Fan.Size = new System.Drawing.Size(30, 16);
            this.Fan.TabIndex = 3;
            this.Fan.Text = "Fan";
            // 
            // Conditioner
            // 
            this.Conditioner.AutoSize = true;
            this.Conditioner.Location = new System.Drawing.Point(1007, 135);
            this.Conditioner.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Conditioner.Name = "Conditioner";
            this.Conditioner.Size = new System.Drawing.Size(75, 16);
            this.Conditioner.TabIndex = 3;
            this.Conditioner.Text = "Conditioner";
            // 
            // Up
            // 
            this.Up.AutoSize = true;
            this.Up.Location = new System.Drawing.Point(1081, 135);
            this.Up.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Up.Name = "Up";
            this.Up.Size = new System.Drawing.Size(25, 16);
            this.Up.TabIndex = 3;
            this.Up.Text = "Up";
            // 
            // Down
            // 
            this.Down.AutoSize = true;
            this.Down.Location = new System.Drawing.Point(1156, 135);
            this.Down.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Down.Name = "Down";
            this.Down.Size = new System.Drawing.Size(39, 16);
            this.Down.TabIndex = 3;
            this.Down.Text = "down";
            // 
            // Watering
            // 
            this.Watering.AutoSize = true;
            this.Watering.Location = new System.Drawing.Point(1231, 135);
            this.Watering.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Watering.Name = "Watering";
            this.Watering.Size = new System.Drawing.Size(61, 16);
            this.Watering.TabIndex = 3;
            this.Watering.Text = "Watering";
            // 
            // ConstP
            // 
            this.ConstP.AutoSize = true;
            this.ConstP.Location = new System.Drawing.Point(1305, 135);
            this.ConstP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ConstP.Name = "ConstP";
            this.ConstP.Size = new System.Drawing.Size(50, 16);
            this.ConstP.TabIndex = 3;
            this.ConstP.Text = "ConstP";
            // 
            // Back
            // 
            this.Back.AutoSize = true;
            this.Back.Location = new System.Drawing.Point(1380, 135);
            this.Back.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(38, 16);
            this.Back.TabIndex = 3;
            this.Back.Text = "Back";
            // 
            // EndButton
            // 
            this.EndButton.Location = new System.Drawing.Point(1641, 70);
            this.EndButton.Margin = new System.Windows.Forms.Padding(4);
            this.EndButton.Name = "EndButton";
            this.EndButton.Size = new System.Drawing.Size(100, 37);
            this.EndButton.TabIndex = 4;
            this.EndButton.Text = "End";
            this.EndButton.UseVisualStyleBackColor = true;
            this.EndButton.Click += new System.EventHandler(this.End_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1533, 70);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 37);
            this.button2.TabIndex = 4;
            this.button2.Text = "Pause";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1533, 114);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(208, 43);
            this.button3.TabIndex = 4;
            this.button3.Text = "Stop";
            this.button3.UseVisualStyleBackColor = true;
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
            this.menuStrip1.Size = new System.Drawing.Size(1827, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualToolStripMenuItem,
            this.automaticToolStripMenuItem});
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.testToolStripMenuItem.Text = "Test";
            // 
            // manualToolStripMenuItem
            // 
            this.manualToolStripMenuItem.Name = "manualToolStripMenuItem";
            this.manualToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.manualToolStripMenuItem.Text = "Manual";
            this.manualToolStripMenuItem.Click += new System.EventHandler(this.manualToolStripMenuItem_Click);
            // 
            // automaticToolStripMenuItem
            // 
            this.automaticToolStripMenuItem.Name = "automaticToolStripMenuItem";
            this.automaticToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.automaticToolStripMenuItem.Text = "Automatic";
            this.automaticToolStripMenuItem.Click += new System.EventHandler(this.automaticToolStripMenuItem_Click);
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.settingToolStripMenuItem.Text = "Setting";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(368, 417);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "R0 : ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(416, 414);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(97, 22);
            this.textBox1.TabIndex = 7;
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
            this.panel1.Location = new System.Drawing.Point(0, 458);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1827, 356);
            this.panel1.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(1645, 116);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(79, 22);
            this.textBox3.TabIndex = 16;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(1557, 278);
            this.button12.Margin = new System.Windows.Forms.Padding(4);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(168, 28);
            this.button12.TabIndex = 8;
            this.button12.Text = "Quick Test";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(1584, 222);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(79, 22);
            this.textBox4.TabIndex = 16;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1557, 116);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(79, 22);
            this.textBox2.TabIndex = 16;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(1557, 180);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(103, 20);
            this.checkBox3.TabIndex = 15;
            this.checkBox3.Text = "Data Saving";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(1557, 151);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(101, 20);
            this.checkBox2.TabIndex = 15;
            this.checkBox2.Text = "Hand Brake";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(1235, 249);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(105, 20);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "Back Run(R)";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(1235, 277);
            this.button11.Margin = new System.Windows.Forms.Padding(4);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(100, 30);
            this.button11.TabIndex = 14;
            this.button11.Text = "Run";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(1359, 116);
            this.button10.Margin = new System.Windows.Forms.Padding(4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(116, 49);
            this.button10.TabIndex = 13;
            this.button10.Text = "inertia Brake(N)";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(1235, 116);
            this.button9.Margin = new System.Windows.Forms.Padding(4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(116, 49);
            this.button9.TabIndex = 12;
            this.button9.Text = "Const Speed Brake(E)";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1556, 228);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(24, 16);
            this.label13.TabIndex = 11;
            this.label13.Text = "F : ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1556, 96);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 16);
            this.label12.TabIndex = 11;
            this.label12.Text = "StaticTorque";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1231, 229);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 16);
            this.label11.TabIndex = 11;
            this.label11.Text = "Direction";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1231, 96);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 16);
            this.label10.TabIndex = 11;
            this.label10.Text = "Brake Mode";
            // 
            // TorqueManualUp
            // 
            this.TorqueManualUp.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Up;
            this.TorqueManualUp.Image = global::WindowsFormsApp1.Properties.Resources.Up1;
            this.TorqueManualUp.Location = new System.Drawing.Point(671, 229);
            this.TorqueManualUp.Margin = new System.Windows.Forms.Padding(4);
            this.TorqueManualUp.Name = "TorqueManualUp";
            this.TorqueManualUp.Size = new System.Drawing.Size(40, 25);
            this.TorqueManualUp.TabIndex = 9;
            this.TorqueManualUp.UseVisualStyleBackColor = true;
            this.TorqueManualUp.Click += new System.EventHandler(this.TorqueManualUp_Click);
            // 
            // SpeedManualUp
            // 
            this.SpeedManualUp.Image = global::WindowsFormsApp1.Properties.Resources.Up1;
            this.SpeedManualUp.Location = new System.Drawing.Point(923, 228);
            this.SpeedManualUp.Margin = new System.Windows.Forms.Padding(4);
            this.SpeedManualUp.Name = "SpeedManualUp";
            this.SpeedManualUp.Size = new System.Drawing.Size(40, 25);
            this.SpeedManualUp.TabIndex = 9;
            this.SpeedManualUp.UseVisualStyleBackColor = true;
            this.SpeedManualUp.Click += new System.EventHandler(this.SpeedManualUp_Click);
            // 
            // TorqueManualDown
            // 
            this.TorqueManualDown.Image = global::WindowsFormsApp1.Properties.Resources.Down21;
            this.TorqueManualDown.Location = new System.Drawing.Point(671, 252);
            this.TorqueManualDown.Margin = new System.Windows.Forms.Padding(4);
            this.TorqueManualDown.Name = "TorqueManualDown";
            this.TorqueManualDown.Size = new System.Drawing.Size(40, 25);
            this.TorqueManualDown.TabIndex = 8;
            this.TorqueManualDown.UseVisualStyleBackColor = true;
            this.TorqueManualDown.Click += new System.EventHandler(this.TorqueManualDown_Click);
            // 
            // FanSpeedManualUp
            // 
            this.FanSpeedManualUp.Image = global::WindowsFormsApp1.Properties.Resources.Up1;
            this.FanSpeedManualUp.Location = new System.Drawing.Point(924, 98);
            this.FanSpeedManualUp.Margin = new System.Windows.Forms.Padding(4);
            this.FanSpeedManualUp.Name = "FanSpeedManualUp";
            this.FanSpeedManualUp.Size = new System.Drawing.Size(40, 25);
            this.FanSpeedManualUp.TabIndex = 9;
            this.FanSpeedManualUp.UseVisualStyleBackColor = true;
            this.FanSpeedManualUp.Click += new System.EventHandler(this.FanSpeedManualUp_Click);
            // 
            // SpeedManualDown
            // 
            this.SpeedManualDown.Image = global::WindowsFormsApp1.Properties.Resources.Down21;
            this.SpeedManualDown.Location = new System.Drawing.Point(923, 251);
            this.SpeedManualDown.Margin = new System.Windows.Forms.Padding(4);
            this.SpeedManualDown.Name = "SpeedManualDown";
            this.SpeedManualDown.Size = new System.Drawing.Size(40, 25);
            this.SpeedManualDown.TabIndex = 8;
            this.SpeedManualDown.UseVisualStyleBackColor = true;
            this.SpeedManualDown.Click += new System.EventHandler(this.SpeedManualDown_Click);
            // 
            // FanSpeedManualDown
            // 
            this.FanSpeedManualDown.Image = global::WindowsFormsApp1.Properties.Resources.Down2;
            this.FanSpeedManualDown.Location = new System.Drawing.Point(924, 122);
            this.FanSpeedManualDown.Margin = new System.Windows.Forms.Padding(4);
            this.FanSpeedManualDown.Name = "FanSpeedManualDown";
            this.FanSpeedManualDown.Size = new System.Drawing.Size(40, 25);
            this.FanSpeedManualDown.TabIndex = 8;
            this.FanSpeedManualDown.UseVisualStyleBackColor = true;
            this.FanSpeedManualDown.Click += new System.EventHandler(this.FanSpeedManualDown_Click);
            // 
            // PressureManualUp
            // 
            this.PressureManualUp.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Up1;
            this.PressureManualUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PressureManualUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PressureManualUp.Location = new System.Drawing.Point(671, 96);
            this.PressureManualUp.Margin = new System.Windows.Forms.Padding(4);
            this.PressureManualUp.Name = "PressureManualUp";
            this.PressureManualUp.Size = new System.Drawing.Size(40, 25);
            this.PressureManualUp.TabIndex = 9;
            this.PressureManualUp.UseVisualStyleBackColor = true;
            this.PressureManualUp.Click += new System.EventHandler(this.PressureManualUp_Click);
            // 
            // PressureManualDown
            // 
            this.PressureManualDown.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Down1;
            this.PressureManualDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PressureManualDown.Image = global::WindowsFormsApp1.Properties.Resources.Down21;
            this.PressureManualDown.Location = new System.Drawing.Point(671, 119);
            this.PressureManualDown.Margin = new System.Windows.Forms.Padding(4);
            this.PressureManualDown.Name = "PressureManualDown";
            this.PressureManualDown.Size = new System.Drawing.Size(40, 25);
            this.PressureManualDown.TabIndex = 8;
            this.PressureManualDown.UseVisualStyleBackColor = true;
            this.PressureManualDown.Click += new System.EventHandler(this.PressureManualDown_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(968, 278);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Speed[N/min]";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(715, 278);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Torque[NM]";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(968, 149);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "Fan Speed[%]";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(715, 149);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Pressure[MPa]";
            // 
            // Torque
            // 
            this.Torque.Location = new System.Drawing.Point(719, 241);
            this.Torque.Margin = new System.Windows.Forms.Padding(4);
            this.Torque.Name = "Torque";
            this.Torque.Size = new System.Drawing.Size(187, 56);
            this.Torque.TabIndex = 9;
            this.Torque.ValueChanged += new System.EventHandler(this.Torque_ValueChanged);
            // 
            // speed
            // 
            this.speed.Location = new System.Drawing.Point(972, 241);
            this.speed.Margin = new System.Windows.Forms.Padding(4);
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(187, 56);
            this.speed.TabIndex = 9;
            this.speed.ValueChanged += new System.EventHandler(this.speed_ValueChanged);
            // 
            // FanBar
            // 
            this.FanBar.Location = new System.Drawing.Point(972, 110);
            this.FanBar.Margin = new System.Windows.Forms.Padding(4);
            this.FanBar.Maximum = 100;
            this.FanBar.Name = "FanBar";
            this.FanBar.Size = new System.Drawing.Size(187, 56);
            this.FanBar.TabIndex = 9;
            this.FanBar.ValueChanged += new System.EventHandler(this.FanBar_ValueChanged);
            // 
            // Pressure
            // 
            this.Pressure.Location = new System.Drawing.Point(719, 110);
            this.Pressure.Margin = new System.Windows.Forms.Padding(4);
            this.Pressure.Name = "Pressure";
            this.Pressure.Size = new System.Drawing.Size(187, 56);
            this.Pressure.TabIndex = 9;
            this.Pressure.ValueChanged += new System.EventHandler(this.Pressure_ValueChanged);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(500, 254);
            this.button8.Margin = new System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(100, 62);
            this.button8.TabIndex = 8;
            this.button8.Text = "Watering(W)";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // ConditionarManual
            // 
            this.ConditionarManual.Location = new System.Drawing.Point(392, 254);
            this.ConditionarManual.Margin = new System.Windows.Forms.Padding(4);
            this.ConditionarManual.Name = "ConditionarManual";
            this.ConditionarManual.Size = new System.Drawing.Size(100, 62);
            this.ConditionarManual.TabIndex = 8;
            this.ConditionarManual.Text = "Conditioner";
            this.ConditionarManual.UseVisualStyleBackColor = true;
            // 
            // StartFanManual
            // 
            this.StartFanManual.Location = new System.Drawing.Point(284, 254);
            this.StartFanManual.Margin = new System.Windows.Forms.Padding(4);
            this.StartFanManual.Name = "StartFanManual";
            this.StartFanManual.Size = new System.Drawing.Size(100, 62);
            this.StartFanManual.TabIndex = 8;
            this.StartFanManual.Text = "Fan Start";
            this.StartFanManual.UseVisualStyleBackColor = true;
            // 
            // LoadManual
            // 
            this.LoadManual.Location = new System.Drawing.Point(392, 185);
            this.LoadManual.Margin = new System.Windows.Forms.Padding(4);
            this.LoadManual.Name = "LoadManual";
            this.LoadManual.Size = new System.Drawing.Size(100, 28);
            this.LoadManual.TabIndex = 2;
            this.LoadManual.Text = "Load(L)";
            this.LoadManual.UseVisualStyleBackColor = true;
            // 
            // DownManual
            // 
            this.DownManual.Location = new System.Drawing.Point(392, 116);
            this.DownManual.Margin = new System.Windows.Forms.Padding(4);
            this.DownManual.Name = "DownManual";
            this.DownManual.Size = new System.Drawing.Size(100, 28);
            this.DownManual.TabIndex = 2;
            this.DownManual.Text = "Down(D)";
            this.DownManual.UseVisualStyleBackColor = true;
            // 
            // UnloadManual
            // 
            this.UnloadManual.Location = new System.Drawing.Point(284, 185);
            this.UnloadManual.Margin = new System.Windows.Forms.Padding(4);
            this.UnloadManual.Name = "UnloadManual";
            this.UnloadManual.Size = new System.Drawing.Size(100, 28);
            this.UnloadManual.TabIndex = 2;
            this.UnloadManual.Text = "Unload(U)";
            this.UnloadManual.UseVisualStyleBackColor = true;
            // 
            // UpManual
            // 
            this.UpManual.Location = new System.Drawing.Point(284, 116);
            this.UpManual.Margin = new System.Windows.Forms.Padding(4);
            this.UpManual.Name = "UpManual";
            this.UpManual.Size = new System.Drawing.Size(100, 28);
            this.UpManual.TabIndex = 2;
            this.UpManual.Text = "Up(I)";
            this.UpManual.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(281, 165);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Static Torque";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 92);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Water  Tank";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(75, 254);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(133, 62);
            this.button7.TabIndex = 0;
            this.button7.Text = "Constant Pressure";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(75, 185);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(133, 62);
            this.button6.TabIndex = 0;
            this.button6.Text = "Unloading (X)";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(75, 116);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(133, 62);
            this.button5.TabIndex = 0;
            this.button5.Text = "Hydraulic Station";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(75, 47);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(133, 62);
            this.button4.TabIndex = 0;
            this.button4.Text = "Brake";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chart1);
            this.panel2.Controls.Add(this.richTextBox1);
            this.panel2.Location = new System.Drawing.Point(1200, 455);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1884, 222);
            this.panel2.TabIndex = 8;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(715, 2);
            this.chart1.Margin = new System.Windows.Forms.Padding(4);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(400, 210);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(3, 2);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(703, 374);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = global::WindowsFormsApp1.Properties.Resources.RedLight;
            this.pictureBox13.Location = new System.Drawing.Point(1360, 70);
            this.pictureBox13.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(67, 62);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox13.TabIndex = 2;
            this.pictureBox13.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Location = new System.Drawing.Point(1061, 70);
            this.pictureBox12.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(67, 62);
            this.pictureBox12.TabIndex = 2;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Location = new System.Drawing.Point(987, 70);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(67, 62);
            this.pictureBox8.TabIndex = 2;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Location = new System.Drawing.Point(1285, 70);
            this.pictureBox11.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(67, 62);
            this.pictureBox11.TabIndex = 2;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(688, 70);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(67, 62);
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Location = new System.Drawing.Point(1211, 70);
            this.pictureBox10.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(67, 62);
            this.pictureBox10.TabIndex = 2;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Location = new System.Drawing.Point(912, 70);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(67, 62);
            this.pictureBox7.TabIndex = 2;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(837, 70);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(67, 62);
            this.pictureBox6.TabIndex = 2;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Location = new System.Drawing.Point(1136, 70);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(67, 62);
            this.pictureBox9.TabIndex = 2;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(613, 70);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(67, 62);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(763, 70);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(67, 62);
            this.pictureBox5.TabIndex = 2;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(539, 70);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(67, 62);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.RedLight;
            this.pictureBox1.Location = new System.Drawing.Point(464, 70);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 62);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // aGauge2
            // 
            this.aGauge2.BaseArcColor = System.Drawing.Color.Gray;
            this.aGauge2.BaseArcRadius = 80;
            this.aGauge2.BaseArcStart = 180;
            this.aGauge2.BaseArcSweep = 180;
            this.aGauge2.BaseArcWidth = 2;
            this.aGauge2.GaugeAutoSize = false;
            this.aGauge2.Location = new System.Drawing.Point(75, 257);
            this.aGauge2.Margin = new System.Windows.Forms.Padding(4);
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
            this.aGauge2.Size = new System.Drawing.Size(273, 156);
            this.aGauge2.TabIndex = 0;
            this.aGauge2.Text = "aGauge1";
            this.aGauge2.Value = 0F;
            // 
            // aGauge1
            // 
            this.aGauge1.BaseArcColor = System.Drawing.Color.Gray;
            this.aGauge1.BaseArcRadius = 80;
            this.aGauge1.BaseArcStart = 180;
            this.aGauge1.BaseArcSweep = 180;
            this.aGauge1.BaseArcWidth = 2;
            this.aGauge1.GaugeAutoSize = false;
            this.aGauge1.Location = new System.Drawing.Point(91, 54);
            this.aGauge1.Margin = new System.Windows.Forms.Padding(4);
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
            this.aGauge1.Size = new System.Drawing.Size(280, 148);
            this.aGauge1.TabIndex = 0;
            this.aGauge1.Text = "aGauge1";
            this.aGauge1.Value = 0F;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1827, 804);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.EndButton);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.ConstP);
            this.Controls.Add(this.Down);
            this.Controls.Add(this.Up);
            this.Controls.Add(this.Watering);
            this.Controls.Add(this.LoadL);
            this.Controls.Add(this.Conditioner);
            this.Controls.Add(this.HandBrake);
            this.Controls.Add(this.Fan);
            this.Controls.Add(this.Brake);
            this.Controls.Add(this.Unload);
            this.Controls.Add(this.Unloading);
            this.Controls.Add(this.Hydrau);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aGauge2);
            this.Controls.Add(this.aGauge1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.AGauge aGauge1;
        private System.Windows.Forms.AGauge aGauge2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.Label Hydrau;
        private System.Windows.Forms.Label Unloading;
        private System.Windows.Forms.Label Brake;
        private System.Windows.Forms.Label HandBrake;
        private System.Windows.Forms.Label LoadL;
        private System.Windows.Forms.Label Unload;
        private System.Windows.Forms.Label Fan;
        private System.Windows.Forms.Label Conditioner;
        private System.Windows.Forms.Label Up;
        private System.Windows.Forms.Label Down;
        private System.Windows.Forms.Label Watering;
        private System.Windows.Forms.Label ConstP;
        private System.Windows.Forms.Label Back;
        private System.Windows.Forms.Button EndButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
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
    }
}

