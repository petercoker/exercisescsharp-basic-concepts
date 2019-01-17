using System;
using System.Runtime.InteropServices;

namespace exercises_csharp_basic_concepts
{
    class Remainder
    {
        public void GetRemainder(int a, int b)
        {
            if(a == 0)
            {
                Console.WriteLine($"Error, can not get a remainder from 0");
            }
            else
            {
                Console.WriteLine(a % b);
            }
        }
    }
}