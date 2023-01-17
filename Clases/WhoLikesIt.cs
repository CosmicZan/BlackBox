using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public static class WhoLikesIt
    {
        public static string Likes(string[] name)
        {
            int k = name.Length;
                switch (k)
                {
                    case var expression when k == 0:
                        return "no one likes this";
                    case 1:
                        return name[0] + " likes this";
                    case 2:
                        return name[0] + " and " + name[1] + " like this";
                    case 3:
                        return name[0] + ", " + name[1] + " and " + name[2] + " like this";
                    case 4:
                        return name[0] +", " + name[1] + " and 2 others like this";
                    case var expression when k > 4:
                        return name[0] + ", " + name[1] + " and " + (k-2) + " others like this";
            }
            throw new NotImplementedException();
        }
    }
}
