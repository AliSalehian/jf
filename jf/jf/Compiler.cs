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

        private List<Token> tokens;
        private List<String> lines;
        private Explanation explanationSymbolTable = new Explanation();
        private Performable performableSymboltTable = new Performable();

        public Compiler()
        {
            int startOfPerformable;
            this.tokens = new List<Token>();
            this.lines = new List<String>();
            this.lineizer("example.txt");
            startOfPerformable = this.fillExplanation();
            this.fillPerformable(startOfPerformable);
        }

        public string[] tokenizer(string line)
        {
            string[] result = new string[2];
            string[] words = line.Split(' ');
            result[0] = words[0];
            for(int i=1; i < words.Length; i++)
            {
                result[1] += words[i].Trim();
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

        public int fillPerformable(int startLineNumber)
        {
            List<Node> stack = new List<Node>();
            Node current = null;
            bool isEnded = false;
            string firstLine = this.lines[startLineNumber];
            string[] result = this.tokenizer(firstLine);
            this.performableSymboltTable.root = new Node(result[0], result[1]);
            stack.Add(this.performableSymboltTable.root);
            for(int i = startLineNumber+1; i < this.lines.Count; i++)
            {
                string line = this.lines[i];
                result = this.tokenizer(line);
                if(result[0].ToLower() != "loop" && result[0].ToLower() != "if")
                {
                    current = new Node(result[0], result[1]);
                    current.parent = stack[stack.Count - 1];
                    stack[stack.Count - 1].child.Add(current);
                } else if(result[0].ToLower() == "loop" || result[0].ToLower() == "if")
                {
                    current = new Node(result[0], result[1]);
                    current.parent = stack[stack.Count - 1];
                    stack[stack.Count - 1].child.Add(current);
                    stack.Add(current);
                } else if(result[0].ToLower() == "lend" || result[0].ToLower() == "endif")
                {
                    // error -1 is = start and end block is not equal
                    if(result[0].ToLower() != stack[stack.Count - 1].identifier)
                    {
                        return -1;
                    }

                    // error -2 = extra end of block
                    if(stack[stack.Count - 1] == this.performableSymboltTable.root)
                    {
                        return -2;
                    }
                    stack.RemoveAt(stack.Count - 1);
                    current = new Node(result[0], result[1]);
                    current.parent = stack[stack.Count - 1];
                    stack[stack.Count - 1].child.Add(current);

                } else if(result[0].ToLower() == "end")
                {
                    // error -3 = block started but it not ended
                    if (stack[stack.Count - 1] == this.performableSymboltTable.root)
                    {
                        return -3;
                    }
                    break;
                }
                if (i == this.lines.Count - 1) isEnded = true;
            }

            // error -4 = there is other lines after 'end'
            if (isEnded == false) return -4;
            return 1;
        }

        /*
         * fill Eplanation symbol table, its iterate lines till see "begin"
         * return : type = int, mean = begin line number of performable section
         */

        public int fillExplanation()
        {
            int lineCounter = 0;
            foreach(var line in this.lines)
            {
                if (line.ToLower().Equals("begin"))
                {
                    return lineCounter;
                }
                string[] restlt = this.tokenizer(line);
                this.explanationSymbolTable.st.insert(restlt[0], restlt[1]);
                lineCounter++;
            }
            return -1;
        }


        static void Main(string[] args)
        {
            //int counter = 0;
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
            /*foreach(var temp in c.explanationSymbolTable.st.table)
            {
                Console.WriteLine(String.Format("identifier name is ''{0}'' and its attribute is ''{1}''", temp[0], temp[1]));
            }*/
            /*Console.WriteLine(c.performableSymboltTable.root.identifier);
            Console.WriteLine(c.performableSymboltTable.root.attribute);*/
            /*Console.WriteLine(c.performableSymboltTable.root.identifier);
            Console.WriteLine(c.performableSymboltTable.root.child[0].identifier);
            Console.WriteLine(c.performableSymboltTable.root.child[1].identifier);*/
            Node.printTree(c.performableSymboltTable.root);
            Console.ReadLine();
        }
    }
}
