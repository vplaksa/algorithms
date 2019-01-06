using System;
using System.Collections.Generic;
using System.Text;

namespace Code.Trees
{
    public static class NodeHelper
    {
        public static void Print(TreeNode node)
        {
            var val = (string)node?.UsefulContent;
            if (val != null)
                Console.Write(val + " ");
        }
    }
}
