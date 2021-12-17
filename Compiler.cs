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
        private readonly List<Tuple<string, double>> variables;
        private readonly List<Tuple<string, List<double>>> constants;
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
            {13, "END should not have value"},
            {14, "VAR has extra value"},
            {15, "VAR name should be start with letter"},
            {16, "VAR value should be number"},
            {17, "READ need a value"},
            {18, "this value is not defined"},
            {19, "RESTORE has no attribute"},
            {20, "SET value sould be 'pp' or 'pm'"},
            {100, "too many attribute"}
        };

        public Compiler()
        {
            Tuple<int, int> startOfPerformable;
            this.tokens = new List<Token>();
            this.lines = new List<String>();
            this.realLines = new List<Tuple<int, string>>();
            this.errors = new List<CustomError>();
            this.variables = new List<Tuple<string, double>>();
            this.constants = new List<Tuple<string, List<double>>>();
            this.Lineizer("example.txt");
            startOfPerformable = this.FillExplanation();
            this.FillPerformable(startOfPerformable);
        }

        public Node getPerformableTableRoot(){ return this.performableSymboltTable.root; }
        public List<Tuple<int, string>> getRealLine(){ return this.realLines; }
        public List<Tuple<string, List<double>>> getConstants() { return this.constants; }
        public Explanation getExplanationSymbolTable() { return this.explanationSymbolTable; }
        public List<Tuple<string, double>> getVariables() { return this.variables; }
        public List<CustomError> GetErrors() { return this.errors; }

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

        private void chechForError(string[] identifierAndAttribute, bool isPerformable, int lineNumber)
        {
            if (!isPerformable)
            {
                switch (identifierAndAttribute[0].ToLower())
                {
                    case "mode":
                        if (identifierAndAttribute[1] != "0" && identifierAndAttribute[1] != "1")
                        {
                            this.errors.Add(new CustomError(lineNumber, this.allErrorsText[6]));
                        }
                        if(identifierAndAttribute.Length > 2)
                        {
                            this.errors.Add(new CustomError(lineNumber, this.allErrorsText[100]));
                        }
                        List<double> constValue = new List<double>();
                        constValue.Clear();
                        constValue.Add(double.Parse(identifierAndAttribute[1]));
                        this.constants.Add(Tuple.Create(identifierAndAttribute[0],constValue));
                        break;
                    case "r0":
                        double number;
                        if (double.TryParse(identifierAndAttribute[1], out number) == false)
                        {
                            this.errors.Add(new CustomError(lineNumber, this.allErrorsText[7]));
                        }
                        if (identifierAndAttribute.Length > 2)
                        {
                            this.errors.Add(new CustomError(lineNumber, this.allErrorsText[100]));
                        }
                        constValue = new List<double>();
                        constValue.Clear();
                        constValue.Add(double.Parse(identifierAndAttribute[1]));
                        this.constants.Add(Tuple.Create(identifierAndAttribute[0], constValue));
                        break;
                    case "i":
                        if (double.TryParse(identifierAndAttribute[1], out number) == false)
                        {
                            this.errors.Add(new CustomError(lineNumber, this.allErrorsText[8]));
                        }
                        if (identifierAndAttribute.Length > 2)
                        {
                            this.errors.Add(new CustomError(lineNumber, this.allErrorsText[100]));
                        }
                        constValue = new List<double>();
                        constValue.Clear();
                        constValue.Add(double.Parse(identifierAndAttribute[1]));
                        this.constants.Add(Tuple.Create(identifierAndAttribute[0], constValue));
                        break;
                    case "kmu":
                        if (double.TryParse(identifierAndAttribute[1], out number) == false)
                        {
                            this.errors.Add(new CustomError(lineNumber, this.allErrorsText[9]));
                        }
                        if (identifierAndAttribute.Length > 2)
                        {
                            this.errors.Add(new CustomError(lineNumber, this.allErrorsText[100]));
                        }
                        constValue = new List<double>();
                        constValue.Clear();
                        constValue.Add(double.Parse(identifierAndAttribute[1]));
                        this.constants.Add(Tuple.Create(identifierAndAttribute[0], constValue));
                        break;
                    case "data":
                        string[] temp = identifierAndAttribute[1].Split(',');
                        constValue = new List<double>();
                        constValue.Clear();
                        foreach (string s in temp)
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
                                this.errors.Add(new CustomError(lineNumber, this.allErrorsText[10]));
                            }
                            constValue.Add(double.Parse(s));
                        }
                        this.constants.Add(Tuple.Create(identifierAndAttribute[0], constValue));
                        break;
                    case "begin":
                        this.errors.Add(new CustomError(lineNumber, this.allErrorsText[11]));
                        break;
                }
            }
            else
            {
                switch (identifierAndAttribute[0].ToLower()){
                    case "var":
                        string[] temp = identifierAndAttribute[1].Split(',');
                        if (temp.Length > 2)
                        {
                            this.errors.Add(new CustomError(lineNumber, this.allErrorsText[14]));
                            break;
                        }
                        if (!Char.IsLetter(temp[0][0]))
                        {
                            this.errors.Add(new CustomError(lineNumber, this.allErrorsText[15]));
                            break;
                        }
                        double number;
                        if (double.TryParse(temp[1], out number) == false)
                        {
                            this.errors.Add(new CustomError(lineNumber, this.allErrorsText[16]));
                            break;
                        }
                        this.variables.Add(Tuple.Create(temp[0], double.Parse(temp[1])));
                        break;
                    case "read":
                        if (identifierAndAttribute.Length == 1)
                        {
                            this.errors.Add(new CustomError(lineNumber, this.allErrorsText[17]));
                            break;
                        }
                        bool isItInDefined = false;
                        foreach (Tuple<string, double> t in this.variables)
                        {
                            if (t.Item1 == identifierAndAttribute[1])
                            {
                                isItInDefined = true;
                                break;
                            }
                        }
                        if (isItInDefined == false)
                        {
                            this.errors.Add(new CustomError(lineNumber, this.allErrorsText[18]));
                            break;
                        }
                        break;
                    case "restore":
                        if (identifierAndAttribute.Length > 1)
                        {
                            this.errors.Add(new CustomError(lineNumber, this.allErrorsText[19]));
                        }
                        break;
                    case "add":
                        temp = identifierAndAttribute[1].Split(',');
                        if (!Char.IsLetter(temp[0][0]))
                        {
                            this.errors.Add(new CustomError(lineNumber, this.allErrorsText[15]));
                            break;
                        }
                        isItInDefined = false;
                        foreach (Tuple<string, double> t in this.variables)
                        {
                            if (t.Item1 == temp[0])
                            {
                                isItInDefined = true;
                                break;
                            }
                        }
                        if (isItInDefined == false)
                        {
                            this.errors.Add(new CustomError(lineNumber, this.allErrorsText[18]));
                            break;
                        }
                        if (!Char.IsLetter(temp[1][0]))
                        {
                            if (double.TryParse(temp[1], out number) == false)
                            {
                                this.errors.Add(new CustomError(lineNumber, this.allErrorsText[16]));
                                break;
                            }
                        }
                        else
                        {
                            isItInDefined = false;
                            foreach (Tuple<string, double> t in this.variables)
                            {
                                if (t.Item1 == temp[1])
                                {
                                    isItInDefined = true;
                                    break;
                                }
                            }
                            if (isItInDefined == false)
                            {
                                this.errors.Add(new CustomError(lineNumber, this.allErrorsText[18]));
                                break;
                            }
                        }
                        break;
                    case "set":
                        if(identifierAndAttribute[1].ToLower() != "pp" && identifierAndAttribute[1].ToLower() != "pm")
                        {
                            this.errors.Add(new CustomError(lineNumber, this.allErrorsText[20]));
                        }
                        break;
                    case "speed":
                        if (!Char.IsLetter(identifierAndAttribute[1][0]))
                        {

                        }
                        break;
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
            int realLineCounter = startLineNumber.Item1;
            Stack parentStack = new Stack();
            bool isEnded = false;
            string firstLine = this.realLines[startLineNumber.Item1].Item2;
            string[] result = this.Tokenizer(firstLine);
            this.performableSymboltTable.root = new Node(result[0], result[1], realLineCounter);
            parentStack.Push(this.performableSymboltTable.root);
            for(i = startLineNumber.Item1 + 1; i < this.realLines.Count; i++)
            {
                string line = this.realLines[i].Item2;
                if (line.Length == 0)
                {
                    continue;
                }
                result = this.Tokenizer(line);
                this.chechForError(result, true, i);
                Node current;
                if (result[0].ToLower() != "loop" && result[0].ToLower() != "if" && result[0].ToLower() != "lend" && result[0].ToLower() != "endif")
                {
                    current = new Node(result[0], result[1], i)
                    {
                        parent = (Node)parentStack.Peek()
                    };
                    Node temp = (Node)parentStack.Pop();
                    temp.child.Add(current);
                    parentStack.Push(temp);
                }
                else if (result[0].ToLower() == "loop" || result[0].ToLower() == "if")
                {
                    current = new Node(result[0], result[1], i)
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
                    current = new Node(result[0], result[1], i)
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

            if(lastLine.Length > 2)
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
                string[] result = this.Tokenizer(line.Item2);
                this.chechForError(result, false, realLineCounter);
                this.explanationSymbolTable.st.insert(result[0], result[1], realLineCounter);
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
    }
}
