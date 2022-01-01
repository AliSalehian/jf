﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Collections;
using System.Drawing;

namespace jf
{
    class Runner
    {
        jf.Compiler compiler;
        Queue<jf.Command> commands;
        Color GREEN = Color.FromArgb(0x4c, 0xe6, 0x00); // #4ce600
        Color RED = Color.FromArgb(0xff, 0x5c, 0x33); // #ff5c33

        public Runner(jf.Compiler compiler, Queue<jf.Command> commands)
        {
            this.compiler = compiler;
            this.commands = commands;
        }

        public void writeCommandToFile(string text)
        {
            const string commandFilePath = "../../board/commands.txt";
            using (StreamWriter sw = new StreamWriter(commandFilePath, append: true))
            {
                sw.WriteLine(text);
            }
        }

        public List<double> findData(List<Tuple<string, List<double>>> constants)
        {
            for(int i=0; i<constants.Count; i++)
            {
                if(constants[i].Item1.ToLower() == "data")
                {
                    return constants[i].Item2;
                }
            }
            return null;
        }

        public double findVariable(List<Tuple<string, double>> variables, string valueName)
        {
            for (int i = 0; i < variables.Count; i++)
            {
                if (variables[i].Item1.ToLower() == valueName)
                {
                    return variables[i].Item2;
                }
            }
            return 0;
        }

        public void findVariableAndChangeValue(List<Tuple<string, double>> variables, string variableName, double newValue)
        {
            for (int i = 0; i < variables.Count; i++)
            {
                if (variables[i].Item1.ToLower() == variableName)
                {
                    variables[i] = Tuple.Create(variables[i].Item1, newValue);
                }
            }
        }

        public void run()
        {
            bool errorDetected = false;
            int lineCounter = 0;
            int realLineCounter = 0;
            bool isPerformable = false;
            List<Tuple<int, string>> test = compiler.getRealLine();
            List<CustomError> compilerErrors = compiler.GetErrors();
            jf.Explanation explanation = compiler.getExplanationSymbolTable();
            List<Tuple<int, string>> realLines = compiler.getRealLine();
            Stack<int> loopCount = new Stack<int>();
            Stack<bool> loopStarted = new Stack<bool>();
            Stack<int> loopIndex = new Stack<int>();
            Stack<int> loopEndIndex = new Stack<int>();
            bool loopSeen = false;

            if(compilerErrors.Count > 0)
            {
                errorDetected = true;
            }

            foreach(CustomError error in compilerErrors)
            {
                this.commands.Enqueue(new Command("highlight", error.getLineNumber(), this.RED));
                this.commands.Enqueue(new Command("test", "testtttt" + error.getMessage() + "\n"));
            }
            while (!errorDetected)
            {
                if (realLines[realLineCounter].Item2.ToLower() == "begin")
                {
                    this.commands.Enqueue(new Command("highlight", realLineCounter, this.GREEN));
                    isPerformable = true;
                    realLineCounter++;
                    break;
                }
                if(realLines[realLineCounter].Item2 == "")
                {
                    this.commands.Enqueue(new Command("highlight", realLineCounter, this.GREEN));
                    realLineCounter++;
                    continue;
                }
                if (this.commands.Count == 0 && !isPerformable)
                {
                    switch (explanation.st.table[lineCounter][0].ToLower())
                    {
                        case "jf122":
                            this.commands.Enqueue(new Command("highlight", realLineCounter, this.GREEN));
                            lineCounter++;
                            realLineCounter++;
                            break;
                        case "code":
                            this.commands.Enqueue(new Command("highlight", realLineCounter, this.GREEN));
                            lineCounter++;
                            realLineCounter++;
                            break;
                        case "mode":
                            this.commands.Enqueue(new Command("highlight", realLineCounter, this.GREEN));
                            this.writeCommandToFile("mode " + explanation.st.table[lineCounter][1]);
                            lineCounter++;
                            realLineCounter++;
                            break;
                        case "r0":
                            this.commands.Enqueue(new Command("highlight", realLineCounter, this.GREEN));
                            this.commands.Enqueue(new Command("set", explanation.st.table[lineCounter][1]));
                            this.writeCommandToFile("r0 " + explanation.st.table[lineCounter][1]);
                            lineCounter++;
                            realLineCounter++;
                            break;
                        case "i":
                            this.commands.Enqueue(new Command("highlight", realLineCounter, this.GREEN));
                            this.writeCommandToFile("i " + explanation.st.table[lineCounter][1]);
                            lineCounter++;
                            realLineCounter++;
                            break;
                        case "kmu":
                            this.commands.Enqueue(new Command("highlight", realLineCounter, this.GREEN));
                            this.writeCommandToFile("kmu " + explanation.st.table[lineCounter][1]);
                            lineCounter++;
                            realLineCounter++;
                            break;
                        case "data":
                            this.commands.Enqueue(new Command("highlight", realLineCounter, this.GREEN));
                            lineCounter++;
                            realLineCounter++;
                            break;
                    }
                }
            }


            if (isPerformable)
            {
                List<Tuple<string, List<double>>> constants = compiler.getConstants();
                List<Tuple<string, double>> variables = compiler.getVariables();
                List<double> data = null;
                int indexOfData = 0;
                jf.Node root = this.compiler.getPerformableTableRoot();
                Stack parentStack = new Stack();
                Stack parentIndexStack = new Stack();
                Node current = null;
                int index = 0;
                parentIndexStack.Push(0);
                parentStack.Push(root);
                while (!errorDetected)
                {
                    if (loopSeen && loopStarted.Peek() == true)
                    {
                        index = loopIndex.Peek();
                        loopSeen = false;
                    }
                    else
                    {
                        index = (int)parentIndexStack.Peek();
                    }

                    Node temp = (Node)parentStack.Peek();
                    if (index > temp.child.Count - 1)
                    {
                        break;
                    }

                    current = temp.child[index];
                    
                    switch (current.identifier.ToLower())
                    {
                        case "begin":
                            this.commands.Enqueue(new Command("highlight", realLineCounter, this.GREEN));
                            break;
                        case "var":
                            this.commands.Enqueue(new Command("highlight", realLineCounter, this.GREEN));
                            realLineCounter++;
                            break;
                        case "read":
                            if (data == null)
                            {
                                data = this.findData(constants);
                            }
                            if(data == null)
                            {
                                // TODO: add cross mark in UI
                                this.commands.Enqueue(new Command("highlight error", realLineCounter, this.RED));
                                errorDetected = true;
                                break;
                            }
                            if (indexOfData > data.Count) indexOfData--;
                            this.findVariableAndChangeValue(variables, current.attribute, data[indexOfData]);
                            this.commands.Enqueue(new Command("highlight", realLineCounter, this.GREEN));
                            // TODO: test commands should delete
                            this.commands.Enqueue(new Command("test", "testtttt" + data[indexOfData].ToString() + "\n"));
                            indexOfData++;
                            realLineCounter++;
                            break;
                        case "restore":
                            this.commands.Enqueue(new Command("highlight", realLineCounter, this.GREEN));
                            indexOfData = 0;
                            realLineCounter++;
                            break;
                        case "add":
                            double test1 = 0;
                            this.commands.Enqueue(new Command("highlight", realLineCounter, this.GREEN));
                            realLineCounter++;
                            string[] temp1 = current.attribute.Split(',');
                            double newValue = 0;
                            if (double.TryParse(temp1[1], out newValue))
                            {
                                test1 = newValue + this.findVariable(variables, temp1[0]);
                                this.findVariableAndChangeValue(variables, temp1[0], test1);
                                // TODO: test commands should delete
                                this.commands.Enqueue(new Command("test", "testtttt" + test1 + "\n"));
                            }
                            else
                            {
                                test1 = this.findVariable(variables, temp1[1]) + this.findVariable(variables, temp1[0]);
                                this.findVariableAndChangeValue(variables, temp1[0], test1);
                                // TODO: test commands should delete
                                this.commands.Enqueue(new Command("test", "testtttt" + test1 + "\n"));
                            }
                            break;
                        case "set":
                            this.commands.Enqueue(new Command("highlight", realLineCounter, this.GREEN));
                            this.writeCommandToFile("set " + current.attribute);
                            // TODO: we should complete it later
                            realLineCounter++;
                            break;
                        case "turn":
                            this.commands.Enqueue(new Command("highlight", realLineCounter, this.GREEN));
                            this.writeCommandToFile("turn " + current.attribute);
                            realLineCounter++;
                            break;
                        case "fan":
                            this.commands.Enqueue(new Command("highlight", realLineCounter, this.GREEN));
                            this.writeCommandToFile("fan " + current.attribute);
                            realLineCounter++;
                            break;
                        case "speed":
                            this.commands.Enqueue(new Command("highlight", realLineCounter, this.GREEN));
                            this.writeCommandToFile("speed " + current.attribute);
                            // TODO: command increase speed and reed speed sensor till condition satisfied. if c is exist speed should keep on condition 
                            // else turn off motor
                            realLineCounter++;
                            if(loopEndIndex.Count != 0)
                            {
                                    realLineCounter--;
                            }
                            break;
                        case "wait":
                            this.commands.Enqueue(new Command("highlight", realLineCounter, this.GREEN));
                            this.writeCommandToFile("wait " + current.attribute);
                            // TODO: command should pause the runner till condtion satisfied. condition is about time or temprture sensor.
                            realLineCounter++;
                            if (loopEndIndex.Count != 0)
                            {
                                    realLineCounter--;
                            }
                            break;
                        case "brake":
                            this.commands.Enqueue(new Command("highlight", realLineCounter, this.GREEN));
                            this.writeCommandToFile("brake " + current.attribute);
                            // TODO: command should brake for time or n condition. p or m in command should the level of 
                            realLineCounter++;
                            if (loopEndIndex.Count != 0)
                            {
                                    realLineCounter--;
                            }
                            break;
                        case "loop":
                            this.commands.Enqueue(new Command("highlight", realLineCounter, this.GREEN));
                            // TODO: we should complete it later
                            // TODO: check error handler in compiler for LOOP. LOOP should have attribute
                            loopCount.Push(Int32.Parse(current.attribute));
                            loopStarted.Push(true);
                            loopIndex.Push(0);
                            realLineCounter++;
                            loopSeen = true;
                            break;
                        case "lend":
                            this.commands.Enqueue(new Command("highlight", realLineCounter, this.GREEN));
                            // TODO: we should complete it later, there is 4 kind of loop. type 1 is done
                            int currentLoopRepeat = loopCount.Pop();
                            if (loopEndIndex.Count == 0)
                            {
                                loopEndIndex.Push(index);
                            }
                            else
                            {
                                if(loopEndIndex.Peek() != index)
                                {
                                    loopEndIndex.Push(index);
                                }
                            }
                            currentLoopRepeat--;
                            if(currentLoopRepeat <= 0)
                            {
                                loopStarted.Pop();
                                loopStarted.Push(false);
                                loopSeen = false;
                                parentStack.Pop();
                                parentIndexStack.Pop();
                                index = (int)parentIndexStack.Peek();
                                temp = (Node)parentStack.Peek();
                                loopEndIndex.Pop();
                                realLineCounter++;
                                break;
                            }
                            else
                            {
                                current = (Node)parentStack.Peek();
                                current = current.child[0];
                                loopCount.Push(currentLoopRepeat);
                                loopSeen = true;
                            }
                            break;
                        case "end":
                            this.commands.Enqueue(new Command("highlight", realLineCounter, this.GREEN));
                            this.writeCommandToFile("end!!!");
                            realLineCounter++;
                            break;
                    }
                    while (true)
                    {
                        if(realLineCounter >= realLines.Count)
                        {
                            errorDetected = true;
                            break;
                        }
                        if (realLines[realLineCounter].Item2 == "")
                        {
                            this.commands.Enqueue(new Command("highlight", realLineCounter, this.GREEN));
                            realLineCounter++;
                        }
                        else break;
                    }
                    if (current.child.Count > 0)
                    {
                        parentStack.Push(current);
                        parentIndexStack.Push(0);
                        continue;
                    }
                    if (loopStarted.Count > 0)
                    {
                        if (loopStarted.Peek() == true)
                        {
                            if(loopEndIndex.Count <= 0)
                            {
                                index++;
                                parentIndexStack.Pop();
                                parentIndexStack.Push(index);
                                continue;
                            }
                            if (index <= loopEndIndex.Peek())
                            {
                                index++;
                                parentIndexStack.Pop();
                                parentIndexStack.Push(index);
                                continue;
                            }
                        }
                    }
                    if (index < temp.child.Count)
                    {
                        index++;
                        parentIndexStack.Pop();
                        parentIndexStack.Push(index);
                        continue;
                    }
                    else
                    {
                        if (temp == root)
                        {
                            break;
                        }
                        int tempIndex = (int)parentIndexStack.Pop();
                        tempIndex++;
                        parentStack.Pop();
                        parentIndexStack.Pop();
                        parentIndexStack.Push(tempIndex);
                    }
                }
            }
        }
    }
}
