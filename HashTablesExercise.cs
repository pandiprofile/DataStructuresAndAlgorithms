using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms
{
    public class HashTablesExercise
    {
        /// <summary>
        /// [2,5,1,2,3,5,1,2,4]
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public int FirstRepeating(int[] A) {

            HashSet<int> inputKeys = new HashSet<int>();

            foreach (int item in A) {
                if (inputKeys.Contains(item))
                {
                    return item;
                }
                else {
                    inputKeys.Add(item);
                }
            }
            return 0;
        }
    }
}
