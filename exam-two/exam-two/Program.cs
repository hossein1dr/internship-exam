using exam_one;
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
        public void RightPointer()
        {
            for (int i = 1; i <= numberOfRow; i++)
            {

                for (int space = 0; space < numberOfRow - i; space++)
                {
                    Console.Write(" ");
                }


                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }



        }
    }


}
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("pls enter number");
        int x = int.Parse(Console.ReadLine());
        if (x <= 0)
        {
            Console.WriteLine("pls enter currect number");
           
        }
       
        Triangle newleftPointer = new Triangle(x);
        newleftPointer.RightPointer();

        Console.ReadKey();

    }
}

