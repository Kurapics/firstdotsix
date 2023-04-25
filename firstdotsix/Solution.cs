using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstdotsix
{
    internal class Solution
    {
        public double Method(double x, double n)
        {
            double res = 0;
            for (int i = 1; i <= n; i++)
                res += i / Math.Pow(x, i);
            return res;
        }
    }
}
