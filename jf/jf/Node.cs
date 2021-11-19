using System;
using System.Collections.Generic;
using System.Collections;

namespace jf
{
    class Node
    {
        public string identifier;
        public string attribute;
        public List<Node> child;
        public Node parent;

        public Node(string identifier, string attribute)
        {
            this.identifier = identifier;
            this.attribute = attribute;
            this.child = new List<Node>();
            this.parent = null;
        }

        public static void printTree(Node root)
        {
            Stack parentStack =  new Stack();
            Stack parentIndexStack = new Stack();
            Node current = null;
            int index;
            parentIndexStack.Push(0);
            parentStack.Push(root);
            Console.WriteLine("root of tree is {0} | {1}", root.identifier, root.attribute);
            while (true)
            {
                index = (int)parentIndexStack.Peek();
                Node temp = (Node)parentStack.Peek();
                if (index > temp.child.Count-1)
                {
                    break;
                }
                current = temp.child[index];
                Console.WriteLine("node number {0} is {1} | {2}", index, current.identifier, current.attribute);
                if(current.child.Count > 0)
                {
                    parentStack.Push(current);
                    parentIndexStack.Push(0);
                    continue;
                }
                if(index + 1 < temp.child.Count)
                {
                    index++;
                    parentIndexStack.Pop();
                    parentIndexStack.Push(index);
                    continue;
                }
                else
                {
                    if(temp == root)
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
