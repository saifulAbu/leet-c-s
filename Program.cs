using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp
{
    internal class Program
    {
 
        static public void Main(String[] args)
        {
            CoinExchange_322 m = new CoinExchange_322();
            int[] coins = {2, 3};
            int res = m.CoinChange(coins, 3);

            Console.WriteLine("result : " + res);
        }

        /*
         static public void Main(String[] args)
        {  
            Console.WriteLine("hola, mundo!");
        }
         */
    }
}
