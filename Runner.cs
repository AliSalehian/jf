using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using System.Drawing;

namespace jf
{
    class Runner
    {
        jf.Compiler compiler;
        Queue<jf.Command> commands;
        Color GREEN = Color.FromArgb(0x4c, 0xe6, 0x00); //#4ce600

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
            jf.Explanation explanation = compiler.getExplanationSymbolTable();
            List<Tuple<int, string>> realLines = compiler.getRealLine();
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
                            //commands.Enqueue(new Command("highlight", lineCounter, Color.FromArgb(0x4c, 0xe6, 0x00)));
                            this.commands.Enqueue(new Command("highlight", realLineCounter, this.GREEN));
                            lineCounter++;
                            realLineCounter++;
                            break;
                        case "code":
                            //commands.Enqueue(new Command("highlight", lineCounter, Color.FromArgb(0x4c, 0xe6, 0x00)));
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
                int index;
                parentIndexStack.Push(0);
                parentStack.Push(root);
                while (!errorDetected)
                {
                    index = (int)parentIndexStack.Peek();
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
                                this.commands.Enqueue(new Command("highlight", realLineCounter, Color.Red));
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
                        }


                    //sw.WriteLine(current.realLine.ToString() + "    " + current.identifier + " " + current.attribute);
                    if (current.child.Count > 0)
                    {
                        parentStack.Push(current);
                        parentIndexStack.Push(0);
                        continue;
                    }
                    if (index + 1 < temp.child.Count)
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
            /*try
            {
                using (StreamReader sr = new StreamReader(commandFilePath))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        totalFile += line + "\n";
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
                return "Exception: " + e.Message;
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }*/
            //return totalFile;
        }
    }
}
