using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms
{
   public class GraphExercise
    {
        public void TestOne()
        {
            Graph graph = new Graph(5);
            graph.AddEdge(0, 1);
            graph.AddEdge(0, 3);
            graph.AddEdge(1, 2);
            graph.AddEdge(2, 3);
            graph.AddEdge(3, 4);

            Console.WriteLine("The graph adjacency list representation:");
            graph.PrintAdjanceyList();

            Console.Read();
        }
    }

    public class Graph
    {
        LinkedList<int>[] linkedListArray;

        public Graph(int v)
        {
            linkedListArray = new LinkedList<int>[v];
        }

        /// 

        /// The method takes two nodes for which to add edge.
        /// 
        /// 
        /// 
        /// 
        public void AddEdge(int u, int v, bool blnBiDir = true)
        {
            if (linkedListArray[u] == null)
            {
                linkedListArray[u] = new LinkedList<int>();
                linkedListArray[u].AddFirst(v);
            }
            else
            {
                var last = linkedListArray[u].Last;
                linkedListArray[u].AddAfter(last, v);
            }

            if (blnBiDir)
            {
                if (linkedListArray[v] == null)
                {
                    linkedListArray[v] = new LinkedList<int>();
                    linkedListArray[v].AddFirst(u);
                }
                else
                {
                    var last = linkedListArray[v].Last;
                    linkedListArray[v].AddAfter(last, u);
                }
            }
        }

        public void PrintAdjanceyList()
        {
            //Taversing over each of the vertices
            for (int i = 0; i < linkedListArray.Length; i++)
            {
                //Printing the vertices
                Console.Write(i + "->");

                //Printing the linked list of vertex
                foreach (var item in linkedListArray[i])
                {
                    Console.Write(item + ",");
                }

                Console.WriteLine();
            }
        }
    }
}
