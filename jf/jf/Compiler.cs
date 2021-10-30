using System;
using System.Collections.Generic;
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
        public Explanation e = new Explanation();

        public Compiler()
        {
            this.tokens = new List<Token>();
            this.lines = new List<String>();
            this.lineizer("example.txt");
            this.fillExplanation();
        }

        public string[] tokenizer(string line)
        {
            string[] result = new string[2];
            string[] words = line.Split(' ');
            result[0] = words[0];
            for(int i=1; i < words.Length; i++)
            {
                result[1] += words[i] + " ";
            }
            return result;
        } 

        public void lineizer(string fileName)
        {
            int lineNumber = 0;
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
                    int wordNumber = 0;
                    foreach(var word in words)
                    {
                        if(word.Trim().Length == 0)
                        {
                            continue;
                        }
                        if (word.Contains("<="))
                        {
                            string temp1 = word;
                            temp1 = word.Replace("<=", " ");
                            string[] temp2 = temp1.Split(' ');
                            Token t1 = new Token(temp2[0].Trim(), lineNumber, wordNumber);
                            wordNumber++;
                            Token t2 = new Token("<=", lineNumber, wordNumber);
                            wordNumber++;
                            Token t3 = new Token(temp2[1], lineNumber, wordNumber);
                            wordNumber++;
                            this.tokens.Add(t1);
                            this.tokens.Add(t2);
                            this.tokens.Add(t3);
                            continue;
                        }

                        if (word.Contains(">="))
                        {
                            string temp1 = word;
                            temp1 = word.Replace(">=", " ");
                            string[] temp2 = temp1.Split(' ');
                            Token t1 = new Token(temp2[0].Trim(), lineNumber, wordNumber);
                            wordNumber++;
                            Token t2 = new Token(">=", lineNumber, wordNumber);
                            wordNumber++;
                            Token t3 = new Token(temp2[1], lineNumber, wordNumber);
                            wordNumber++;
                            this.tokens.Add(t1);
                            this.tokens.Add(t2);
                            this.tokens.Add(t3);
                            continue;
                        }

                        if (word.Contains("="))
                        {
                            string temp1 = word;
                            temp1 = word.Replace("=", " ");
                            string[] temp2 = temp1.Split(' ');
                            Token t1 = new Token(temp2[0].Trim(), lineNumber, wordNumber);
                            wordNumber++;
                            Token t2 = new Token("=", lineNumber, wordNumber);
                            wordNumber++;
                            Token t3 = new Token(temp2[1], lineNumber, wordNumber);
                            wordNumber++;
                            this.tokens.Add(t1);
                            this.tokens.Add(t2);
                            this.tokens.Add(t3);
                            continue;
                        }

                        if (word.Contains("<"))
                        {
                            string temp1 = word;
                            temp1 = word.Replace("<", " ");
                            string[] temp2 = temp1.Split(' ');
                            Token t1 = new Token(temp2[0].Trim(), lineNumber, wordNumber);
                            wordNumber++;
                            Token t2 = new Token("<", lineNumber, wordNumber);
                            wordNumber++;
                            Token t3 = new Token(temp2[1], lineNumber, wordNumber);
                            wordNumber++;
                            this.tokens.Add(t1);
                            this.tokens.Add(t2);
                            this.tokens.Add(t3);
                            continue;
                        }

                        if (word.Contains(">"))
                        {
                            string temp1 = word;
                            temp1 = word.Replace(">", " ");
                            string[] temp2 = temp1.Split(' ');
                            Token t1 = new Token(temp2[0].Trim(), lineNumber, wordNumber);
                            wordNumber++;
                            Token t2 = new Token(">", lineNumber, wordNumber);
                            wordNumber++;
                            Token t3 = new Token(temp2[1], lineNumber, wordNumber);
                            wordNumber++;
                            this.tokens.Add(t1);
                            this.tokens.Add(t2);
                            this.tokens.Add(t3);
                            continue;
                        }
                        Token t = new Token(word.Trim(), lineNumber, wordNumber);
                        this.tokens.Add(t);
                        wordNumber++;
                    }
                    this.lines.Add(line.Trim());
                    lineNumber++;
                }
            }
        }

        public void fillExplanation()
        {
            foreach(var line in this.lines)
            {
                if (line.ToLower().Equals("begin"))
                {
                    break;
                }
                string[] restlt = this.tokenizer(line);
                this.e.st.insert(restlt[0], restlt[1]);
            }
        }


        static void Main(string[] args)
        {
            int counter = 0;
            Compiler c = new Compiler();
            SymbolTable s = new SymbolTable();
            /*foreach(var token in c.tokens)
            {
                string output = String.Format("token number {0} is '{1}', it is in line {2} and in this line is {3}th word", counter, token.value, token.lineNumber, token.indexInLine);
                Console.WriteLine(output);
                counter++;
                Console.WriteLine();
            }
            foreach(var line in c.lines)
            {
                Console.WriteLine(line);
            }*/
            foreach(var temp in c.e.st.table)
            {
                Console.WriteLine(String.Format("identifier name is {0} and its attribute is {1}", temp[0], temp[1]));
            }
            Console.ReadLine();
        }
    }
}
