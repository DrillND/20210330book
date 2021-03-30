using System;

namespace ConsoleApp1
{
    class Box
    {
        private int width;
        private int height;

        public Box(int width, int height)
        {
            if(width > 0 || height >0)
            {
                this.width = width;
                this.height = height;
            }
            else
            {
                Console.WriteLine("너비와 높이는 자연수로 초기화해주세요!");
            }
        }

        public int Area() { return this.width * this.height; }

        public int GetWidth() { return width; }
        public int Getheight() { return height; }

        public void SetWidth(int width)
        {
            if (width > 0) { this.width =width;}
            else { Console.WriteLine("너비는 자연수를 입력해주세요"); }
        }

        public void SetHeight(int height)
        {
            if (height > 0) { this.height = height; }
            else { Console.WriteLine("높이는 자연수를 입력해주세요"); }
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box(25, 50);
            Console.WriteLine(box.GetWidth());
        }
    }
}
