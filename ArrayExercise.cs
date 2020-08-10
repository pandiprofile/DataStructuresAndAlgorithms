using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataStructuresAndAlgorithms
{
    public class ArrayExercise
    {
        public string Reverse(string str)
        {

            StringBuilder strResult = new StringBuilder();

            char[] input = str.ToArray();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                strResult.Append(input[i]);
            }

            return strResult.ToString();
        }
        public void mergeSortedArrays(int[] A, int[] B)
        {
            int[] result = new int[A.Length + B.Length];

            int i = 0;
            int j = 0;
            int k = 0;
            while (i < A.Length  && j < B.Length )
            {
                if (A[i] <= B[j])
                {
                    result[k] = A[i];
                    i++;
                }
                else
                {
                    result[k] = B[j];
                    j++;
                }
                k++;
            }
            if (i < A.Length) {
                for (int x = i; x < A.Length; x++) {
                    result[k] = A[x];
                    k++;
                }
            }
            if (j < B.Length) {
                for (int x = j; x < B.Length; x++)
                {
                    result[k] = B[x];
                    k++;
                }
            }
        }

    }
}
