using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp
{
    internal class WordBreak_139
    {
        public bool WordBreak(string s, IList<string> wordDict)
        {
            Dictionary<int, bool> dp = new Dictionary<int, bool>();
            HashSet<string> words = new HashSet<string>(wordDict);
            
            return WordBreakRecursive(s, words, dp, 0);
        }


        public bool WordBreakRecursive(string str, HashSet<string> words, Dictionary<int, bool> dp, int start) {
            if (start == str.Length) {
                return true;
            }
            
            if (dp.ContainsKey(start)) {
                return dp[start];
            }

            for (int end = start + 1; end <= str.Length; end++)
            {
                //Console.WriteLine(str.Substring(start, end - start) + " map contains? " + words.Contains(str.Substring(start, end - start)));
               if(words.Contains(str.Substring(start, end - start)) && WordBreakRecursive(str, words, dp, end))
                {
                    dp[start] = true;
                    return true;
               }
            }
            dp[start] = false;
            return false;

        }


    }
}
