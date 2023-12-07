using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_List
{
    public class Program
    {
        static void Main(string[] args)
        {
            //List<int> list = new List<int>();
            //list.Add(6);
            //list.Add(2);
            //list.Add(3);

            //list.Insert(3,5);
            //list.Remove(3);
            //list.Sort();
            //list.Reverse();
            //foreach (int i in list)
            //{
            //    Console.WriteLine(i);
            //}

            //multidimentional list

            List<List<int>> studentGrades = new List<List<int>>()
            {
                new List<int> { 1, 2, 3 },
                new List<int> { 4, 5, 7 },
                new List<int> { 7, 8, 10 }
            };
            foreach (List<int> grades in studentGrades)
            {
                foreach(int grade in grades)
                {
                    Console.Write(grade + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
