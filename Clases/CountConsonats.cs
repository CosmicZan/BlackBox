using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

//Complete the function that takes a string of English-language text and returns the number of consonants in the string.
//Consonants are all letters used to write English excluding the vowels a, e, i, o, u.

namespace Clases
{
    public static class CountConsonats
    {
        public static int ConsonantCount(string str)
        {
            char[] chars = str.ToLower().ToCharArray();
            int _count = 0;
            foreach (char c in chars)
            {
                bool _number = Char.IsNumber(c);
                bool _symbol = Regex.IsMatch(c.ToString(), @"(?i)^[^a-z0-9]+$");
                if (c != 'a' && c != 'e' && c != 'i' && c != 'o' && c != 'u' && c != ' ' && _number == false && _symbol == false) {
                    _count++;
                }
            }
            // ...
            return (_count);
        }
    }
}
