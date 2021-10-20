using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace jf
{
    class Compiler
    {

        private List<String> tokens;

        public Compiler()
        {
            this.tokens = new List<String>();
            this.tokenizer("test.txt");
        }

        public void tokenizer(string fileName)
        {
            string rawCode = File.ReadAllText("../../" + fileName);
            string[] lines = rawCode.Split(' ');
            foreach (var line in lines)
            {
                this.tokens.Add(line.Replace("\n", String.Empty));
            }
            foreach (var token in this.tokens)
            {
                Console.WriteLine(token);
            }
            Console.ReadLine();

            /*Console.WriteLine(rawCode);
            Console.ReadLine();*/
        }


        static void Main(string[] args)
        {
            Compiler c = new Compiler();
        }
    }
}
