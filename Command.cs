using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace jf
{
    internal class Command
    {
        private string type;
        private int lineNumber;
        private Color bgColor;
        private string newLine;

        public Command(string type, int lineNumber)
        {
            this.type = type;
            this.lineNumber = lineNumber;
        }
        public Command(string type, string newLine)
        {
            this.type = type;
            this.newLine = newLine;
        }
        public Command(string type, int lineNumber, Color bgColor)
        {
            this.type = type;
            this.lineNumber = lineNumber;
            this.bgColor = bgColor;
        }

        public string getType(){ return type; }
        public void setType(string type){ this.type = type; }

        public int getLineNumber(){ return lineNumber; }
        public void setLineNumber(int lineNumber){ this.lineNumber = lineNumber; }
        public Color getBgColor(){ return bgColor; } 

        public string getNewLine(){ return newLine; } 

    }
}
