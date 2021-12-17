using System.Collections.Generic;

namespace jf
{
    class SymbolTable
    {
        public List<string[]> table = new List<string[]>();
        public int lineNumber;

        public void insert(string idefName, string attribute, int lineNumber)
        {
            string[] temp = { idefName, attribute };
            this.table.Add(temp);
            this.lineNumber = lineNumber;
        }
    }
}
