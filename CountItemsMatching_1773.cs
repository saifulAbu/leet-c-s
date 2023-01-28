using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp
{
    internal class CountItemsMatching_1773
    {
        public int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue)
        {
            int index = -1;
            if (ruleKey.Equals("type"))
            {
                index = 0;
            }
            else if (ruleKey.Equals("color"))
            {
                index = 1;
            }
            else {
                index = 2;
            }

            int matched = 0;
            foreach (var item in items)
            {
                var curRuleVal = item[index];
                if (curRuleVal.Equals(ruleValue)) {
                    matched++;
                }
            }

            return matched;
        }
    }
}
