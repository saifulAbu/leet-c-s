using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp
{
    internal class UniqueMorseCode_804
    {
        private readonly string[] words = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };
        public int UniqueMorseRepresentations(string[] words)
        {
            HashSet<string> uniq = new HashSet<string>();
            foreach (string word in words)
            {
                uniq.Add(transform(word));
            }
            return uniq.Count;
        }

        string transform(string word) {
            string res = "";
            foreach (char ch in word) {
                int ind = ch - 'a';
                res += words[ind];
            }
            return res;
        }
    }
}
