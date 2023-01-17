using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public static class Sum
    {
        public static void Tests(int a, int b)
        {
            if(a == b)
            {
                Console.WriteLine("Same");
            }
            if (a > b)
            {
                Console.WriteLine("Success");
            }
            if (a < b)
            {
                Console.WriteLine("Success");
            }
        }

        public static int GetSum(int a, int b)
        {
            int[] _numbers = new int[2]; _numbers[0] = a; _numbers[1] = b;
            int _max = _numbers.Max(); int _min = _numbers.Min();
            int _res = 0;
            if (_max == _min)
                return (a);
            else
            {
                for (int k = _min; k <= _max; k++)
                {
                    _res += k;
                }
                return(_res);
            }
        }
    }
}
