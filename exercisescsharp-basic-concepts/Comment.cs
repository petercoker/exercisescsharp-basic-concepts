using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercisescsharp_basic_concepts
{
    class Comment
    {
        public void Hide()
        {
            Console.Write("What is your name: ");
            string name = Console.ReadLine();

            Console.Write("Hello " + name + "!\n");
            /*
            Console.WriteLine($"Hello {name}!");
            Console.WriteLine("Hello {0}!", name);
            */
        }
    }
}
