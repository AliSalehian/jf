using System;
using System.Collections.Generic;
using System.Collections;
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

        private readonly List<Token> tokens;
        private readonly List<string> lines;
        private readonly List<Tuple<int, string>> realLines;
        private readonly Explanation explanationSymbolTable = new Explanation();
        private readonly Performable performableSymboltTable = new Performable();
        private readonly List<CustomError> errors;
        private readonly Dictionary<int, string> allErrorsText = new Dictionary<int, string>()
        {
            {0,  "no error"},
            {1, "start and end block is not equal"},
            {2, "extra end of block"},
            {3, "block started but it not ended"},
            {4, "there is other lines after 'end'"},
            {5, "there is no begin in this code"}
        };

        public Compiler()
        {
            Tuple<int, int> startOfPerformable;
            this.tokens = new List<Token>();
            this.lines = new List<String>();
            this.realLines = new List<Tuple<int, string>>();
            this.errors = new List<CustomError>();    
            this.Lineizer("example.txt");
            startOfPerformable = this.FillExplanation();
            this.FillPerformable(startOfPerformable);
        }

        public string[] Tokenizer(string line)
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

        public void Lineizer(string fileName)
        {
            int lineNumber = 0;
            int realLineNumber = 0;
            using (StreamReader sr = new StreamReader("../../" + fileName))
            {
                while(sr.Peek() >= 0)
                {
                    string line = sr.ReadLine();
                    if(line.Length == 0)
                    {
                        realLineNumber++;
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
                    this.realLines.Add(Tuple.Create(realLineNumber, line.Trim()));
                    lineNumber++;
                    realLineNumber++;
                }
            }
        }

        public int FillPerformable(Tuple<int, int> startLineNumber)
        {
            if (startLineNumber == null || startLineNumber.Item1 < 0) return -1000;
            int i;
            Stack parentStack = new Stack();
            bool isEnded = false;
            string firstLine = this.realLines[startLineNumber.Item2].Item2;
            string[] result = this.Tokenizer(firstLine);
            this.performableSymboltTable.root = new Node(result[0], result[1]);
            parentStack.Push(this.performableSymboltTable.root);
            for(i = startLineNumber.Item1 + 1; i < this.realLines.Count; i++)
            {
                string line = this.realLines[i].Item2;
                if (line.Length == 0)
                {
                    continue;
                }
                result = this.Tokenizer(line);
                Node current;
                if (result[0].ToLower() != "loop" && result[0].ToLower() != "if" && result[0].ToLower() != "lend" && result[0].ToLower() != "endif")
                {
                    current = new Node(result[0], result[1])
                    {
                        parent = (Node)parentStack.Peek()
                    };
                    Node temp = (Node)parentStack.Pop();
                    temp.child.Add(current);
                    parentStack.Push(temp);
                }
                else if (result[0].ToLower() == "loop" || result[0].ToLower() == "if")
                {
                    current = new Node(result[0], result[1])
                    {
                        parent = (Node)parentStack.Peek()
                    };
                    Node temp = (Node)parentStack.Pop();
                    temp.child.Add(current);
                    parentStack.Push(temp);
                    parentStack.Push(current);
                }
                else if (result[0].ToLower() == "lend" || result[0].ToLower() == "endif")
                {
                    Node temp = (Node)parentStack.Peek();
                    // error -1 is = start and end block is not equal
                    if (result[0].ToLower() == "lend" && temp.identifier == "if")
                    {
                        this.errors.Add(new CustomError(i, this.allErrorsText[1]));
                        return -1;
                    }
                    if (result[0].ToLower() == "endif" && temp.identifier == "loop")
                    {
                        this.errors.Add(new CustomError(i, this.allErrorsText[1]));
                        return -1;
                    }
                    // error -2 = extra end of block
                    if (temp == this.performableSymboltTable.root)
                    {

                        this.errors.Add(new CustomError(i, this.allErrorsText[2]));
                        return -2;
                    }
                    current = new Node(result[0], result[1])
                    {
                        parent = (Node)parentStack.Peek()
                    };
                    Node temp2 = (Node)parentStack.Pop();
                    temp2.child.Add(current);
                    temp2 = (Node)parentStack.Peek();

                }
                else if (result[0].ToLower() == "end")
                {
                    // error -3 = block started but it not ended
                    if ((Node)parentStack.Peek() == this.performableSymboltTable.root)
                    {

                        this.errors.Add(new CustomError(i, this.allErrorsText[3]));
                        return -3;
                    }
                    break;
                }
                if (i == this.realLines.Count - 1) isEnded = true;
            }

            // error -4 = there is other lines after 'end'
            if (isEnded == false) {
                this.errors.Add(new CustomError(i, this.allErrorsText[4]));
                return -4;
            }
            return 1;
        }

        /*
         * fill Eplanation symbol table, its iterate lines till see "begin"
         * return : type = int, mean = begin line number of performable section
         */

        public Tuple<int, int> FillExplanation()
        {
            int lineCounter = 0;
            int realLineCounter = 0;
            foreach(var line in this.realLines)
            {
                if (line.Item2.Length == 0)
                {
                    realLineCounter++;
                    continue;
                }
                if (line.Item2.ToLower().Equals("begin"))
                {
                    return Tuple.Create(realLineCounter, lineCounter);
                }
                string[] restlt = this.Tokenizer(line.Item2);
                this.explanationSymbolTable.st.insert(restlt[0], restlt[1]);
                lineCounter++;
                realLineCounter++;
            }
            //return an error - there is no begin in this code
            this.errors.Add(new CustomError(realLineCounter, this.allErrorsText[5]));
            return Tuple.Create(-1, -1);
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


            Console.WriteLine(c.performableSymboltTable.root.identifier);
            Console.WriteLine(c.performableSymboltTable.root.child[0].identifier);
            Console.WriteLine(c.performableSymboltTable.root.child[1].identifier);
            Console.WriteLine(c.performableSymboltTable.root.child[3].child[0].identifier);
            Console.WriteLine(c.performableSymboltTable.root.child[3].child[4].identifier);
            Console.WriteLine(c.performableSymboltTable.root.child[4].identifier);
            Console.WriteLine(c.performableSymboltTable.root.child[5].identifier);


            //Node.printTree(c.performableSymboltTable.root);


            /*foreach(var line in c.realLines)
            {
                Console.WriteLine("line number {0} is {1}", line.Item1, line.Item2);
            }*/


            Console.ReadLine();
        }
    }
}
