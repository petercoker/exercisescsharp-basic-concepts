using System;
using System.Runtime.InteropServices;
using exercisescsharp_basic_concepts;

namespace exercises_csharp_basic_concepts
{
    class Program
    {
        static void Main(string[] args)
        {
            Sum num = new Sum();
            Console.WriteLine(num.Add(2, 3));
        }
    }
}