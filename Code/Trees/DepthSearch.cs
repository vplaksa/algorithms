using System;
using System.Collections.Generic;
using System.Text;

namespace Code.Trees
{
    public static class DepthSearch
    {
        //F B A D C E G I H
        public static void DepthPreOrderNLR(TreeNode node)
        {
            if (node == null)
                return;
            Console.Write((string)node.UsefulContent + " "); //N
            DepthPreOrderNLR(node.LeftNode); //L
            DepthPreOrderNLR(node.RightNode); //R 
            //if L, then R, it is called left to right traversing, otherwise right to left;
        }

        //A B C D E F G H I
        public static void DepthInOrderLNR(TreeNode node)
        {
            if (node == null)
                return;

            DepthInOrderLNR(node.LeftNode); //L
            Console.Write((string)node.UsefulContent + " "); //on maximum depth, if no leaves found, print content
            DepthInOrderLNR(node.RightNode); //R
        }

        public static void DepthPostOrderLRN(TreeNode node)
        {
            if (node == null)
                return;

            DepthPostOrderLRN(node.LeftNode); //L
            DepthPostOrderLRN(node.RightNode); //R
            Console.Write((string)node.UsefulContent + " "); //on maximum depth, if no leaves found, print content
        }

    }
}
