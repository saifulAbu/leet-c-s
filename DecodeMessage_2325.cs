using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp
{
    internal class DecodeMessage_2325
    {
        public string DecodeMessage(string key, string message)
        {
            Dictionary<char, char> dict = buildMap(key);
            string res = "";
            foreach (char ch in message) {
                res += (dict[ch]);
            }
            return res;
        }

        private Dictionary<char, char> buildMap(string key) {
            Dictionary<char, char> res = new Dictionary<char, char>();
            int i = 0;
            res.Add(' ', ' ');
            foreach(char ch in key) {
                if (!res.ContainsKey(ch)) {
                    res.Add(ch, (char)('a' + i++));
                }
            }
            return res;
        }
    }
}
