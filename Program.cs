using System;

namespace p267
{
    class Test
    {
        public int Multi(int x, int y)
        {
            return x * y;
        }

        public void Print()
        {
            Console.WriteLine("print() 메서드가 호출되었습니다.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test();
            Console.WriteLine(test.Multi(52, 273));
            Console.WriteLine(test.Multi(103, 32));
            test.Print();
        }
    }
}
