using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public static class KillerGarageDoor
    {
        public static void ProcessEvents(string events)
        {
            int _counter_1 = 0, _counter_5 = 0;
            int _aux_5 = events.ToCharArray().Where(x => x.Equals('5')).Count();
            List<string> _secuency = new List<string>();
            foreach (var k in events)
            {
                if (k.ToString().Contains('5'))
                    _counter_5++;
                if (k.ToString().Contains('1') && _counter_1 == 0 || k.ToString().Contains('4') && _counter_5 >= _aux_5)
                {
                    _secuency.Add("P");
                    _counter_1++;
                }
                else
                    _secuency.Add(".");
            }
            Console.WriteLine((String.Join(' ', _secuency)));
        }
    }
}
