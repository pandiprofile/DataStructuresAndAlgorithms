using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms
{
    public class InterviewQuestions
    {
        static String location;
        static DateTime time;
        static int a;

        public void fnEntry()
        {
            B Obj = new B();
            Obj.fn1();


            //fnArrayCopy();

            //ClassA refA = new ClassA();

            //TestStatic t = new TestStatic();
            //t.Print();

            //toptalQuestion3 Obj = new toptalQuestion3();
            //toptalQuestion3.toptalQuestion3Main();
            //toptalQuestion3.delegateMain();
        }
        public void fnArrayCopy()
        {
            int[] A = new int[] { 1, 2, 3, 4, 5 };

            int[] B = new int[] { 11, 12, 13, 14, 15 };

            A.CopyTo(B, 0);
            var C = A.Clone();

        }
        public void fnException()
        {
            try
            {
                Console.WriteLine("Hello");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("A");
            }
            catch (Exception)
            {
                Console.WriteLine("B");
            }
            finally
            {
                Console.WriteLine("C");
            }
            Console.ReadKey();
        }

        public void fnStringOperation()
        {
            string str = "foo bar foo $ bar $ foo bar $ ";

        }
        public void EssentialQuestions15()
        {
            Console.WriteLine(location == null ? "location is null" : location);
            Console.WriteLine(time == null ? "time is null" : time.ToString());
            Console.WriteLine(a == null ? "a is null" : a.ToString());

            Circle Obj = new Circle();
            double area = Obj.Calculate(r => 2 * Math.PI * (r = 2));

            Console.WriteLine(" circumference of the circle: " + area);
        }
    }

    public class sClass
    {
        private sClass() { }
        static sClass() { }
        public void fn1() { }
    }
    public class B
    {
        public static int count = 10;

        A obj = new A();
        public void fn2()
        {
            Console.WriteLine(typeof(A).ToString());
            obj.GetType();

        }
        public void fn1()
        {
            Console.WriteLine(fntryreturn());
        }


        private int fntryreturn()
        {
            int x = 0;
            try
            {
                x = 5;
                throw new Exception("test");
            }
            catch (Exception)
            {
                x = 10;
               //throw;
            }
            finally
            {
                Console.WriteLine(x);
                x = 15;
            }
            return x;
        }
    }
    public class A
    {
        private static int x = 10;
        private readonly int y = 10;
        private const int z = 10;
        string s;

        public void fn5()
        {
            char ch = Convert.ToChar("x");
            float f = Convert.ToSingle(45);

            int x = int.Parse("100");
            char ch1 = Char.Parse("x");
        }
        public void fn4()
        {
            int? a = null;
            int b;
            int c = 30;

            b = a ?? c;
            Console.WriteLine(b);
            a = 35;
            b = a ?? c;
            Console.WriteLine(b);
        }


        public A()
        {
            x = 20;
            //y = 20;
            //z = 20;
        }

        public void fn3()
        {
            string str = "Hello World!";
            CharEnumerator chs = str.GetEnumerator();
            while (chs.MoveNext())
            {
                Console.WriteLine(chs.Current);
            }
        }
        public void fn2()
        {

            Console.WriteLine(s.Length);
            int i = 5;
            int j = 5;

            Console.WriteLine("i==j " + (i == j));
            Console.WriteLine("i.Equals(j) " + (i.Equals(j)));

            StringBuilder str1 = new StringBuilder("ABC");
            StringBuilder str2 = new StringBuilder("ABC");

            Console.WriteLine("str1==str2 " + (str1 == str2));
            Console.WriteLine("str1.Equals(str2) " + (str1.Equals(str2)));
        }
        public void fn1()
        {
            int i = 1;
            int j = 1;
            i = i++;
            j = ++j;
            Console.WriteLine(i.ToString() + ":" + j.ToString());
        }
        public void fn()
        {
            x = 20;
            //y = 20;
            //z = 20;

        }
    }
    class ClassA
    {
        public ClassA() : this(10) { Console.WriteLine("ClassA()"); }

        public ClassA(int pValue) { Console.WriteLine("ClassA(int pValue)"); }
    }

    public class TestStatic
    {
        public static int TestValue;

        public TestStatic()
        {
            if (TestValue == 0)
            {
                TestValue = 5;
            }
        }
        static TestStatic()
        {
            if (TestValue == 0)
            {
                TestValue = 10;
            }

        }

        public void Print()
        {
            if (TestValue == 5)
            {
                TestValue = 6;
            }
            Console.WriteLine("TestValue : " + TestValue);

        }
    }


    public sealed class Circle
    {
        private double radius;

        public double Calculate(Func<double, double> op)
        {
            return op(radius);
        }
    }

    public class toptalQuestion3
    {
        private static string result;

        delegate void Printer();

        public static void delegateMain()
        {
            List<Printer> printers = new List<Printer>();
            int i = 0;
            for (; i < 10; i++)
            {
                printers.Add(delegate { Console.WriteLine(i); });
            }

            foreach (var printer in printers)
            {
                printer();
            }
        }


        public static void toptalQuestion3Main()
        {
            SaySomething();
            //Thread.Sleep(5);
            Console.WriteLine("result: " + result);
        }

        public static async Task<string> SaySomething()
        {
            Thread.Sleep(5);
            //await Task.Delay(5);
            result = "Hello world!";
            return "Something";
        }
    }
}
