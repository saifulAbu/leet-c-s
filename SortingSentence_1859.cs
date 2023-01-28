using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp
{
    internal class SortingSentence_1859
    {
        public string SortSentence(string s)
        {
            string[] words = s.Split(' ');
            string[] result = new string[words.Length];

            foreach (var str in words) {
                int index;
                string outstr;
                stringIndexSplit(str, out outstr, out index);
                result[index - 1] = outstr;
            }

            return string.Join(" ", result);
        }

        private void stringIndexSplit(in string str, out string outstr, out int index) 
        {
            index = str[str.Length - 1] - '0';
            outstr = str.Substring(0, str.Length - 1);
        }

    }
}
