using System;

namespace TreeStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree<int> tree = new Tree<int>();
            TreeNode<int> root = tree.CreateNode(0);
            TreeNode<int> a1 = tree.CreateNode(1);
            TreeNode<int> a2 = tree.CreateNode(2);
            TreeNode<int> a3 = tree.CreateNode(3);
            TreeNode<int> a4 = tree.CreateNode(4);
            TreeNode<int> b1 = tree.CreateNode(5);
            TreeNode<int> b2 = tree.CreateNode(6);
            TreeNode<int> c1 = tree.CreateNode(7);
            TreeNode<int> c2 = tree.CreateNode(8);
            tree.AddChildNode(root, a1);
            tree.AddChildNode(root, a2);
            tree.AddChildNode(root, a3);
            tree.AddChildNode(root, a4);

            tree.AddChildNode(a1, b1);
            tree.AddChildNode(a2, b2);
            tree.AddChildNode(b1, c1);
            tree.AddChildNode(b1, c2);
            tree.PrintNode(root,0);
        }
    }
}
