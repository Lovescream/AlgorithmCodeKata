using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCodeKata {
    public class _065_StringSplit {
        public int solution(string s) {
            int count = 0;
            int count1 = 0;
            int count2 = 0;
            char c = '.';
            for (int i = 0; i < s.Length; i++) {
                if (i == s.Length - 1) {
                    count++;
                    continue;
                }
                if (c == '.') {
                    c = s[i];
                    count1++;
                    continue;
                }
                else if (c == s[i]) count1++;
                else count2++;
                if (count1 == count2) {
                    count++;
                    count1 = count2 = 0;
                    c = '.';
                    continue;
                }
            }
            return count;
        }
    }
}
