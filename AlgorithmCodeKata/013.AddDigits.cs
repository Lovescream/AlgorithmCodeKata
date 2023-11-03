using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCodeKata {
    // 자연수 N이 주어지면, N의 각 자릿수의 합을 구해서 return 하는 solution 함수를 만들어 주세요.
    // 예를들어 N = 123이면 1 + 2 + 3 = 6을 return 하면 됩니다.

    // N의 범위 : 100,000,000 이하의 자연수

    internal class _013 {
        public int solution(int n) {
            int answer = 0;
            int temp = n;
            while (temp > 0) {
                temp = n / 10;
                answer += n - temp * 10;
                n = temp;
            }
            return answer;
        }
    }
}
