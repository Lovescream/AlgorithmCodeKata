using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCodeKata {
    internal class _014_DivisorSum {
        public int solution(int n) {
            int answer = 0;
            for (int i = 1; i <= n / 2; i++) {
                if (n % i == 0) {
                    answer += i;
                }
            }
            answer += n;

            return answer;
        }
    }
}
