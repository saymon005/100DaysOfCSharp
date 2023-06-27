using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_ConditionalStatement
{
    public class Program
    {
        static void Main(string[] args)
        {
            // if else else if condition
            Console.WriteLine("Enter Your Grades: ");
            int grade = Convert.ToInt32(Console.ReadLine());

            if (grade > 0 && grade < 40)
            {
                Console.WriteLine("F");
            }
            else if (grade >= 40 && grade <= 45)
            {
                Console.WriteLine("D");
            }
            else if (grade >= 40 && grade <= 45)
            {
                Console.WriteLine("C");
            }
            else if (grade >= 50 && grade <= 54)
            {
                Console.WriteLine("C+");
            }
            else if (grade >= 55 && grade <= 59)
            {
                Console.WriteLine("B-");
            }
            else if (grade >= 60 && grade <= 64)
            {
                Console.WriteLine("B");
            }
            else if (grade >= 65 && grade <= 69)
            {
                Console.WriteLine("B+");
            }
            else if (grade >= 70 && grade <= 74)
            {
                Console.WriteLine("A-");
            }
            else if (grade >= 75 && grade <= 79)
            {
                Console.WriteLine("A");
            }
            else if (grade >= 80 && grade <= 100)
            {
                Console.WriteLine("A+");
            }

            //Switch condition

            Console.WriteLine("Enter two numbers: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Operator: ");
            char c = Convert.ToChar(Console.ReadLine());

            switch (c)
            {
                case '+': Console.WriteLine(a+b);
                    break;
                case '-': Console.WriteLine(a-b);
                    break;
                case '*':
                    Console.WriteLine(a * b);
                    break;
                case '/':
                    Console.WriteLine(a / b);
                    break;
                default: Console.WriteLine(a%b);
                    break;

            }
            

            //Ternary condition
            bool check = false;
            int ans = check ? 1 : 0;
            Console.WriteLine(ans);
            Console.ReadLine();
        }
    }
}
