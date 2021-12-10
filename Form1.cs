using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        jf.Compiler compiler;
        Queue<string> commandsQueue;
        System.Threading.Thread t;
        int lineNumber = 0;
        //jf.Compiler compiler = new jf.Compiler();
        richtextBoxHighlighter rtbh = new richtextBoxHighlighter();
        //jf.Runner runner = new jf.Runner();

        public Form1(Object compiler, Queue<string> commandsQueue)
        {
            this.compiler = (jf.Compiler) compiler;
            this.commandsQueue = commandsQueue;
            InitializeComponent();
        }

        private void PressureManualUp_Click(object sender, EventArgs e)
        {
            Pressure.Value++;
        }

        private void PressureManualDown_Click(object sender, EventArgs e)
        {
            if (Pressure.Value>0)
            {
            Pressure.Value--;
            }
        }

        private void TorqueManualUp_Click(object sender, EventArgs e)
        {
            Torque.Value++;
        }

        private void TorqueManualDown_Click(object sender, EventArgs e)
        {
            if (Torque.Value>0)
            {
                Torque.Value--;
            }
        }

        private void FanSpeedManualUp_Click(object sender, EventArgs e)
        {
            if (FanBar.Value<100)
            {
                FanBar.Value++;
            }
        }

        private void FanSpeedManualDown_Click(object sender, EventArgs e)
        {
            if (FanBar.Value>0)
            {
                FanBar.Value--;
            }
        }

        private void SpeedManualUp_Click(object sender, EventArgs e)
        {
            speed.Value++;
        }

        private void SpeedManualDown_Click(object sender, EventArgs e)
        {
            if (speed.Value>0)
            {
                speed.Value--;
            }
        }

        private void manualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.Visible = true;
            panel1.BringToFront();
        }

        private void automaticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            panel2.BringToFront();
        }

        private void Pressure_ValueChanged(object sender, EventArgs e)
        {
            label6.Text = "Pressure["+Pressure.Value.ToString()+"MPa]";
        }

        private void FanBar_ValueChanged(object sender, EventArgs e)
        {
            label9.Text = "Fan Speed [%" + FanBar.Value.ToString() + "]";
        }

        private void Torque_ValueChanged(object sender, EventArgs e)
        {
            label7.Text = "Torque[" + Torque.Value.ToString() + "NM]";
        }

        private void speed_ValueChanged(object sender, EventArgs e)
        {
            label8.Text = "Speed[" + speed.Value.ToString() + "N/min]";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            FanSpeedManualUp.ImageAlign = ContentAlignment.MiddleCenter;
            panel1.Location = new Point(0, 370);
            panel2.Location = new Point(0, 370);
            panel2.Height = (this.Height / 2) - 20;
            panel3.Location = new Point(0, 25);
            richTextBox1.ReadOnly = true;
            richTextBox1.Width = (ClientSize.Width-90) / 2;
            chart1.Width = richTextBox1.Width;
            chart1.Height = richTextBox1.Height;
            label1.Text = chart1.Height.ToString();
            label2.Text = richTextBox1.Height.ToString();
            chart1.Left = richTextBox1.Width+60;
            richTextBox1.Left = 30;
            rtbh.WriteFromCompilerToRichTextBox(richTextBox1, compiler.getRealLine(), lineNumber);
            richTextBox1.AppendText("###############################\n");
            lineNumber++;
            List < Tuple<string, List<double>> > test = compiler.getConstants();
            string value = "";
            for (int i=0; i < test.Count; i++)
            {
                value = "";
                foreach(double d in test[i].Item2)
                {
                    value += d.ToString() + " ";
                } 
                richTextBox1.AppendText(test[i].Item1 + "   " + value + "\n");
                lineNumber++;
            }
            richTextBox1.AppendText("###############################\n");
            lineNumber++;
            panel3.Left = (ClientSize.Width - panel3.Width) / 2;
            t = new System.Threading.Thread(ReadCommands);
            t.Start();
        }

        private void ReadCommands()
        {
            while (true)
            {
                if(commandsQueue.Count > 0)
                {
                    MethodInvoker mi = delegate () { 
                        richTextBox1.AppendText(commandsQueue.Dequeue());

                        //int start = richTextBox1.GetFirstCharIndexFromLine(lineNumber-1);
                        //int length = richTextBox1.Lines[lineNumber-1].Length;
                        //richTextBox1.Select(start, length);
                        //richTextBox1.SelectionBackColor = Color.White;

                        //start = richTextBox1.GetFirstCharIndexFromLine(lineNumber);
                        //length = richTextBox1.Lines[lineNumber].Length;
                       // richTextBox1.Select(start, length);
                        //richTextBox1.SelectionBackColor = Color.FromArgb(0x4c, 0xe6, 0x00);
                        //lineNumber++;
                    };
                    this.Invoke(mi);
                    
                }
            }
        }

        private void End_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
