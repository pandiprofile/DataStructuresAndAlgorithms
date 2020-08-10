using System;

namespace DataStructuresAndAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            KPMGTest Obj = new KPMGTest();
            Obj.ClassEntry();

            //InterviewQuestions Obj = new InterviewQuestions();
            //Obj.fnEntry();

            //Obj.SearchBFS();

            //InsertNode();

            //SortingExercise Obj = new SortingExercise();
            //Obj.fnEntry();

            //RecursiveExercise Obj = new RecursiveExercise();
            //Obj.FibonacciSeries();

            //GraphExercise Obj = new GraphExercise();
            //Obj.TestOne();

            //StackAndQueues Obj = new StackAndQueues();
            //Obj.StackExampleOne();

            //LinkedListExercise Obj = new LinkedListExercise();
            //Obj.SimpleFunction();

            //HashTablesExercise Obj = new HashTablesExercise();
            //Console.WriteLine(Obj.FirstRepeating(new int[] { 2, 5, 1, 2, 3, 5, 1, 2, 4 }));
            //ArrayExercise Obj = new ArrayExercise();
            //Obj.mergeSortedArrays(new int[] { 1, 3, 4, 5 } , new int[] { 2, 4, 6, 8 });
            //Console.WriteLine(Obj.Reverse("Pandian"));
            Console.Read();
        }

        static public void InsertNode()
        {
            BinaryTree binaryTree = new BinaryTree();

            binaryTree.Insert(1);
            binaryTree.Insert(2);
            binaryTree.Insert(7);
            binaryTree.Insert(3);
            binaryTree.Insert(10);
            binaryTree.Insert(5);
            binaryTree.Insert(8);

            Node node = binaryTree.Find(5);
        }
    }
}
