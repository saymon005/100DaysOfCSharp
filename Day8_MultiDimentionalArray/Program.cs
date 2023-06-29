using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_MultiDimentionalArray
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[,] grades = new int[5,5]; // multidimentional array like this is 2D array
            //int[,] numbers = new int[3, 4]; // this is jagged array
            int[,] numbers =
            {
                {1, 2, 3, 4 },
                { 5, 6, 7, 8 },
                { 9, 10, 11, 12}

            };

            Console.WriteLine(numbers[0, 2]);
            Console.WriteLine(numbers.GetLength(0)); // this used for how many rows have
            Console.WriteLine(numbers.GetLength(1)); // this used for how many column have

            for(int i = 0; i < numbers.GetLength(0); i++)
            {
                for(int j=0; j < numbers.GetLength(1); j++)
                {
                    Console.Write(numbers[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
