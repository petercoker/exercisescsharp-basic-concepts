//+src=/sdcard/Git/exercisescsharp-basic-concepts/Program.cs
using System;
using System.Runtime.InteropServices;

namespace exercises_csharp_basic_concepts
{
    public class Formats
    {
        public void PrintName()
        {
           Console.Write("What is your name: ");
           string name = Console.ReadLine();

            Console.Write("Hello " + name + "!\n");
            Console.WriteLine($"Hello {name}!");
            Console.WriteLine("Hello {0}!", name);
        }
    }
}