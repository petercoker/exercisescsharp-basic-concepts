using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercisescsharp_basic_concepts
{
    class Equivalent_operations
    {
        public void OutEquivalent()
        {
            double a;
            double b;
            double c;

            Console.Write("Enter a number to reference \"A\": ");
            a = double.Parse(Console.ReadLine());

            Console.Write("Enter a number to reference \"B\": ");
            b = double.Parse(Console.ReadLine());

            Console.Write("Enter a number to reference \"C\": ");
            c = double.Parse(Console.ReadLine());

            Console.WriteLine("({0}+{1}).{2}= {3}", a, b, c, (a+b)*c);

            Console.WriteLine("{0}.{1} + {2}.{3}= {4}", a, c, b, c, a*c + b*c);


        }
    }
}
