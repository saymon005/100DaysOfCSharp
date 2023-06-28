using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_Array
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] grades = { 90, 80, 85, 90, 95};
            char[] chars = { 'A', 'B', 'C', 'D', 'E' };
            string[] fruirts = { "Apple", "Orange", "Banana", "Pineapple", "Jackfruits" };
            Console.WriteLine(grades[0]);
            Console.WriteLine(chars[1]);
            Console.WriteLine(fruirts[2]);
            int size = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[size]; // instead of int[5], we also pass the array size
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\n");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine("\n");
            Console.WriteLine(Array.IndexOf(grades, 85)); // searching in an array
            Array.Sort(grades);
            for(int i=0; i<grades.Length; i++)
            {
                Console.WriteLine(grades[i]);
            }
            Console.WriteLine("\n");
            Array.Reverse(grades);  // reverse in an array
            for (int i = 0; i < grades.Length; i++)
            {
                Console.WriteLine(grades[i]);
            }
            Console.ReadLine();
        }
    }
}
