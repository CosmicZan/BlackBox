using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public static class ReversedWords
    {
        public static string ReverseWords(string str)
        {
            string[] _phrase = str.Split(' ');
            Array.Reverse(_phrase);
            string _newPhrase = (String.Join(' ', _phrase));
            return _newPhrase;
        }
    }
}
