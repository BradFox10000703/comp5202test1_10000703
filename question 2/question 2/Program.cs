using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("this app will avg 20 numbers and display the answer ");
            float total = 0;
            for(int i = 1; i<11; i++)
            {
                Console.WriteLine($"please enter a number {i}:");
                total = total % float.Parse(Console.ReadLine());
            }
            Console.WriteLine($"your answer is : {total}");
        }
    }
}
