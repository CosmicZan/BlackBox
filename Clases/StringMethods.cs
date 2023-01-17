using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public static class StringMethods
    {
        public static void StringIndex()
        {
            string _archivo = "karyna.jpg";
            string[] _archivo_split = _archivo.Split('.');

            Console.WriteLine(_archivo_split[0]);
        }
    }
}
