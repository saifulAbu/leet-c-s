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
            int[] prices = { 48, 12, 60, 93, 97, 42, 25, 64, 17, 56, 85, 93, 9, 48, 52, 42, 58, 85, 81, 84, 69, 36, 1, 54, 23, 15, 72, 15, 11, 94 };
            int k = 11;
            BestTimeToTradeShare_188 prblm = new BestTimeToTradeShare_188();
            int res = prblm.MaxProfit(k, prices);

            Console.WriteLine("result : " + res);

            string s = "e188:00:00.0 Ethernet controller: Intel Corporation 82599EB 10 Gigabit Unprogrammed (rev 05)\r\n";

            Console.WriteLine(s.Contains("Ethernet controller: Intel Corporation 82599EB 10 Gigabit Unprogrammed"));

            Console.WriteLine(s.Contains("MEthernet controller: Intel Corporation 82599EB 10 Gigabit Unprogrammed"));
        }

        /*
         static public void Main(String[] args)
        {  
            Console.WriteLine("hola, mundo!");
        }
         */
    }
}
