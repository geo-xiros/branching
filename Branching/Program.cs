using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student("test");
            Console.WriteLine($"hello world1 {student}");
            Console.WriteLine($"hello world2 {student}");

        }
    }
}
