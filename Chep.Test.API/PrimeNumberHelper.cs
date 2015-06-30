using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chep.Test.API
{
    public class PrimeNumberHelper
    {
        //credit: http://www.dotnetperls.com/prime

        public static bool IsPrimeNumber(int candidate)
        {
            if ((candidate & 1) == 0)
            {
                if (candidate == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            for (int i = 3; (i * i) <= candidate; i += 2)
            {
                if ((candidate % i) == 0)
                {
                    return false;
                }
            }
            return candidate != 1;
        }

        public static List<int> ListPrimeNumbers(int start, int end)
        {
            var list = new List<int>();
            for (int i = start; i < end; i++)
            {
                if (IsPrimeNumber(i))
                    list.Add(i);
            }
            return list;
        }
    }
}