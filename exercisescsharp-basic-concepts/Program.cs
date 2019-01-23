//+src=/sdcard/Git/exercisescsharp-basic-concepts/Remainder.cs
using System;
using System.Runtime.InteropServices;
using exercisescsharp_basic_concepts;

namespace exercises_csharp_basic_concepts
{
    class Program
    {
        static void Main(string[] args)
        {
            
            BasicCal basic = new BasicCal();

            Console.Write("Enter a number: ");
            int num1 = int.Parse(Console.ReadLine());
            basic.GetCalAdd(num1);
            basic.GetCalSub(num1);
            basic.GetCalMul(num1);
            basic.GetCalDiv(num1);
        }
    }
}