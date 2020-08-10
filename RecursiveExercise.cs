using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms
{
    public class RecursiveExercise
    {

        // 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144 
        public void FibonacciSeries()
        {
            int answer = Fibonacci(6);
            Console.WriteLine(answer);
        }
        public int Fibonacci(int number)
        {

            if (number == 0)
                return 0;
            else if (number == 1)
                return 1;
            else
            {
                return Fibonacci(number - 2) + Fibonacci(number - 1);
            }

        }

        public int checkFact(int n)
        {
            if (n == 1)
                return 1;
            else
                return n * checkFact(n - 1);
        }

    }
}
