using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;
namespace DataStructuresAndAlgorithms
{
    public class DocumentProcessor  
    {
        /// <summary>
        /// Analyzes the document and returns statistics.
        /// </summary>
        /// <exception cref="ArgumentNullException">document is null</exception>
        public Stats Analyze(string document)
        {
            Stats Obj = new Stats();

            List<string> Words = document.Split(' ').ToList();

            Obj.NumberOfAllWords = Words.Count();

            var matches = Regex.Matches(document, @"(\w*\d[\w\d]+)");

            Obj.NumberOfWordsThatContainOnlyDigits = matches.Count();

            

            Obj.TheLongestWord = Words.OrderByDescending(n => n.Length).First();

            Obj.TheShortestWord = Words.OrderBy(n => n.Length).First();

            return Obj;
        }
    }

    public class Stats
    {
        // Total number of all words in the document
        public int NumberOfAllWords { get; set; }

        // Returns number of words that consist only from digits e.g. 13455, 98374
        public int NumberOfWordsThatContainOnlyDigits { get; set; }

        // Returns number of words that start with a lower letter e.g. a, d, z
        public int NumberOfWordsStartingWithSmallLetter { get; set; }

        // Returns number of words that start with a capital letter e.g. A, D, Z
        public int NumberOfWordsStartingWithCapitalLetter { get; set; }

        // Returns the first longest word in the document
        public string TheLongestWord { get; set; }

        // Returns the first shortest word in the document
        public string TheShortestWord { get; set; }
    }


    public class KPMGTest
    {
        public void ClassEntry()
        {
            Console.WriteLine(string.Format("Maximum possible number for {0} is: {1}", 276, MaximumPossible(276)));
            Console.WriteLine(string.Format("Maximum possible number for {0} is: {1}", -999, MaximumPossible(-999)));
            Console.WriteLine(string.Format("Maximum possible number for {0} is: {1}", 0, MaximumPossible(0)));
            Console.WriteLine(string.Format("Maximum possible number for {0} is: {1}", 860, MaximumPossible(860)));
            Console.ReadKey();
        }

        public void fnDocu()
        {
            List<string> words = new List<string>();
            string input = "";

            var matches = Regex.Matches(input, @"(\w*\d[\w\d]+)");

            int NumberOfWordsThatContainOnlyDigits = matches.Count();

            //foreach (Match match in matches)
            //{
            //    var word = match.Value;
            //}

        }
        public string fn()
        {
            string s = "aba";
            List<Char> lst = new List<char>();
            lst = s.ToList();

            if (lst.Count <= 1) { return string.Empty; }

            List<Char> query = lst.GroupBy(x => x)
               .Where(g => g.Count() > 1)
               .Select(y => y.Key)
               .ToList();

            if (query.Count > 0)
            {
                return query[0].ToString();
            }
            else
            {
                return string.Empty;
            }

        }

        public int MaximumPossible(int N)
        {
            // digit to insert in given number
            int digit = 5;

            // edge case
            if (N == 0)
            {
                return digit * 10;
            }

            // -1 if N is negative number else 1
            int negative = N / Math.Abs(N);
            // get the absolute value of given number
            N = Math.Abs(N);
            int n = N;
            // maximum number obtained after inserting digit.
            int maxVal = int.MinValue;
            int counter = 0;
            int position = 1;

            // count the number of digits in the given number.
            while (n > 0)
            {
                counter++;
                n = n / 10;
            }

            // loop to place digit at every possible position in the number,
            // and check the obtained value.
            for (int i = 0; i <= counter; i++)
            {
                int newVal = ((N / position) * (position * 10)) + (digit * position) + (N % position);

                // if new value is greater the maxVal
                if (newVal * negative > maxVal)
                {
                    maxVal = newVal * negative;
                }

                position = position * 10;
            }

            return maxVal;
        }
    }
}
