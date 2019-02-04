using System;
using System.Collections.Generic;

namespace exercisescsharp_basic_concepts
{
    class Average
    {
        public void GetAverage()
        {
            double average = 0;
            double number;
            int count = 1;

            do
            {
                Console.Write($"Enter a number {count}/4: ");
                number = double.Parse(Console.ReadLine());
                average += number;

                count++;
            } while (count <= 4);

            Console.WriteLine($"Average is {average}");
            
        }
    }
}
