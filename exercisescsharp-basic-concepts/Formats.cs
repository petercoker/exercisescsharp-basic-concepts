//+src=/sdcard/Git/exercisescsharp-basic-concepts/Program.cs
using System;
using System.Runtime.InteropServices;

namespace exercises_csharp_basic_concepts
{
    class Formats
    {
        public void PrintName(string name)
        {
           name = Console.ReadLine();
        
           Console.Write($"Hello {name}");
           Console.WriteLine("Hello " + name);
           Console.WriteLine("Hello {0}", name);
        }
    }
}