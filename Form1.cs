using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        jf.Compiler compiler;
        Queue<jf.Command> commands;
        System.Threading.Thread t;
        richtextBoxHighlighter rtbh = new richtextBoxHighlighter();


        public Form1(Object compiler, Object commands)
        {
            this.compiler = (jf.Compiler) compiler;
            this.commands = (Queue<jf.Command>) commands;
            InitializeComponent();
        }
        /*public void automaticFormInvoker()
        {
            MethodInvoker mi2 = delegate ()
            {
                var AutomaticTest = new AutomaticForm();
                AutomaticTest.Show();


            };
            this.Invoke(mi2);
        }*/

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
            //t1 = new System.Threading.Thread(automaticFormInvoker);
            //t1.SetApartmentState(System.Threading.ApartmentState.STA);
            //t1.Start();
            var AutomaticTest = new AutomaticForm();
            AutomaticTest.ShowDialog();
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
            this.Text = "JF smiulator V 1.1.2";
            this.WindowState = FormWindowState.Maximized;

            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox5.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox6.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox7.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox8.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox9.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox10.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox11.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox12.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox12.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox13.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox13.SizeMode = PictureBoxSizeMode.StretchImage;

            FanSpeedManualUp.ImageAlign = ContentAlignment.MiddleCenter;
            panel2.Visible = false;
            panel1.Visible = true;
            panel1.BringToFront();
            panel1.Location = new Point(0, 380);
            panel2.Location = new Point(0, 380);
            aGauge1.Location = new Point(0, 10);
            aGauge2.Location = new Point(0, 190);
            panel2.Height = (this.Height / 2) - 20;
            panel3.Location = new Point(0, 25);
            richTextBox1.ReadOnly = true;
            richTextBox1.Width = (ClientSize.Width-90) / 2;
            chart1.Width = richTextBox1.Width;
            chart1.Height = richTextBox1.Height;
            chart1.Left = richTextBox1.Width+60;
            richTextBox1.Left = 30;
            rtbh.WriteFromCompilerToRichTextBox(richTextBox1, compiler.getRealLine());
            panel3.Location = new Point(
            this.ClientSize.Width / 2 - panel3.Size.Width / 2, 30);
            t = new System.Threading.Thread(ReadCommands);
            t.Start();
        }

        private void ReadCommands()
        {
            int counter = 0;
            while (true)
            {
                MethodInvoker mi = delegate ()
                {
                    if (commands.Count > 0)
                    {
                        jf.Command command = this.commands.Dequeue();
                        string[] types = command.getType().Split(' ');
                        if (types.Contains("highlight"))
                        {
                            int CommandlineNumber = command.getLineNumber();
                            int start, length;
                            if (CommandlineNumber > 0)
                            {
                                start = richTextBox1.GetFirstCharIndexFromLine(CommandlineNumber - 1);
                                length = richTextBox1.Lines[CommandlineNumber - 1].Length;
                            }
                            else
                            {
                                start = richTextBox1.GetFirstCharIndexFromLine(0);
                                length = richTextBox1.Lines[0].Length;
                            }
                            richTextBox1.Select(start, length);
                            richTextBox1.SelectionBackColor = Color.White;

                            start = 0;
                            length = richTextBox1.Lines[0].Length;
                            richTextBox1.Select(start, length);
                            richTextBox1.SelectionBackColor = Color.White;

                            start = richTextBox1.GetFirstCharIndexFromLine(CommandlineNumber);
                            length = richTextBox1.Lines[CommandlineNumber].Length;
                            richTextBox1.Select(start, length);
                            string pastText = richTextBox1.SelectedText;
                            string change = pastText.Split(' ')[0];
                            if (types.Contains("error"))
                            {
                                richTextBox1.SelectedText = pastText.Replace(change, Encoding.UTF8.GetString(Encoding.Convert(Encoding.Unicode, Encoding.UTF8, Encoding.Unicode.GetBytes("\u2716"))));
                            }
                            else
                            {
                                richTextBox1.SelectedText = pastText.Replace(change, Encoding.UTF8.GetString(Encoding.Convert(Encoding.Unicode, Encoding.UTF8, Encoding.Unicode.GetBytes("\u2705"))));
                            }
                            richTextBox1.Select(start, length);
                            richTextBox1.SelectionBackColor = command.getBgColor();
                            counter++;
                        }
                        if(types.Contains("test"))
                        {
                            richTextBox1.AppendText(command.getNewLine());
                        }
                        if (types.Contains("set"))
                        {
                            R0.Text = command.getNewLine();
                            R0.ReadOnly = true;
                        }
                    }
                };
                this.Invoke(mi);
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

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Hydrau_Click(object sender, EventArgs e)
        {
           
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
    }
}
