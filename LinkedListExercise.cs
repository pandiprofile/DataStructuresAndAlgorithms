using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace DataStructuresAndAlgorithms
{
    public class LinkedListExercise
    {
        public void SimpleFunction()
        {
            const int _max = 100000;

            var list = new List<string>();
            var link = new LinkedList<string>();
            // Add elements.
            for (int i = 0; i < 1000; i++)
            {
                list.Add("OK");
                link.AddLast("OK");
            }

            var s1 = Stopwatch.StartNew();
            // Version 1: use List.
            for (int i = 0; i < _max; i++)
            {
                foreach (string v in list)
                {
                    if (v.Length != 2)
                    {
                        throw new Exception();
                    }
                }
            }
            s1.Stop();
            var s2 = Stopwatch.StartNew();
            // Version 2: use LinkedList.
            for (int i = 0; i < _max; i++)
            {
                foreach (string v in link)
                {
                    if (v.Length != 2)
                    {
                        throw new Exception();
                    }
                }
            }
            s2.Stop();
            Console.WriteLine(((double)(s1.Elapsed.TotalMilliseconds * 1000000) /
                _max).ToString("0.00 ns"));
            Console.WriteLine(((double)(s2.Elapsed.TotalMilliseconds * 1000000) /
                _max).ToString("0.00 ns"));
            Console.Read();
        }

        public void SimpleFunctionOne()
        {

            //
            // Create a new linked list object instance.
            //
            LinkedList<string> linked = new LinkedList<string>();
            //
            // Use AddLast method to add elements at the end.
            // Use AddFirst method to add element at the start.
            //
            linked.AddLast("cat");
            linked.AddLast("dog");
            linked.AddLast("man");
            linked.AddFirst("first");
            linked.Remove("man");
            //
            // Loop through the linked list with the foreach-loop.
            //
            foreach (string item in linked)
            {
                Console.WriteLine(item);
            }
        }

    }
}
