using System;
using System.Collections.Generic;
using System.Text;

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
            List<Node> stack = new List<Node>();
            List<int> indexStack = new List<int>();
            Node current = null;
            int index;
            indexStack.Add(0);
            stack.Add(root);
            Console.WriteLine("root of tree is {0} | {1}", root.identifier, root.attribute);
            while (true)
            {
                index = indexStack[indexStack.Count - 1];
                if (index > stack[stack.Count - 1].child.Count-1)
                {
                    break;
                }
                current = stack[stack.Count - 1].child[index];
                Console.WriteLine("node number {0} is {1} | {2}", index, current.identifier, current.attribute);
                if(current.child.Count > 0)
                {
                    stack.Add(current);
                    indexStack.Add(0);
                    continue;
                }
                if(index + 1 < stack[stack.Count - 1].child.Count)
                {
                    index++;
                    indexStack[indexStack.Count - 1]++;
                    continue;
                }
                else
                {
                    if(stack[stack.Count - 1] == root)
                    {
                        break;
                    }
                    stack.RemoveAt(stack.Count - 1);
                    indexStack.RemoveAt(indexStack.Count - 1);
                    indexStack[indexStack.Count - 1]++;
                }
            }
        }
    }
}
