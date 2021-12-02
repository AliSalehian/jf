using System;
using System.Collections.Generic;
using System.Text;

namespace jf
{
    class SymbolTable
    {
        public List<string[]> table = new List<string[]>();

        public void insert(string idefName, string attribute)
        {
            string[] temp = { idefName, attribute };
            this.table.Add(temp);
        }
    }
}
