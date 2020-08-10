using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms
{
    public class BinaryTree
    {
        public Node Root { get; set; }

        public bool Add(int value)
        {
            Node before = null, after = this.Root;

            while (after != null)
            {
                before = after;
                if (value < after.Data) //Is new node in left tree? 
                    after = after.LeftNode;
                else if (value > after.Data) //Is new node in right tree?
                    after = after.RightNode;
                else
                {
                    //Exist same value
                    return false;
                }
            }

            Node newNode = new Node();
            newNode.Data = value;

            if (this.Root == null)//Tree ise empty
                this.Root = newNode;
            else
            {
                if (value < before.Data)
                    before.LeftNode = newNode;
                else
                    before.RightNode = newNode;
            }

            return true;
        }

        public Node Insert(int value)
        {
            Node newNode = new Node() { Data = value, LeftNode = null, RightNode = null };

            if (this.Root == null)
            {
                this.Root = newNode;
                return this.Root;
            }

            Node currentNode = this.Root;

            while (true)
            {
                if (newNode.Data < currentNode.Data)
                {
                    if (currentNode.LeftNode == null) { currentNode.LeftNode = newNode; return newNode; }
                    currentNode = currentNode.LeftNode;
                }
                else if (newNode.Data > currentNode.Data)
                {
                    if (currentNode.RightNode == null) { currentNode.RightNode = newNode; return newNode; }
                    currentNode = currentNode.RightNode;
                }
            }
            return null;
        }
        public Node Find(int value)
        {
            return this.Find(value, this.Root);
        }

        public void Remove(int value)
        {
            this.Root = Remove(this.Root, value);
        }

        private Node Remove(Node parent, int key)
        {
            if (parent == null) { return null; }
            Node currentNode = parent;
            while (currentNode == null)
            {
                if (parent.Data < key)
                {

                }
            }

            return null;

        }

        private Node Find(int value, Node parent)
        {
            if (parent == null) { return null; }

            Node currentNode = parent;

            while (currentNode != null)
            {
                if (currentNode.Data == value) { return currentNode; }
                else if (value < currentNode.Data) // go left
                {
                    currentNode = currentNode.LeftNode;
                }
                else if (value > currentNode.Data) // go right
                {
                    currentNode = currentNode.RightNode;
                }
            }

            return null;
        }

    }
}
public class Node
{
    public Node() { }
    public Node LeftNode { get; set; }
    public Node RightNode { get; set; }
    public int Data { get; set; }

    public Node(int item)
    {
        Data = item;
        LeftNode = RightNode = null;
    }


}
