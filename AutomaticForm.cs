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
        OpenFileDialog fdlg = new OpenFileDialog();
        public AutomaticForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            t1 = new System.Threading.Thread(GetAddresses);
            t1.SetApartmentState(System.Threading.ApartmentState.STA);
            t1.Start();
        }
        public void GetAddresses()
        {
                MethodInvoker mi2 = delegate ()
                {
                    fdlg.Title = "C# Corner Open File Dialog";
                    fdlg.InitialDirectory = @"c:\";
                    fdlg.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
                    fdlg.FilterIndex = 1;
                    fdlg.RestoreDirectory = true;
                    //if (fdlg.ShowDialog() == DialogResult.OK)
                    //{
                        label1.Text = fdlg.FileName;
                    //}
                };
                this.Invoke(mi2);
        }
    }
}
