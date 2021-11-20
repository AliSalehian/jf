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
        private Dictionary<int, string> allErrorsText = new Dictionary<int, string>()
        {
            {0,  "no error"},
            {1, "start and end block is not equal"},
            {2, "extra end of block"},
            {3, "block started but it not ended"},
            {4, "there is other lines after 'end'"},
            {5, "there is no begin in this code"},
            {6, "MODE value should be '0' or '1'"},
            {7, "R0 value should be true number"},
            {8, "I value should be true number"},
            {9, "kmu value should be true number"},
            {10, "data values should be number"},
            {11, "BEGIN should not have value"},
            {12, "there is no END in this code"},
            {13, "END should not have value"}
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
                        this.realLines.Add(Tuple.Create(realLineNumber, ""));
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

        public void FillPerformable(Tuple<int, int> startLineNumber)
        {
            if (startLineNumber == null || startLineNumber.Item1 < 0)
            {
                this.errors.Add(new CustomError(startLineNumber.Item1, this.allErrorsText[5]));
            }
            int i;
            Stack parentStack = new Stack();
            bool isEnded = false;
            string firstLine = this.realLines[startLineNumber.Item1].Item2;
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
                    }
                    if (result[0].ToLower() == "endif" && temp.identifier == "loop")
                    {
                        this.errors.Add(new CustomError(i, this.allErrorsText[1]));
                    }
                    // error -2 = extra end of block
                    if (temp == this.performableSymboltTable.root)
                    {

                        this.errors.Add(new CustomError(i, this.allErrorsText[2]));
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
                    }
                    break;
                }
                if (i == this.realLines.Count - 1) isEnded = true;
            }

            // error -4 = there is other lines after 'end'
            if (isEnded == false) {
                this.errors.Add(new CustomError(i, this.allErrorsText[4]));
            }
            string[] lastLine = this.Tokenizer(this.lines[this.lines.Count - 1]);
            if(lastLine[0].ToLower() != "end")
            {
                this.errors.Add(new CustomError(i, this.allErrorsText[12]));
            }

            if(lastLine[1].Length > 0)
            {
                this.errors.Add(new CustomError(i, this.allErrorsText[13]));
            }
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
                switch (restlt[0].ToLower())
                {
                    case "mode":
                        if (restlt[1] != "0" && restlt[1] != "1")
                        {
                            this.errors.Add(new CustomError(realLineCounter, this.allErrorsText[6]));
                        }
                        break;
                    case "r0":
                        double number;
                        if (double.TryParse(restlt[1], out number) == false){
                            this.errors.Add(new CustomError(realLineCounter, this.allErrorsText[7]));
                        }
                        break;
                    case "i":
                        if (double.TryParse(restlt[1], out number) == false){
                            this.errors.Add(new CustomError(realLineCounter, this.allErrorsText[8]));
                        }
                        break;
                    case "kmu":
                        if (double.TryParse(restlt[1], out number) == false){
                            this.errors.Add(new CustomError(realLineCounter, this.allErrorsText[9]));
                        }
                        break;
                    case "data":
                        string[] temp = restlt[1].Split(',');
                        foreach(string s in temp)
                        {
                            if (double.TryParse(s, out number) == false)
                            {
                                if (this.allErrorsText.ContainsKey(10) == false)
                                {
                                    this.allErrorsText.Add(10, String.Format("'{0}' value is not number in data, its should be number", s));
                                }
                                else
                                {
                                    this.allErrorsText[10] = String.Format("'{0}' value is not number in data, its should be number", s);
                                }
                                this.errors.Add(new CustomError(realLineCounter, this.allErrorsText[10]));
                            }
                        }
                        break;
                    case "begin":
                        this.errors.Add(new CustomError(realLineCounter, this.allErrorsText[11]));
                        break;
                }
                this.explanationSymbolTable.st.insert(restlt[0], restlt[1]);
                lineCounter++;
                realLineCounter++;
            }
            return Tuple.Create(-1, -1);
        }

        public static void Print(Compiler c)
        {
            Console.WriteLine("##############################################################");
            Console.WriteLine(">>> lines created (empty lines deleted) : ");

            foreach (string line in c.lines)
            {
                Console.WriteLine(line);
            }

            Console.WriteLine("##############################################################");
            Console.WriteLine(">>> complete lines created by empty lines");

            foreach (var line in c.realLines)
            {
                Console.WriteLine("{0}  {1}", line.Item1, line.Item2);
            }

            Console.WriteLine("##############################################################");
            Console.WriteLine(">>> explamation part : ");

            foreach (var temp in c.explanationSymbolTable.st.table)
            {
                Console.WriteLine(String.Format("identifier name is ''{0}'' and its attribute is ''{1}''", temp[0], temp[1]));
            }

            Console.WriteLine("##############################################################");
            Console.WriteLine(">>> performable part : ");

            Node.printTree(c.performableSymboltTable.root);

            Console.WriteLine("##############################################################");
            Console.WriteLine(">>> list of all errors");

            if (c.errors.Count > 0)
            {
                foreach (CustomError error in c.errors)
                {
                    Console.WriteLine("in line {0} error message is : '{1}'", error.getLineNumber(), error.getMessage());
                }
            }
            else Console.WriteLine("there is no error");

            Console.WriteLine("##############################################################");

            Console.ReadLine();
        }


        static void Main(string[] args)
        {
            //int counter = 0;
            Compiler c = new Compiler();
            SymbolTable s = new SymbolTable();
            Compiler.Print(c);

            /*Console.WriteLine(c.performableSymboltTable.root.identifier);
            Console.WriteLine(c.performableSymboltTable.root.child[0].identifier);
            Console.WriteLine(c.performableSymboltTable.root.child[1].identifier);
            Console.WriteLine(c.performableSymboltTable.root.child[3].child[0].identifier);
            Console.WriteLine(c.performableSymboltTable.root.child[3].child[4].identifier);
            Console.WriteLine(c.performableSymboltTable.root.child[4].identifier);
            Console.ReadLine();*/
        }
    }
}
