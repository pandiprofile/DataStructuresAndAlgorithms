using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataStructuresAndAlgorithms
{
    public class SearchBFSDFS
    {
        public void SearchBFS()
        {
            IDictionary<int, List<int>> tree = new Dictionary<int, List<int>>();
            tree[1] = new List<int> { 2, 3, 4 };
            tree[2] = new List<int> { 5 };
            tree[3] = new List<int> { 6, 7 };
            tree[4] = new List<int> { 8 };
            tree[5] = new List<int> { 9 };
            tree[6] = new List<int> { 10 };

            HashSet<int> itemCovered = new HashSet<int>();
            Queue queue = new Queue();
            queue.Enqueue(tree.ElementAt(0).Key);

            while (queue.Count > 0)
            {
                var element = queue.Dequeue();
                if (itemCovered.Contains(Convert.ToInt32(element)))
                    continue;
                else
                    itemCovered.Add(Convert.ToInt32(element));
                Console.WriteLine(element);
                List<int> neighbours;
                tree.TryGetValue(Convert.ToInt32(element), out neighbours);
                if (neighbours == null)
                    continue;
                foreach (var item1 in neighbours)
                {
                    queue.Enqueue(item1);
                }
            }
        }


        public void SearchDFS()
        {


        }

    }

    public class SearchDFS
    {
        Node root;

        public SearchDFS()
        {
            root = null;
        }

        public void fnEntry() {
            root = new Node(1);
            root.LeftNode = new Node(2);
            root.RightNode = new Node(3);
            root.LeftNode.LeftNode = new Node(4);
            root.LeftNode.RightNode = new Node(5);

            Console.WriteLine("Preorder traversal " +
                      "of binary tree is ");
            printPreorder();

            //Console.WriteLine("\nInorder traversal " +
            //                    "of binary tree is ");
            //printInorder();

            //Console.WriteLine("\nPostorder traversal " +
            //                      "of binary tree is ");
            //printPostorder();
        }

        // Wrappers over above recursive functions 
        void printPostorder() { printPostorder(root); }
        void printInorder() { printInorder(root); }
        void printPreorder() { printPreorder(root); }

        /* Given a binary tree, print  
   its nodes according to the 
   "bottom-up" postorder traversal. */
        void printPostorder(Node node)
        {
            if (node == null)
                return;

            // first recur on left subtree 
            printPostorder(node.LeftNode);

            // then recur on right subtree 
            printPostorder(node.RightNode);

            // now deal with the node 
            Console.Write(node.Data + " ");
        }

        /* Given a binary tree, print  
           its nodes in inorder*/
        void printInorder(Node node)
        {
            if (node == null)
                return;

            /* first recur on left child */
            printInorder(node.LeftNode);

            /* then print the data of node */
            Console.Write(node.Data + " ");

            /* now recur on right child */
            printInorder(node.RightNode);
        }

        /* Given a binary tree, print 
           its nodes in preorder*/
        void printPreorder(Node node)
        {
            if (node == null)
                return;

            /* first print data of node */
            Console.Write(node.Data + " ");

            /* then recur on left sutree */
            printPreorder(node.LeftNode);

            /* now recur on right subtree */
            printPreorder(node.RightNode);
        }
    }
}
