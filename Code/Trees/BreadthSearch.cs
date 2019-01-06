using System;
using System.Collections.Generic;
using System.Text;

namespace Code.Trees
{
    public static class BreadthSearch
    {

        //F B G A D I C E H
        public static void BreadthFirstSearch(TreeNode node, Queue<TreeNode> q)
        {
            if (node == null)
                return;


            //Print(node);
            q.Enqueue(node);

            while (q.Count > 0)
            {
                var extracted = q.Dequeue();

                NodeHelper.Print(extracted);

                var l = extracted.LeftNode;
                var r = extracted.RightNode;
                if (l != null)
                    q.Enqueue(l);

                if (r != null)
                    q.Enqueue(r);

            }

        }

        //C E H A D I B G F
        public static void BreadthFirstSearch_BottomTopLeftRight(TreeNode node, Queue<TreeNode> q, Stack<TreeNode> s)
        {
            if (node == null)
                return;


            //Print(node);
            q.Enqueue(node);

            while (q.Count > 0)
            {
                var extracted = q.Dequeue();

                s.Push(extracted);
                //Print(extracted);

                var l = extracted.LeftNode;
                var r = extracted.RightNode;


                if (r != null)
                    q.Enqueue(r);

                if (l != null)
                    q.Enqueue(l);


            }

            while (s.Count > 0)
            {
                Console.Write((string)s.Pop().UsefulContent + " ");
            }
        }
    }
}
