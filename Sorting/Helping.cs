using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    static class Helping
    {
       public static void Swap(ref int e1, ref int e2)
        {
            (e1, e2) = (e2, e1);
        }
    }
}
