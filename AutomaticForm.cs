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
    public partial class AutomaticForm : Form
    {
        System.Threading.Thread t1;
        int temp = 1;
        string addedButtonNumber = "addedButton";
        string addedLabelNumber = "addedLabel";

        public AutomaticForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            AutoScroll = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Chosse code...";
                openFileDialog.Filter = "All files (*.*)|*.*|txt files (*.txt)|*.txt";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    label1.Text = openFileDialog.SafeFileName;
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {

            Button addedButton = new Button();
            Label addedlabel = new Label();
            addedButtonNumber += temp.ToString();
            addedLabelNumber += temp.ToString();


            // add label
            addedlabel.Name = addedLabelNumber;
            addedlabel.Location = new Point(106, 226 + temp * 20);
            addedlabel.Height = 20;
            addedlabel.Width = 200;
            addedlabel.Text = addedLabelNumber;


            // add 
            addedButton.Name = addedButtonNumber;
            addedButton.Location = new Point(380, 226 + temp * 20);
            addedButton.Height = 20;
            addedButton.Width = 55;
            addedButton.Text = temp.ToString();



            //add even handler for button
            //foreach (Button BTN in LB) // <- this is a globaly declared List<Button>
            //{
            //    this.Controls.Add(BTN);
            //    BTN.Click += new EventHandler(BTN_Click);
            //}

            //
            //



            temp++;
            Controls.Add(addedButton);
            Controls.Add(addedlabel);
            addedLabelNumber = "addedLabel";
            addedButtonNumber = "addedButton";


        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Chosse code...";
                openFileDialog.Filter = "All files (*.*)|*.*|txt files (*.txt)|*.txt";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    label2.Text = openFileDialog.SafeFileName;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Chosse code...";
                openFileDialog.Filter = "All files (*.*)|*.*|txt files (*.txt)|*.txt";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    label3.Text = openFileDialog.SafeFileName;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Chosse code...";
                openFileDialog.Filter = "All files (*.*)|*.*|txt files (*.txt)|*.txt";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    label4.Text = openFileDialog.SafeFileName;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Chosse code...";
                openFileDialog.Filter = "All files (*.*)|*.*|txt files (*.txt)|*.txt";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    label5.Text = openFileDialog.SafeFileName;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Chosse code...";
                openFileDialog.Filter = "All files (*.*)|*.*|txt files (*.txt)|*.txt";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    label6.Text = openFileDialog.SafeFileName;
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Chosse code...";
                openFileDialog.Filter = "All files (*.*)|*.*|txt files (*.txt)|*.txt";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    label7.Text = openFileDialog.SafeFileName;
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Chosse code...";
                openFileDialog.Filter = "All files (*.*)|*.*|txt files (*.txt)|*.txt";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    label8.Text = openFileDialog.SafeFileName;
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Chosse code...";
                openFileDialog.Filter = "All files (*.*)|*.*|txt files (*.txt)|*.txt";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    label9.Text = openFileDialog.SafeFileName;
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Chosse code...";
                openFileDialog.Filter = "All files (*.*)|*.*|txt files (*.txt)|*.txt";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    label10.Text = openFileDialog.SafeFileName;
                }
            }
        }
    }
}
