using System;
using exercisescsharp_basic_concepts;

namespace exercises_csharp_basic_concepts
{
    public class Division
    {
        public void GetDivide(int a, int b)
        {
            if (a == 0)
            {
                Console.WriteLine("Error, can not divide by 0");
            }
            else
            {
                Console.WriteLine(a / b);
            }
        }
    }
}