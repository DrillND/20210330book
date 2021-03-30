using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Change(int input)
        {
            input = 20;
        }

        class Test
        {
            public int value = 10;
        }

        static void Chanage(Test input)
        {
            input.value = 20;
        }

        static void Main(string[] args)
        {
            int a = 10;
            Change(a);
            Console.WriteLine(a);

            //int a = 10;
            int input = a;
            input = 20;
            Console.WriteLine(a);

            Test test = new Test();
            test.value = 10;
            Chanage(test);
            Console.WriteLine(test.value);
        }
    }
}
