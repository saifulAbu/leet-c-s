using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp
{
    internal class NthTribonacci_1137
    {
        public int Tribonacci(int n)
        {
                int t_n_1 = 1;
                int t_n_2 = 1;
                int t_n_3 = 0;

                if (n == 0)
                {
                    return 0;
                }
                else if (n == 1)
                {
                    return 1;
                }

                for (int i = 3; i <= n; i++)
                {
                    var t_cur = t_n_1 + t_n_2 + t_n_3;
                    t_n_3 = t_n_2;
                    t_n_2 = t_n_1;
                    t_n_1 = t_cur;
                }

                return t_n_1;
        }
    }
}
