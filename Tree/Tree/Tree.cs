using System;
using System.Collections.Generic;
using System.Text;

namespace TreeStruct
{
   
    public class TreeNode<T>
    {
        public TreeNode<T> leftChild;
        public TreeNode<T> rightSibling;
        public T data;
    }
    public class Tree<T> where T : new ()
    {
        
        public Tree(){}
        public void AddChildNode(TreeNode<T> parent, TreeNode<T> child)
        {
            if (parent.leftChild == null)
            {
                parent.leftChild = child;
            }
            else
            {
                TreeNode<T> tempNode = parent.leftChild;
                while (tempNode.rightSibling != null)
                {
                    tempNode = tempNode.rightSibling;
                }
                tempNode.rightSibling = child;
            }
        }
        public TreeNode<T> CreateNode(T input)
        {
            TreeNode<T> newTree = new TreeNode<T>();
            newTree.leftChild = null;
            newTree.rightSibling = null;
            newTree.data = input;
            return newTree;
        }
        public void PrintNode(TreeNode<T> parent, int depth)
        {
            for (int i = 0;i < depth;i++)
            {
                Console.Write("-");
            }
            Console.WriteLine($"{parent.data.ToString()}");
            if (parent.leftChild !=null)
            {
                PrintNode(parent.leftChild, depth + 1);
            }
            if (parent.rightSibling != null)
            {
                PrintNode(parent.rightSibling, depth);
            }
            
        }
    }

}
