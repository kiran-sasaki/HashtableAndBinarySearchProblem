using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableAndBinarySearchProblem
{
    //Creating a Class For BinarySearchTree
    public class MyBinaryNode<T> where T : IComparable<T>
    {
        public T NodeData { get; set; }
        public MyBinaryNode<T> LeftTree { get; set; }
        public MyBinaryNode<T> RightTree { get; set; }
        public MyBinaryNode(T nodeData)
        {
            this.NodeData = nodeData;
            this.LeftTree = null;
            this.RightTree = null;
        }
        int leftcount = 0, rightcount = 0;
        bool result = false;
        public void Add(T item)
        {
            T currentNodeValue = this.NodeData;
            if ((currentNodeValue.CompareTo(item)) > 0)
            {
                if (this.LeftTree == null)
                    this.LeftTree = new MyBinaryNode<T>(item);
                else
                    this.LeftTree.Add(item);
            }
            else
            {
                if (this.RightTree == null)
                {
                    this.RightTree = new MyBinaryNode<T>(item);
                }
                else
                    this.RightTree.Add(item);
            }


        }
        public void Display()
        {
            if (this.LeftTree != null)
            {
                this.leftcount++;
                this.LeftTree.Display();
            }
            Console.WriteLine(this.NodeData.ToString());
            if (this.RightTree != null)
            {
                this.rightcount++;
                this.RightTree.Display();
            }
        }
        //Serach Method For Finding A value in BinarySearchTree 
        public bool IfExists(T element, MyBinaryNode<T> node)
        {
            if (node == null)
            {
                return false;
            }
            if (node.NodeData.Equals(element))
            {
                Console.WriteLine("Found the element in BST" + " " + node.NodeData);
                result = true;
            }
            else
            {
                Console.WriteLine("Current element is {0} in BST", node.NodeData);
            }
            if (element.CompareTo(node.NodeData) < 0)
            {
                IfExists(element, node.LeftTree);
            }
            if (element.CompareTo(node.NodeData) > 0)
            {
                IfExists(element, node.RightTree);
            }
            return result;
        }
    }
}
