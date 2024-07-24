using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloGit
{
    internal class Program
    {
       static public int PArse(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("hello git");
            int f, b;
            f = int.Parse(Console .ReadLine());
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("сума:"+ PArse(f, b));
            string git = "git goud";
        }
    }
}
