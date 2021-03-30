using System;

namespace p267
{
    //class Test
    //{
    //public int Multi(int x, int y)
    //{
    //    return x * y;
    //}

    //public void Print()
    //{
    //    Console.WriteLine("print() 메서드가 호출되었습니다.");
    //}

    //public int Sum(int min, int max)
    //{
    //    int output = 0;
    //    for(int i = min; i<=max; i++)
    //    {
    //        output += i;
    //    }
    //    return output;
    //}

    //public int Multiply(int min, int max)
    //{
    //    int output = 1;
    //    for (int i = min; i<=max; i++)
    //    {
    //        output *= i;
    //    }
    //    return output;
    //} 
    //}

    //class MyMath
    //{
    //public static int Abs(int input)
    //{
    //    if (input < 0)
    //    {
    //        return -input;
    //    }
    //    else
    //    {
    //        return input;
    //    }
    //}
    //public static int Abs(int input)
    //{
    //    if(input < 0 )
    //    {
    //        return -input;
    //    }
    //    else
    //    {
    //        return input;
    //    }
    //}

    //public static double Abs(double input)
    //{
    //    if (input < 0)
    //    {
    //        return -input;
    //    }
    //    else
    //    {
    //        return input;
    //    }
    //}

    //public static long Abs(long input)
    //{
    //    if (input < 0)
    //    {
    //        return -input;
    //    }
    //    else
    //    {
    //        return input;
    //    }
    //}
    //}

    ////p 284
    //class Product
    //{
    //    public static int counter = 0;
    //    public int id;
    //    public string name;
    //    public int price;

    //    //기본적으로 생성되는 생성자
    //    public Product()
    //    {
    //    }

    //    public Product(string name, int price)
    //    {
    //        Product.counter = counter + 1;
    //        this.id = counter; // this 클래스 안에 
    //        this.name = name; // 생성자의 매개변수에서 온다 생성자 반환값은 없다.
    //        this.price = price;
    //    }

    //p294
    class Box
    {
        private int width;
        private int height;

        public Box(int width, int heigt)
        {
            if (width > 0 || height > 0)
            {
                this.width = width;
                this.height = height;
            }
            else
            {
                Console.WriteLine("너비와 높이는 자연수로 초기화 해주세요!");
            }


        }
        public int Area()
        {
            return this.width * this.height;
        }
    }
    

class Program
{
    static void Main(string[] args)
    {
        //Test test = new Test();
        //Console.WriteLine(test.Multi(52, 273));
        //Console.WriteLine(test.Multi(103, 32));
        //test.Print();

        //Test test = new Test();
        //Console.WriteLine(test.Sum(1, 100));
        //Console.WriteLine(test.Multiply(1, 10));

        //Console.WriteLine(MyMath.Abs(52));
        //Console.WriteLine(MyMath.Abs(-273));

        ////int
        //Console.WriteLine(MyMath.Abs(52));
        //Console.WriteLine(MyMath.Abs(-273));

        ////double
        //Console.WriteLine(MyMath.Abs(52.273));
        //Console.WriteLine(MyMath.Abs(-32.103));

        ////long
        //Console.WriteLine(MyMath.Abs(21474863649));
        //Console.WriteLine(MyMath.Abs(-21474863649));

        //Product aa = new Product(); // 값 없는 것.
        //Product productA = new Product("감자", 2000);
        //Product productB = new Product("고구마", 3000);

        //Console.WriteLine(productA.id + ":" + productA.name);
        //Console.WriteLine(productB.id + ":" + productB.name);
        //Console.WriteLine(Product.counter + "개 생성되었습니다.");

       
       
    }
}

