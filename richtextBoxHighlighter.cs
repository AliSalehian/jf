using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class richtextBoxHighlighter
    {
        List<string> ReadFunctions = new List<string>();
        int Position;

        //Reads input from selected file and stores into ReadFunctions Array;
            public int lines = new StreamReader("../../example.txt").ReadToEnd().Split(new char[] { '\n' }).Length;
        public void ReadInput(string fileName)
        {
            using (StreamReader r = new StreamReader(fileName))
            {
                string line= r.ReadLine();
                for (int i = 0; i < lines; i++)
                {
                    ReadFunctions.Add(line);
                }
            }
        }

        //Writes lines to a RichTextBox.
        public void WriteToRichTextBox(RichTextBox rtb, int startIndex, int endIndex, int lineNumber)
        {
            Position = 0;
            for (int i = startIndex; i < endIndex; i++)
            {
                rtb.AppendText(ReadFunctions[i]);
                rtb.AppendText(Environment.NewLine);

                //Temporary
                if (lineNumber == Position)
                    rtb.SelectionBackColor = Color.Red;
                Position++;
            }
        }

        public void WriteFromCompilerToRichTextBox(RichTextBox rtb, List<Tuple<int, string>> lines)
        {
            foreach (Tuple<int, string> line in lines)
            {
                rtb.AppendText(line.Item1.ToString() + "    ");
                rtb.AppendText(line.Item2);
                rtb.AppendText(Environment.NewLine);
            }
        }
    }
}
