using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;

namespace Clases
{
    //There is an array with some numbers.All numbers are equal except for one.Try to find it!

    //findUniq([ 1, 1, 1, 2, 1, 1 ]) === 2
    //findUniq([ 0, 0, 0.55, 0, 0 ]) === 0.55
    //It’s guaranteed that array contains at least 3 numbers.

    //The tests contain some very huge arrays, so think about performance.

    //This is the first kata in series:

    //Find the unique number (this kata)
    //Find the unique string
    //Find The Unique
    public static class UniqueNumber
    {
        public static int GetUnique(IEnumerable<int> numbers)
        {
            //int firstNonDuplicate = numbers.GroupBy(k => k).Where(k => k.Count() == 1).Select(k => k.Key).FirstOrDefault();
            return numbers.GroupBy(k => k).Where(k => k.Count() == 1).Select(k => k.Key).FirstOrDefault();

            //your code
        }
    }
}
