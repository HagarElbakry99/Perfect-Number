using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perfect_Number_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter start number = ");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter End number = ");
            int end = int.Parse(Console.ReadLine());
            for (int i = start; i <= end; i++)
            {
                int sum = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                        sum = sum + j;

                }
                if (sum == i)
                {
                    Console.WriteLine(i + " is perfect number ");
                }

            }
        }
    }
}
