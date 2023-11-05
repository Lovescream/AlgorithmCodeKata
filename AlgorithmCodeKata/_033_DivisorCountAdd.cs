using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCodeKata {
    // 두 정수 left와 right가 매개변수로 주어집니다.
    // left부터 right까지의 모든 수들 중에서, 약수의 개수가 짝수인 수는 더하고, 약수의 개수가 홀수인 수는 뺀 수를 return 하도록 solution 함수를 완성해주세요.

    // 1 ≤ left ≤ right ≤ 1,000
    internal class _033_DivisorCountAdd {
        public int solution(int left, int right) {
            int answer = 0;
            for (int x = left; x <= right; x++) {
                int count = 0;
                for (int i = 1; i * i <= x; i++) {
                    if (i * i == x) count += 1;
                    else if (x % i == 0) count += 2;
                }
                if (count % 2 == 0) answer += x;
                else answer -= x;
            }
            return answer;
        }

    }
}
