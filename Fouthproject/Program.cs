using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fouthproject
{
      class Program
    {
        static void Main(string[] args)
        {
            int x, y, sum;

            Console.Write("enter the first number : ");
            string s1 = Console.ReadLine();
            x = int.Parse(s1);

            Console.Write("enter the second number : ");
            string s2 = Console.ReadLine();
            y = int.Parse(s2);

            sum = x + y;

            Console.WriteLine("the sum of the two number = " + sum);
            Console.ReadLine();
        }
    }
}

