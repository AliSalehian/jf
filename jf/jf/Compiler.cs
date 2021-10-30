using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace jf
{
    class Compiler
    {
        public class Token
        {
            public string value;
            public int lineNumber;
            public int indexInLine;

            public Token(string value, int lineNumber, int indexInLine)
            {
                this.value = value;
                this.lineNumber = lineNumber;
                this.indexInLine = indexInLine;
            }
        }

        public List<Token> tokens;
        public List<String> lines;

        public Compiler()
        {
            this.tokens = new List<Token>();
            this.lines = new List<String>();
            this.tokenizer("example.txt");
        }

        public void tokenizer(string fileName)
        {
            int lineNumber = 1;
            using (StreamReader sr = new StreamReader("../../" + fileName))
            {
                while(sr.Peek() >= 0)
                {
                    string line = sr.ReadLine();
                    if(line.Length == 0)
                    {
                        continue;
                    }
                    string[] words = line.Split(' ');
                    int wordNumber = 1;
                    foreach(var word in words)
                    {
                        if(word.Trim().Length == 0)
                        {
                            continue;
                        }
                        Token t = new Token(word.Trim(), lineNumber, wordNumber);
                        this.tokens.Add(t);
                        wordNumber++;
                    }
                    this.lines.Add(line);
                    lineNumber++;
                }
            }
        }


        static void Main(string[] args)
        {
            int counter = 0;
            Compiler c = new Compiler();
            foreach(var token in c.tokens)
            {
                string output = String.Format("token number {0} is '{1}', it is in line {2} and in this line is {3}th word", counter, token.value, token.lineNumber, token.indexInLine);
                Console.WriteLine(output);
                counter++;
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
