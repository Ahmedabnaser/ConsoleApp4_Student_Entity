using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("pls enter student Deptname ");
            string dept_name = Console.ReadLine();
            Console.WriteLine("pls enter student Name ");
            string name = Console.ReadLine();
            Console.WriteLine("pls enter student id ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("pls enter student age ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"student_Deptname  {dept_name},and his name  {name} ,and his id  {id} ,and his age {age} ");

        }
    }
}
