using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    /// <summary>
    /// class <c>richtextBoxHighlighter</c> created for adding text to text box that contains 
    /// code.
    /// </summary>
    class richtextBoxHighlighter
    {

        /// <summary>
        /// <c>WriteFromCompilerToRichTextBox</c> method get lines from compiler in input
        /// and write it line by line in text box. in start of line write number of line, 
        /// after that add a Tab and then codes of that line.
        /// (<paramref name="rtb"/>, <paramref name="lines"/>)
        /// </summary>
        /// <param name="rtb"> is an object of <c>RichTextBox</c> class and its text box that contains
        /// code in UI.
        /// </param>
        /// <param name="lines">is list of Tuples that contains real lines of code</param>
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
