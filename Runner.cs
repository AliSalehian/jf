using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace jf
{
    class Runner
    {
        jf.Compiler compiler;
        Queue<string> commandsQueue;

        public Runner(jf.Compiler compiler, Queue<string> commandsQueue)
        {
            this.compiler = compiler;
            this.commandsQueue = commandsQueue;
        }
        public void run()
        {
            int lineCounter = 0;
            const string commandFilePath = "../../board/commands.txt";
            List<Tuple<int, string>> test = compiler.getRealLine();
            using (StreamWriter sw = new StreamWriter(commandFilePath))
            {
                jf.Node root = this.compiler.getPerformableTableRoot();
                Stack parentStack = new Stack();
                Stack parentIndexStack = new Stack();
                Node current = null;
                int index;
                parentIndexStack.Push(0);
                parentStack.Push(root);
                while (true)
                {
                    index = (int)parentIndexStack.Peek();
                    Node temp = (Node)parentStack.Peek();
                    if (index > temp.child.Count - 1)
                    {
                        break;
                    }
                    current = temp.child[index];

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

            while(lineCounter < 10)
            {
                commandsQueue.Enqueue(lineCounter.ToString() + "\n");
                System.Threading.Thread.Sleep(2000);
                lineCounter++;
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
