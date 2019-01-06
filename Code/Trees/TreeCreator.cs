using System;
using System.Collections.Generic;
using System.Text;

namespace Code.Trees
{
    public static class TreeCreator
    {
        public static TreeNode CreateTree()
        {
            var root = new TreeNode();
            root.UsefulContent = "F";
            //left subtree
            var b = new TreeNode();
            b.UsefulContent = "B";

            var a = new TreeNode();
            a.UsefulContent = "A";

            var d = new TreeNode();
            d.UsefulContent = "D";

            var c = new TreeNode();
            c.UsefulContent = "C";

            var e = new TreeNode();
            e.UsefulContent = "E";

            root.LeftNode = b;
            b.LeftNode = a; b.RightNode = d;
            d.LeftNode = c; d.RightNode = e;

            //right subtree
            var g = new TreeNode();
            g.UsefulContent = "G";

            var i = new TreeNode();
            i.UsefulContent = "I";

            var h = new TreeNode();
            h.UsefulContent = "H";

            root.RightNode = g;
            g.RightNode = i;
            i.LeftNode = h;

            return root;
        }
    }
}
