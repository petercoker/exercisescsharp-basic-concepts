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
            int num;
            Multi_Table basic = new Multi_Table();

            Console.Write("Enter a number: ");
            num = int.Parse(Console.ReadLine());
            basic.Multi(num);

        }
    }
}