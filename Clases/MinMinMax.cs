using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public static class MinMinMax
    {
        public static int[] MinMax(int[] array)
        {
            // solution goes here!
            int[] _array = new int[array.Length];
            for (int k = 0; k < array.Length; k++)
            {
                _array[k] = array[k]; 
            }
            Array.Sort(_array);
            int max = _array.Max();  
            int min = _array.Min();
            int minMin = min + 1;
                foreach (var item in _array)
                {
                    if (minMin == item)
                    {
                        minMin = item + 1;
                    }
                }
            int[] numbers = new int[] { min, minMin, max };
            numbers.ToList().ForEach(element => Console.Write($" {element}"));
            return numbers;
        }
    }
}
