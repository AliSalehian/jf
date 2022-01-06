using System;
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
        SensorHandler sensorHandler;
        Color GREEN = Color.FromArgb(0x4c, 0xe6, 0x00); // #4ce600
        Color RED = Color.FromArgb(0xff, 0x5c, 0x33); // #ff5c33
        Color ORANGE = Color.FromArgb(0xff, 0xcc, 0x00);

        public Runner(jf.Compiler compiler, Queue<jf.Command> commands, SensorHandler sensorHandler)
        {
            this.compiler = compiler;
            this.commands = commands;
            this.sensorHandler = sensorHandler;
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

        public bool checkCondition(string condition, List<Tuple<string, double>> variables)
        {
            string operand1;
            string operand2;
            string comparisionOperator = "";
            double valueOfOperand1;
            double valueOfOperand2;
            if (condition.Contains("<=")){
                comparisionOperator = "<=";
            }else if (condition.Contains(">="))
            {
                comparisionOperator = ">=";
            }else if (condition.Contains("="))
            {
                comparisionOperator = "=";
            }else if (condition.Contains(">"))
            {
                comparisionOperator = ">";
            }else if (condition.Contains("<"))
            {
                comparisionOperator= "<";
            }
            string[] temp = condition.Split(new string[] { comparisionOperator }, StringSplitOptions.None);
            operand1 = temp[0].Trim();
            operand2 = temp[1].Trim();
            if (double.TryParse(operand1, out valueOfOperand1) == true)
            {
                valueOfOperand1 = double.Parse(operand1);
            }
            else
            {
                if (this.sensorHandler.checkSensorExist(operand1))
                {
                    valueOfOperand1 = this.sensorHandler.getSensor(operand1);
                }else
                {
                    valueOfOperand1 = this.findVariable(variables, operand1);
                }
            }


            if (double.TryParse(operand2, out valueOfOperand2) == true)
            {
                valueOfOperand2 = double.Parse(operand2);
            }
            else
            {
                if (this.sensorHandler.checkSensorExist(operand2))
                {
                    valueOfOperand2 = this.sensorHandler.getSensor(operand2);
                }
                else
                {
                    valueOfOperand2 = this.findVariable(variables, operand2);
                }
            }

            switch (comparisionOperator)
            {
                case "<":
                    return valueOfOperand1 < valueOfOperand2;
                case ">":
                    return valueOfOperand1 > valueOfOperand2;
                case "=":
                    return valueOfOperand1 == valueOfOperand2;
                case "<=":
                    return valueOfOperand1 <= valueOfOperand2;
                case ">=":
                    return valueOfOperand2 >= valueOfOperand1;
            }
            return false;
        }

        public void run()
        {
            bool errorDetected = false;
            int lineCounter = 0;
            int realLineCounter = 0;
            bool isPerformable = false;
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
                DateTime start = DateTime.Now;
                DateTime end = DateTime.Now;
                Stack<bool> ifConditionSatisfied = new Stack<bool>();
                ifConditionSatisfied.Push(true);
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
                            if (ifConditionSatisfied.Peek())
                            {
                                this.commands.Enqueue(new Command("highlight", realLineCounter, this.GREEN));
                                realLineCounter++;
                            }
                            else
                            {
                                this.commands.Enqueue(new Command("highlight", realLineCounter, this.ORANGE));
                                realLineCounter++;
                            }
                            break;
                        case "read":
                            if (ifConditionSatisfied.Peek())
                            {
                                if (data == null)
                                {
                                    data = this.findData(constants);
                                }
                                if (data == null)
                                {
                                    // TODO: add cross mark in UI
                                    this.commands.Enqueue(new Command("highlight error", realLineCounter, this.RED));
                                    errorDetected = true;
                                    break;
                                }
                                if (indexOfData > data.Count) indexOfData--;
                                this.findVariableAndChangeValue(variables, current.attribute, data[indexOfData]);
                                this.commands.Enqueue(new Command("highlight", realLineCounter, this.GREEN));
                                indexOfData++;
                                realLineCounter++;
                            }
                            else
                            {
                                this.commands.Enqueue(new Command("highlight", realLineCounter, this.ORANGE));
                                realLineCounter++;
                            }
                            break;
                        case "restore":
                            if (ifConditionSatisfied.Peek())
                            {
                                this.commands.Enqueue(new Command("highlight", realLineCounter, this.GREEN));
                                indexOfData = 0;
                                realLineCounter++;
                            }
                            else
                            {
                                this.commands.Enqueue(new Command("highlight", realLineCounter, this.ORANGE));
                                realLineCounter++;
                            }
                            break;
                        case "add":
                            if (ifConditionSatisfied.Peek())
                            {
                                double test1 = 0;
                                this.commands.Enqueue(new Command("highlight", realLineCounter, this.GREEN));
                                realLineCounter++;
                                string[] temp1 = current.attribute.Split(',');
                                double newValue = 0;
                                if (double.TryParse(temp1[1], out newValue))
                                {
                                    test1 = newValue + this.findVariable(variables, temp1[0]);
                                    this.findVariableAndChangeValue(variables, temp1[0], test1);
                                }
                                else
                                {
                                    test1 = this.findVariable(variables, temp1[1]) + this.findVariable(variables, temp1[0]);
                                    this.findVariableAndChangeValue(variables, temp1[0], test1);
                                }
                            }
                            else
                            {
                                this.commands.Enqueue(new Command("highlight", realLineCounter, this.ORANGE));
                                realLineCounter++;
                            }
                            break;
                        case "set":
                            if (ifConditionSatisfied.Peek())
                            {
                                this.commands.Enqueue(new Command("highlight", realLineCounter, this.GREEN));
                                this.writeCommandToFile("set " + current.attribute);
                                // TODO: we should complete it later
                                realLineCounter++;
                            }
                            else
                            {
                                this.commands.Enqueue(new Command("highlight", realLineCounter, this.ORANGE));
                                realLineCounter++;
                            }
                            break;
                        case "turn":
                            if (ifConditionSatisfied.Peek())
                            {
                                this.commands.Enqueue(new Command("highlight", realLineCounter, this.GREEN));
                                this.writeCommandToFile("turn " + current.attribute);
                                realLineCounter++;
                            }
                            else
                            {
                                this.commands.Enqueue(new Command("highlight", realLineCounter, this.ORANGE));
                                realLineCounter++;
                            }
                            break;
                        case "fan":
                            if (ifConditionSatisfied.Peek())
                            {
                                this.commands.Enqueue(new Command("highlight", realLineCounter, this.GREEN));
                                this.writeCommandToFile("fan " + current.attribute);
                                realLineCounter++;
                            }
                            else
                            {
                                this.commands.Enqueue(new Command("highlight", realLineCounter, this.ORANGE));
                                realLineCounter++;
                            }
                            break;
                        case "speed":
                            if (ifConditionSatisfied.Peek())
                            {
                                this.commands.Enqueue(new Command("highlight", realLineCounter, this.GREEN));
                                this.writeCommandToFile("speed " + current.attribute);
                                // TODO: command increase speed and reed speed sensor till condition satisfied. if c is exist speed should keep on condition 
                                // else turn off motor
                                realLineCounter++;
                                if (loopEndIndex.Count != 0)
                                {
                                    realLineCounter--;
                                }
                            }
                            else
                            {
                                this.commands.Enqueue(new Command("highlight", realLineCounter, this.ORANGE));
                                realLineCounter++;
                            }
                            break;
                        case "wait":
                            if (ifConditionSatisfied.Peek())
                            {
                                this.commands.Enqueue(new Command("highlight", realLineCounter, this.GREEN));
                                if (this.checkCondition(current.attribute, variables))
                                {
                                    this.writeCommandToFile("wait condiotion satisfied");
                                }
                                else
                                {
                                    this.writeCommandToFile("wait condiotion didnt satisfied and runner waited");
                                    while (true)
                                    {
                                        if (this.checkCondition(current.attribute, variables))
                                        {
                                            break;
                                        }
                                    }
                                }
                                realLineCounter++;
                                if (loopEndIndex.Count != 0)
                                {
                                    realLineCounter--;
                                }
                            }
                            else
                            {
                                this.commands.Enqueue(new Command("highlight", realLineCounter, this.ORANGE));
                                realLineCounter++;
                            }
                            break;
                        case "brake":
                            if (ifConditionSatisfied.Peek())
                            {
                                this.commands.Enqueue(new Command("highlight", realLineCounter, this.GREEN));
                                // TODO: command should log if r flag seted
                                string condition = current.attribute.Split(',')[1].Replace("UNTIL", "");
                                string presure = current.attribute.Split(',')[0];
                                while (true)
                                {
                                    if (this.checkCondition(condition, variables))
                                    {
                                        break;
                                    }
                                    this.writeCommandToFile("brake presure: " + presure);
                                }
                                realLineCounter++;
                                if (loopEndIndex.Count != 0)
                                {
                                    realLineCounter--;
                                }
                            }
                            else
                            {
                                this.commands.Enqueue(new Command("highlight", realLineCounter, this.ORANGE));
                                realLineCounter++;
                            }
                            break;
                        case "loop":
                            if (ifConditionSatisfied.Peek())
                            {
                                this.commands.Enqueue(new Command("highlight", realLineCounter, this.GREEN));
                                // TODO: check error handler in compiler for LOOP. LOOP should have attribute
                                loopCount.Push(Int32.Parse(current.attribute));
                                loopStarted.Push(true);
                                loopIndex.Push(0);
                                loopSeen = true;
                                start = DateTime.Now;
                                realLineCounter++;
                            }
                            else
                            {
                                this.commands.Enqueue(new Command("highlight", realLineCounter, this.ORANGE));
                                realLineCounter++;
                            }
                            break;
                        case "lend":
                            if (ifConditionSatisfied.Peek())
                            {
                                this.commands.Enqueue(new Command("highlight", realLineCounter, this.GREEN));
                                bool conditionStisfied = true;
                                string LoopCondition = "";
                                int validDuration = 0;
                                if (current.attribute.Contains(","))
                                {
                                    LoopCondition = current.attribute.Split(',')[1].ToLower().Replace("while", "");
                                    conditionStisfied = this.checkCondition(LoopCondition, variables);
                                    if (Int32.TryParse(current.attribute.Split(',')[0], out validDuration))
                                    {
                                        validDuration = Int32.Parse(current.attribute.Split(',')[0]);
                                    }
                                    while (true)
                                    {
                                        end = DateTime.Now;
                                        TimeSpan loopDuration = end - start;
                                        if (validDuration + 1 <= loopDuration.TotalSeconds)
                                        {
                                            this.writeCommandToFile("WARNING > valid duration is: " + validDuration + " but loop duration is: " + loopDuration.TotalSeconds + " s");
                                            break;
                                        }
                                        else if (validDuration <= loopDuration.TotalSeconds)
                                        {
                                            break;
                                        }
                                    }
                                }
                                else if (current.attribute.ToLower().Contains("while"))
                                {
                                    LoopCondition = current.attribute.ToLower().Replace("while", "");
                                    conditionStisfied = this.checkCondition(LoopCondition, variables);
                                }
                                else if (current.attribute.Length > 0)
                                {
                                    if (Int32.TryParse(current.attribute, out validDuration))
                                    {
                                        validDuration = Int32.Parse(current.attribute);
                                    }
                                    while (true)
                                    {
                                        end = DateTime.Now;
                                        TimeSpan loopDuration = end - start;
                                        if (validDuration + 1 <= loopDuration.TotalSeconds)
                                        {
                                            this.writeCommandToFile("WARNING > valid duration is: " + validDuration + " but loop duration is: " + loopDuration.TotalSeconds + " s");
                                            break;
                                        }
                                        else if (validDuration <= loopDuration.TotalSeconds)
                                        {
                                            break;
                                        }
                                    }
                                }
                                int currentLoopRepeat = loopCount.Pop();
                                if (loopEndIndex.Count == 0 && conditionStisfied)
                                {
                                    loopEndIndex.Push(index);
                                }
                                else if (loopEndIndex.Count != 0 && conditionStisfied)
                                {
                                    if (loopEndIndex.Peek() != index)
                                    {
                                        loopEndIndex.Push(index);
                                    }
                                }
                                currentLoopRepeat--;
                                if (currentLoopRepeat <= 0 || !conditionStisfied)
                                {
                                    if (!conditionStisfied)
                                    {
                                        this.writeCommandToFile("while condition didnt satisfied!!!");
                                    }
                                    loopStarted.Pop();
                                    loopStarted.Push(false);
                                    loopSeen = false;
                                    parentStack.Pop();
                                    parentIndexStack.Pop();
                                    index = (int)parentIndexStack.Peek();
                                    temp = (Node)parentStack.Peek();
                                    if (loopEndIndex.Count != 0)
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
                            }
                            else
                            {
                                this.commands.Enqueue(new Command("highlight", realLineCounter, this.ORANGE));
                                realLineCounter++;
                            }
                            break;
                        case "end":
                            this.commands.Enqueue(new Command("highlight", realLineCounter, this.GREEN));
                            this.writeCommandToFile("end!!!");
                            realLineCounter++;
                            break;
                        case "if":
                            this.commands.Enqueue(new Command("highlight", realLineCounter, this.GREEN));
                            ifConditionSatisfied.Push(this.checkCondition(current.attribute, variables));
                            realLineCounter++;
                            break;
                        case "endif":
                            this.commands.Enqueue(new Command("highlight", realLineCounter, this.GREEN));
                            ifConditionSatisfied.Pop();
                            index++;
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
                        parentIndexStack.Pop();
                        int tempIndex = (int)parentIndexStack.Pop();
                        tempIndex++;
                        parentStack.Pop();
                        parentIndexStack.Push(tempIndex);
                    }
                }
            }
        }
    }
}
