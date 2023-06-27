using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_BasicClass
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "Saymon";
            person.LastName = "Islam";
            Console.WriteLine(person.GetFullName());
            Console.WriteLine(person.FullName);

            Console.ReadLine();
        }
    }
}
