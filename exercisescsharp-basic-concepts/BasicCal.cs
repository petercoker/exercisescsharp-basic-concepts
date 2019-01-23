using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercisescsharp_basic_concepts
{
    class BasicCal
    {
        public void GetCalAdd(int num)
        {
            int sum = num + num;
            Console.WriteLine("{0} + {1} = {2}", num, num, sum);
        }

        public void GetCalSub(int num)
        {
            int sum = num - num;
            Console.WriteLine("{0} - {1} = {2}", num, num, sum);
        }

        public void GetCalMul(int num)
        {
            int sum = num * num;
            Console.WriteLine("{0} x {1} = {2}", num, num, sum);
        }

        public void GetCalDiv(int num)
        {
            int sum = num / num;
            Console.WriteLine("{0} / {1} = {2}", num, num, sum);
        }
    }
}
