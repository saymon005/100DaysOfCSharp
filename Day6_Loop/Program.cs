using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Loop
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            int i = 1; //initialization
            while (i <= 10)   //condition
            {
                Console.WriteLine(i);
                i++;  // update
            }



            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            i = 1;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i <= 10);

            // Nested loop

            for (i = 10; i>=1; i--)
            {
                for(int j = i; j >=1; j--)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
