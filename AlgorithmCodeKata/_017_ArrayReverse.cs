using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCodeKata {
    internal class _017_ArrayReverse {
        public int[] solution(long n) {
            string s = n.ToString();
            int[] answer = new int[s.Length];
            for (int i = 0; i < s.Length; i++) {
                answer[i] = int.Parse(s[s.Length - i - 1].ToString());
            }
            return answer;
        }
    }
}
