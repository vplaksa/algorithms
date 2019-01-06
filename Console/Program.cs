using System;
using Code;
using Code.Trees;
using System.Collections.Generic;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = TreeCreator.CreateTree();
            //DepthPreOrderNLR(t);
            //DepthInOrderLNR(t);
            //DepthPostOrderLRN(t);

            var q = new Queue<TreeNode>();
            BreadthSearch.BreadthFirstSearch_BottomTopLeftRight(t, q, new Stack<TreeNode>());
            System.Console.WriteLine();
            System.Console.WriteLine("Program end.");
            System.Console.Read();


        }
    }
}
