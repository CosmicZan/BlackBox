using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    //Kitty jumping through shelves
    public static class JumpyKitty
    {
        public static int Jumping(int start, int finish)
        {
            Console.WriteLine(" |\\_/|");
            Console.WriteLine(" (^-^)  *miau");
            Console.WriteLine(" \\) (/");
            Console.WriteLine("  ┴─┴");

            int _saltosTotales = 0;
            int _saltos = finish - start;
            int _saltox3 = _saltos / 3;
            Console.WriteLine(start);
            for (int k = 1; k <= _saltox3; k++)
            {
                start += 3;
                _saltos -= 3;
                _saltosTotales++;
                Console.WriteLine(start);
            }
            int _saltox1 = _saltos / 1;
            for (int k = 1; k <= _saltox1; k++)
            {
                start++;
                _saltos--;
                _saltosTotales++;
                Console.WriteLine(start);
            }
            //Mew
            return _saltosTotales;
        }
    }
}
