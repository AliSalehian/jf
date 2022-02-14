﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;

namespace jf
{

    /// <summary>
    /// Class <c>Compiler</c> is comiler of JF122. its compile code, create symbol tables
    /// save variables, constants and arrays in a searchable format and detect compile time
    /// error of file
    /// </summary>
    class Compiler
    {

        #region Token Class
        /// <summary>
        /// Class <c>Token</c> save 3 property of token. its value, number of line that this token 
        /// exist in code and index of this token in that line
        /// </summary>
        public class Token
        {

            /// <summary>
            /// Instance variable <c>value</c> is a string and represents value of <c>Token</c> 
            /// </summary>
            public string value;

            /// <summary>
            /// Instance variable <c>lineNumber</c> is an integer and represent line number of <c>Token</c>
            /// </summary>
            public int lineNumber;

            /// <summary>
            /// Instance variable <c>indexInLine</c> is an integer and represent position of <c>Token</c> in line
            /// </summary>
            public int indexInLine;

            /// <summary>
            /// this constructor initializes new token with 
            /// (<paramref name="value"/>, <paramref name="lineNumber"/>, <paramref name="indexInLine"/>)
            /// </summary>
            /// <param name="value"> is value of token</param>
            /// <param name="lineNumber"> is number of line that this token exist in code</param>
            /// <param name="indexInLine">is number of index in line that this token exist</param>
            public Token(string value, int lineNumber, int indexInLine)
            {
                this.value = value;
                this.lineNumber = lineNumber;
                this.indexInLine = indexInLine;
            }
        }
        #endregion

        #region Attributes Of Class
        /// <summary>
        /// <c>commands</c> is a queue that is a proxy between UI and backend part of program.
        /// <c>Compiler</c> use this proxy to send codes to UI
        /// </summary>
        Queue<jf.Command> commands;

        /// <summary>
        /// <c>tokens</c> is a generic list of <c>Token</c>s that contains all tokens of code 
        /// </summary>
        private List<Token> tokens;

        /// <summary>
        /// <c>lines</c> is a generic list of strings that contains lines of code without empty lines
        /// </summary>
        private List<string> lines;

        /// <summary>
        /// <c>realLines</c> is a generic list of Tuple. each Tuple contains an integer and a string.
        /// integer is number of line and string is it value
        /// this list contains empty and filled line
        /// </summary>
        private List<Tuple<int, string>> realLines;

        /// <summary>
        /// <c>variables</c> is a generic list of Tuple that contains var that user created in code
        /// each Tuple contains a string and a double. string is name of variable and double is
        /// value of it
        /// </summary>
        private List<Tuple<string, double>> variables;

        /// <summary>
        /// <c>constants</c> is a generic list of Tuple that contains R0, i, mku and data in code
        /// each Tuple contains a sring and a generic list of double. string is name of that constant
        /// list of doubles is values of that constant. for R0, i and kmu its just a singel value (a list with one value)
        /// but for data its have several values
        /// </summary>
        private List<Tuple<string, List<double>>> constants;

        /// <summary>
        /// <c>explanationSymbolTable</c> is an instance of <c>Explanation</c> class and contains symbol table of explanation part of code
        /// all lines befor BEFORE in code is explanation part. this part of code is just configuration and details about code
        /// its has no run code lines
        /// </summary>
        private Explanation explanationSymbolTable = new Explanation();

        /// <summary>
        /// <c>performableSymboltTable</c> is an instance of <c>Performable</c> class and contains symbol table of performable part of code
        /// all lines after BEFORE in code is performable part. this part of code is runnig phase of code. its use sesnsors values and create commands for hardware
        /// </summary>
        private Performable performableSymboltTable = new Performable();

        /// <summary>
        /// <c>errors</c> is a generic list of <c>CustomError</c> objects. its contains error of code. if this list contains no error, runner can work and run the code 
        /// </summary>
        private List<CustomError> errors;

        /// <summary>
        /// <c>allErrorsText</c> is a dictionary that contains errors text. we have 20 errors. 0 means no error found in code
        /// </summary>
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

        #endregion

        #region Methods Of Class
        public Compiler(){}

        /// <summary>
        /// <c>getPerformableTableRoot</c> method is getter of <c>performableSymboltTable</c> root node
        /// </summary>
        /// <returns>return a Node that is root of performable symbol table</returns>
        public Node getPerformableTableRoot(){ return this.performableSymboltTable.root; }

        /// <summary>
        /// <c>getRealLine</c> method is getter of <c>realLines</c> attribute
        /// </summary>
        /// <returns>list of Tuples that contains <c>realLines</c></returns>
        public List<Tuple<int, string>> getRealLine(){ return this.realLines; }

        /// <summary>
        /// <c>getConstants</c> method is getter of <c>constants</c> attribute
        /// </summary>
        /// <returns>list of Tuples that contains <c>constants</c></returns>
        public List<Tuple<string, List<double>>> getConstants() { return this.constants; }

        /// <summary>
        /// <c>getExplanationSymbolTable</c> method is getter of <c>explanationSymbolTable</c> attribute
        /// </summary>
        /// <returns>an object of <c>Explanation</c> that contains <c>explanationSymbolTable</c></returns>
        public Explanation getExplanationSymbolTable() { return this.explanationSymbolTable; }

        /// <summary>
        /// <c>getVariables</c> method is getter of <c>variables</c> attribute
        /// </summary>
        /// <returns>list of Tuples that contains <c>variables</c></returns>
        public List<Tuple<string, double>> getVariables() { return this.variables; }

        /// <summary>
        /// <c>GetErrors</c> method is getter of <c>errors</c> attribute
        /// </summary>
        /// <returns>list of <c>CustomError</c> that contains <c>errors</c></returns>
        public List<CustomError> GetErrors() { return this.errors; }

        /// <summary>
        /// <c>compile</c> compile a jf code file and create all symbol tables and lists for that code
        /// (<paramref name="absolutePath"/>, <paramref name="queue"/>)
        /// </summary>
        /// <param name="absolutePath">path of code file. this path must contains file name</param>
        /// <param name="queue">this queue is peoxy between UI and backend. compiler use it to send command to UI</param>
        public void compile(string absolutePath, Object queue)
        {
            #region Initialize Object Attributes
            this.commands = (Queue<jf.Command>) queue;
            Tuple<int, int> startOfPerformable;
            this.tokens = new List<Token>();
            this.lines = new List<String>();
            this.realLines = new List<Tuple<int, string>>();
            this.errors = new List<CustomError>();
            this.variables = new List<Tuple<string, double>>();
            this.constants = new List<Tuple<string, List<double>>>();
            #endregion

            #region Create Tokens And Symbol Tables
            this.Lineizer(absolutePath);
            startOfPerformable = this.FillExplanation();
            this.FillPerformable(startOfPerformable);
            #endregion

            #region Send Command To UI For Creating TextBox To Show Code
            this.commands.Enqueue(new Command("create ritchbox"));
            #endregion
        }

        /// <summary>
        /// <c>Tokenizer</c> method get a line as string and split it to its words.
        /// this method remove extra blank spaces before and after each word
        /// (<paramref name="line"/>)
        /// </summary>
        /// <param name="line">is a string and contains all words of a line</param>
        /// <returns>array of string that contains words of input line. each index of output contains one word</returns>
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

        /// <summary>
        /// <c>Lineizer</c> method open jf code file and read it line by line.
        /// its create <c>Token</c> object for each token and add it to <c>tokens</c> array
        /// </summary>
        /// <param name="absolutePath"></param>
        public void Lineizer(string absolutePath)
        {
            int lineNumber = 0;
            int realLineNumber = 0;

            #region Open Code File And Read It Line By Line
            using (StreamReader sr = new StreamReader(absolutePath))
            {
                while(sr.Peek() >= 0)
                {

                    #region Go To Next Line If Current Line Is Empty
                    string line = sr.ReadLine();
                    if(line.Length == 0)
                    {
                        this.realLines.Add(Tuple.Create(realLineNumber, ""));
                        realLineNumber++;
                        continue;
                    }
                    #endregion

                    #region Create Tokens For Each Word
                    string[] words = line.Split(' ');
                    int wordNumber = 0;
                    foreach(var word in words)
                    {

                        #region Pass Empty Words
                        if (word.Trim().Length == 0)
                        {
                            continue;
                        }
                        #endregion

                        #region Tokenize Phrases Contains <=
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
                        #endregion

                        #region Tokenize Phrases Contains >=
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
                        #endregion

                        #region Tokenize Phrases Contains =
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
                        #endregion

                        #region Tokenize Phrases Contains <
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
                        #endregion

                        #region Tokenize Phrases Contains >
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
                        #endregion

                        #region Tokenize Other Phrases That Contains Only One Word
                        Token t = new Token(word.Trim(), lineNumber, wordNumber);
                        this.tokens.Add(t);
                        #endregion

                        wordNumber++;
                    }
                    #endregion

                    #region Add Line To List Of Lines
                    this.lines.Add(line.Trim());
                    this.realLines.Add(Tuple.Create(realLineNumber, line.Trim()));
                    #endregion

                    lineNumber++;
                    realLineNumber++;
                }
            }
            #endregion
        }

        /// <summary>
        /// <c>chechForError</c> method detect all compile time errors in code and add them all to <c>errors</c>
        /// (<paramref name="identifierAndAttribute"/>, <paramref name="isPerformable"/>, <paramref name="lineNumber"/>)
        /// </summary>
        /// <param name="identifierAndAttribute"> is an array of string that contains identifier and attribute. attribute part is optional</param>
        /// <param name="isPerformable"> is a boolean. if token belong to performable part of code, this flag will be true else it gonna be false</param>
        /// <param name="lineNumber"> is an integer and contains number of line of this token</param>
        private void chechForError(string[] identifierAndAttribute, bool isPerformable, int lineNumber)
        {
            #region Detect Errors in Explanation Part Of Code
            if (!isPerformable)
            {
                switch (identifierAndAttribute[0].ToLower())
                {
                    #region Mode Keyword Errors
                    case "mode":

                        // mode attribute should be 0 or 1. other numbers are not valid
                        if (identifierAndAttribute[1] != "0" && identifierAndAttribute[1] != "1")
                        {
                            this.errors.Add(new CustomError(lineNumber, this.allErrorsText[6]));
                        }

                        /* if identifier is mode keywords, its just have one attribute so length of 
                         * identifierAndAttribute should be 2. if it be more than 2, its an error 
                         */
                        if (identifierAndAttribute.Length > 2)
                        {
                            this.errors.Add(new CustomError(lineNumber, this.allErrorsText[100]));
                        }

                        // mode is a constant of code and it should save in constants list
                        List<double> constValue = new List<double>();
                        constValue.Clear();
                        constValue.Add(double.Parse(identifierAndAttribute[1]));
                        this.constants.Add(Tuple.Create(identifierAndAttribute[0],constValue));
                        break;
                    #endregion

                    #region r0 Keyword Errors
                    case "r0":
                        double number;

                        /* attribute of r0 keyword should be a number, so we check it if we can 
                         *  parse it no number or not. if its not possible we find an error 
                         */
                        if (double.TryParse(identifierAndAttribute[1], out number) == false)
                        {
                            this.errors.Add(new CustomError(lineNumber, this.allErrorsText[7]));
                        }

                        /* if identifier is r0 keywords, its just have one attribute so length of 
                         * identifierAndAttribute should be 2. if it be more than 2, its an error 
                         */
                        if (identifierAndAttribute.Length > 2)
                        {
                            this.errors.Add(new CustomError(lineNumber, this.allErrorsText[100]));
                        }

                        // r0 is a constant of code and it should save in constants list
                        constValue = new List<double>();
                        constValue.Clear();
                        constValue.Add(double.Parse(identifierAndAttribute[1]));
                        this.constants.Add(Tuple.Create(identifierAndAttribute[0], constValue));
                        break;
                    #endregion

                    #region i Keyword Errors
                    case "i":

                        /* attribute of i keyword should be a number, so we check it if we can 
                         * parse it no number or not. if its not possible we find an error 
                         */
                        if (double.TryParse(identifierAndAttribute[1], out number) == false)
                        {
                            this.errors.Add(new CustomError(lineNumber, this.allErrorsText[8]));
                        }

                        /* if identifier is i keywords, its just have one attribute so length of 
                         * identifierAndAttribute should be 2. if it be more than 2, its an error 
                         */
                        if (identifierAndAttribute.Length > 2)
                        {
                            this.errors.Add(new CustomError(lineNumber, this.allErrorsText[100]));
                        }

                        // i is a constant of code and it should save in constants list
                        constValue = new List<double>();
                        constValue.Clear();
                        constValue.Add(double.Parse(identifierAndAttribute[1]));
                        this.constants.Add(Tuple.Create(identifierAndAttribute[0], constValue));
                        break;
                    #endregion

                    #region kmu Keyword Errors
                    case "kmu":

                        /* attribute of kmu keyword should be a number, so we check it if we can 
                         * parse it no number or not. if its not possible we find an error 
                         */
                        if (double.TryParse(identifierAndAttribute[1], out number) == false)
                        {
                            this.errors.Add(new CustomError(lineNumber, this.allErrorsText[9]));
                        }

                        /* if identifier is kmu keywords, its just have one attribute so length of 
                         * identifierAndAttribute should be 2. if it be more than 2, its an error 
                         */
                        if (identifierAndAttribute.Length > 2)
                        {
                            this.errors.Add(new CustomError(lineNumber, this.allErrorsText[100]));
                        }

                        // kmu is a constant of code and it should save in constants list
                        constValue = new List<double>();
                        constValue.Clear();
                        constValue.Add(double.Parse(identifierAndAttribute[1]));
                        this.constants.Add(Tuple.Create(identifierAndAttribute[0], constValue));
                        break;
                    #endregion

                    #region data Keyword Errors
                    case "data":

                        /* attribute of data keyword is one or more numbers that are separated by ,
                         * so we should split them by , 
                         * then we should check all of them. if they can not be converted to number 
                         * we are face with an error
                         */
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

                        // at last, we should add data to constant list
                        this.constants.Add(Tuple.Create(identifierAndAttribute[0], constValue));
                        break;
                    #endregion

                    #region begin Keyword Errors
                    case "begin":
                        this.errors.Add(new CustomError(lineNumber, this.allErrorsText[11]));
                        break;
                    #endregion
                }
            }
            #endregion

            // TODO: performable errors are not complete and we should complete it
            #region Detect Errors in Performable Part Of Code
            else
            {
                switch (identifierAndAttribute[0].ToLower()){

                    #region var Keyword Errors
                    case "var":

                        /* var keyword have 2 attribute that are seperated by ,
                         * we should split them by ,
                         */
                        string[] temp = identifierAndAttribute[1].Split(',');

                        // var keyword have 2 attribute, more than 2 attribute is an error
                        if (temp.Length > 2)
                        {
                            this.errors.Add(new CustomError(lineNumber, this.allErrorsText[14]));
                            break;
                        }

                        /* first attribute is name of varibale and name of varibale cant start 
                         * with number. if it start with number we have an error
                         */
                        if (!Char.IsLetter(temp[0][0]))
                        {
                            this.errors.Add(new CustomError(lineNumber, this.allErrorsText[15]));
                            break;
                        }

                        /* second attribute is value of variable and it should be a number
                         * if we cant parse it to number we have an error
                         */
                        double number;
                        if (double.TryParse(temp[1], out number) == false)
                        {
                            this.errors.Add(new CustomError(lineNumber, this.allErrorsText[16]));
                            break;
                        }

                        // at last we should add it to list of variables
                        this.variables.Add(Tuple.Create(temp[0], double.Parse(temp[1])));
                        break;
                    #endregion

                    #region read Keyword Errors
                    case "read":

                        /* read keyword just have one attribute, if length of identifierAndAttribute is
                         * one, its means that we have an error
                         */
                        if (identifierAndAttribute.Length == 1)
                        {
                            this.errors.Add(new CustomError(lineNumber, this.allErrorsText[17]));
                            break;
                        }

                        /* attribute of read keyword should be name of a variable
                         * we check it 
                         */
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
                    #endregion

                    #region restore Keyword Errors
                    case "restore":

                        /* restore keyword has no attribute, so we check length of identifierAndAttribute
                         * its should be 1, if its more than 1 we have an error
                         */
                        if (identifierAndAttribute.Length > 1)
                        {
                            this.errors.Add(new CustomError(lineNumber, this.allErrorsText[19]));
                        }
                        break;
                    #endregion

                    #region add Keyword Errors
                    case "add":

                        /* add keyword has 2 attribute that are seperated by ,
                         * we should split it by ,
                         */
                        temp = identifierAndAttribute[1].Split(',');

                        /* first attribute should be a varibale name, we check first letter of it
                         * and it should be an alphabet not number
                         */
                        if (!Char.IsLetter(temp[0][0]))
                        {
                            this.errors.Add(new CustomError(lineNumber, this.allErrorsText[15]));
                            break;
                        }

                        // then we check that variable exist in list of variables
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

                        /* second attribute can be variable or number, first we check if first letter of it
                         * not be alphabet, so its a number and we should be able to parse it to number
                         * if we cant do that we have an error
                         */
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
                            /* if first letter of second attribute is not number, its a variable
                             * so we should be able to find it in our list of variables
                             * otherwise we have an error
                             */
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
                    #endregion

                    #region set Keyword Errors
                    case "set":

                        /* set keyword has one attribute and it should be pp or pm
                         * otherwise we have an error
                         */
                        if(identifierAndAttribute[1].ToLower() != "pp" && identifierAndAttribute[1].ToLower() != "pm")
                        {
                            this.errors.Add(new CustomError(lineNumber, this.allErrorsText[20]));
                        }
                        break;
                    #endregion

                    #region speed Keyword Errors
                    case "speed":
                        if (!Char.IsLetter(identifierAndAttribute[1][0]))
                        {

                        }
                        break;
                    #endregion
                }
            }
            #endregion
        }

        /// <summary>
        /// <c>FillPerformable</c> method create symbol table of performable part of code
        /// this symbol table is a tree
        /// (<paramref name="startLineNumber"/>)
        /// </summary>
        /// <param name="startLineNumber">is a Tuple of 2 integer. first integer is number of 
        /// line of begin keyword with blank lines. second integer is same without blanck lines</param>
        public void FillPerformable(Tuple<int, int> startLineNumber)
        {

            #region Check For Error
            /* if startLineNumber is null or its values are less than 0, its means that there is no
             * begin keyword in code and we have an error
             */
            if (startLineNumber == null || startLineNumber.Item1 < 0)
            {
                this.errors.Add(new CustomError(startLineNumber.Item1, this.allErrorsText[5]));
            }
            #endregion

            #region Initialize Variables And Create Root Of Tree
            int i;
            int realLineCounter = startLineNumber.Item1;
            Stack parentStack = new Stack();
            bool isEnded = false;
            string firstLine = this.realLines[startLineNumber.Item1].Item2;
            string[] result = this.Tokenizer(firstLine);
            this.performableSymboltTable.root = new Node(result[0], result[1], realLineCounter);
            parentStack.Push(this.performableSymboltTable.root);
            #endregion

            #region Create Symbol Table Tree
            /* iterate lines from begin keyword to end keyword. performable part of code
             * is last part of code
             */
            for (i = startLineNumber.Item1 + 1; i < this.realLines.Count; i++)
            {
                string line = this.realLines[i].Item2;

                // pass empty lines
                if (line.Length == 0)
                {
                    continue;
                }

                // tokenize line
                result = this.Tokenizer(line);

                /* check current line for error. if chechForError method find any error,
                 * it will add it to errors list
                 */
                this.chechForError(result, true, i);
                Node current;

                /* loop and if force us to go in depth. so when we see lend or endif keyword we 
                 * should get back from depth. all other keywords are reqular and should add to breadth
                 */
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

                /* if we see loop or if keyword we should go in depth. for this purpose we should add it
                 * to parent stack
                 */
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

                /* if we see lend or endif keyword, we should get back from depth and continue
                 * our iteration in breadth. for this purpose we should pop parent stack
                 */
                else if (result[0].ToLower() == "lend" || result[0].ToLower() == "endif")
                {
                    Node temp = (Node)parentStack.Peek();

                    /* here we check for an error, if block started with if, its should end
                     * with endif. if block started with loop, its should end with lend. 
                     * otherwise we have an error
                     */
                    if (result[0].ToLower() == "lend" && temp.identifier == "if")
                    {
                        this.errors.Add(new CustomError(i, this.allErrorsText[1]));
                    }
                    if (result[0].ToLower() == "endif" && temp.identifier == "loop")
                    {
                        this.errors.Add(new CustomError(i, this.allErrorsText[1]));
                    }

                    /* this part of code check for extra end of block keyword
                     * extra end of block is an error
                     */
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

                // end keyword is end of code. its end compiler but before that we check an error
                else if (result[0].ToLower() == "end")
                {

                    /* this part of code check for early end keyword. one or more blocks started 
                     * and before they end, end keyword occured in code. its an error
                     * 
                     * for example:
                     * loop 5
                     * ...
                     * ...
                     * end
                     * in this exmaple loop block started but before its end and compiler see lend
                     * keyword, end keyword accured and we faced with an error
                     */
                    if ((Node)parentStack.Peek() == this.performableSymboltTable.root)
                    {

                        this.errors.Add(new CustomError(i, this.allErrorsText[3]));
                    }
                    break;
                }
                if (i == this.realLines.Count - 1) isEnded = true;
            }
            #endregion

            // if there is another line after end keyword, its an error
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

        /// <summary>
        /// <c>FillExplanation</c> method create symbol table of explanation part of code
        /// this symbol table is generic list
        /// </summary>
        /// <returns>its return a Tuple of 2 integers. first integer is number of line of
        /// begin keyword. its counts empty lines too. second integer is number of line of begin 
        /// keyword and its counts just non empty lines</returns>
        public Tuple<int, int> FillExplanation()
        {
            int lineCounter = 0;
            int realLineCounter = 0;
            foreach(var line in this.realLines)
            {

                // pass empty lines
                if (line.Item2.Length == 0)
                {
                    realLineCounter++;
                    continue;
                }

                /* begin keyword is end of explanation part of code
                 * when we see this keyword we should return real line number (counts empty lines too)
                 * and line number (without counting empty lines) as a Tuple
                 */
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

            /* return -1 means there is no begin keyword and in FillPerformable method 
             * we handle this error
             */
            return Tuple.Create(-1, -1);
        }

        #endregion

        #region Test Method
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
        #endregion

    }
}
