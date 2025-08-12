using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_one
{
    class Triangle
    {
        private int numberOfRow;
        public Triangle(int number)
        {
            numberOfRow = number;
        }
        public void LeftPointer()
        {
            for (int i = 0; i <= numberOfRow; i++)
            {
                

                for (int j = 0; j <= numberOfRow - i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("pls enter number");
            int x=int.Parse(Console.ReadLine());
            Triangle newleftPointer =new Triangle(x);
            newleftPointer.LeftPointer();
            
            Console.ReadKey();

        }
    }
}
