using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataStructuresAndAlgorithms
{
    public class SortingExercise
    {

        public void fnEntry()
        {
            List<int> numbers = new List<int> () { 99, 44, 6, 2, 1, 5, 63, 87, 283, 4, 0 };
            List<int> answer = MergeSort(numbers);
            foreach (int num in answer) { Console.WriteLine(num); }
        }
        public void SortOne()
        {
            int[] numbers = { 2, 1, 65, 93, 2, 9, 0 };

            string[] strs = { "v", "e", "wf", "agg", "s", "a" };

            Array.Sort(numbers);
            Array.Sort(strs);


            foreach (int num in numbers) { Console.WriteLine(num); }
            foreach (string str in strs) { Console.WriteLine(str); }

        }

        public void SelectionSort()
        {
            int[] numbers = { 99, 44, 6, 2, 1, 5, 63, 87, 283, 4, 0 };

            for (int i = 0; i < numbers.Length; i++)
            {
                int min = i;
                int temp = numbers[i];
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    //smallest = numbers[i];
                    if (numbers[j] < numbers[min])
                    {
                        min = j;
                    }
                }
                numbers[i] = numbers[min];
                numbers[min] = temp;
            }
            foreach (int num in numbers) { Console.WriteLine(num); }
        }
        public void InsertionSort()
        {
            int[] numbers = { 99, 44, 6, 2, 1, 5, 63, 87, 283, 4, 0 };

            for (int i = 0; i < numbers.Length; i++)
            {

                for (int j = i + 1; j < numbers.Length; j++)
                {


                }

            }
            foreach (int num in numbers) { Console.WriteLine(num); }
        }

        private List<int> MergeSort(List<int> unsorted)
        {
            if (unsorted.Count <= 1) {
                return unsorted;
            }
            int midpoint = unsorted.Count / 2;
            int mod = unsorted.Count % 2;
            List<int> left = unsorted.Take(midpoint).ToList();
            List<int> right = unsorted.TakeLast(midpoint + mod).ToList();

            left = MergeSort(left);
            right = MergeSort(right);

            foreach (int num in left) { 
                // Console.WriteLine(" left ");
                Console.Write(" left " + " " + num + " ");
            }
            foreach (int num in right)
            {
                Console.WriteLine(" right ");
                Console.Write(" right "+ " " + num + " ");
            }

            return Merge(left, right);
        }

        private static List<int> Merge(List<int> left, List<int> right)
        {

            List<int> result = new List<int>();

            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (left.First() <= right.First())  //Comparing First two elements to see which is smaller
                    {
                        result.Add(left.First());
                        left.Remove(left.First());      //Rest of the list minus the first element
                    }
                    else
                    {
                        result.Add(right.First());
                        right.Remove(right.First());
                    }
                }
                else if (left.Count > 0)
                {
                    result.Add(left.First());
                    left.Remove(left.First());
                }
                else if (right.Count > 0)
                {
                    result.Add(right.First());

                    right.Remove(right.First());
                }
            }
            return result;
        }

        //public int[] mergeSort(int[] array)
        //{
        //    if (array.Length == 1)
        //    {
        //        return array;
        //    }
        //    // Split Array in into right and left
        //    int[] left =  array.Take(array.Length / 2).ToArray();
        //    int[] right = array.TakeLast((array.Length / 2)+1).ToArray();

        //    return merge(
        //        mergeSort(left), 
        //        mergeSort(right)
        //        );

        //}

        //public int[] merge(int[] left, int[] right)
        //{
        //    return null;

        //}

    }
}
