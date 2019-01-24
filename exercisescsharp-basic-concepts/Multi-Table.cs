using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercisescsharp_basic_concepts
{
    class Multi_Table
    {
        public void Multi(int num)
        {
            for (int i = 1; i <= 12; i++)
            {
                int sum = i * num;
                Console.WriteLine("{0} x {1} = {2}", num, i, sum);
            }
        }
    }
}
