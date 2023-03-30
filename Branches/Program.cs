using System;
using System.Collections.Generic;
namespace Branches
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Branch head = new Branch { name = "Head" };
            Branch root = new Branch { name = "Root" };
            Branch child1 = new Branch { name = "Child1" };
            Branch child2 = new Branch { name = "Child2" };
            Branch grandchild1 = new Branch { name = "Grandchild1" };
            Branch grandchild2 = new Branch { name = "Grandchild2" };
            Branch grandchild3 = new Branch { name = "Grandchild3" };
            Branch grandchild4 = new Branch { name = "Grandchild4" };
            Branch greatGrandchild1 = new Branch { name = "GreatGrandchild1" };
            Branch greatGrandchild2 = new Branch { name = "GreatGrandchild2" };
            Branch greatGrandchild3 = new Branch { name = "GreatGrandchild3" };
            Branch greatgreatGrandchild1 = new Branch { name = "GreatgreatGrandchild1" };

            root.branches.Add(child1);
            root.branches.Add(child2);
            child1.branches.Add(grandchild1);
            child2.branches.Add(grandchild2);
            child2.branches.Add(grandchild3);
            child2.branches.Add(grandchild4);
            grandchild1.branches.Add(greatGrandchild1);
            grandchild2.branches.Add(greatGrandchild2);
            grandchild2.branches.Add(greatGrandchild3);
            greatGrandchild2.branches.Add(greatgreatGrandchild1);
            
                
            

            int depth = CalculateDepth(root);
            Console.WriteLine("Depth of the structure: " + depth);
        }
        public static int CalculateDepth(Branch branch, int depth = 0)
        {
            if (branch.branches.Count == 0)
            {
                return depth;
            }
            else
            {
                int maxChildDepth = 0;
                foreach (Branch child in branch.branches)
                {
                    int childDepth = CalculateDepth(child, depth + 1);
                    if (childDepth > maxChildDepth)
                    {
                        maxChildDepth = childDepth;
                    }
                }
                return maxChildDepth;
            }
        }
    }
    class Branch
    {
        public string name;
        public List<Branch> branches = new List<Branch>();
    }
}