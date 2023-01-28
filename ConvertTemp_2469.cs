using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp
{
    class ConvertTemp_2469
    {
        public double[] ConvertTemperature(double celsius)
        {
            double[] res = new double[2];
            res[0] = celsius + 273.15;
            res[1] = celsius * 1.80 + 32.00;

            return res;
        }

        
    }

    


}
