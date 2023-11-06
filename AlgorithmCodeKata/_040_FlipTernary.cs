using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCodeKata {
    // 자연수 n이 매개변수로 주어집니다. n을 3진법 상에서 앞뒤로 뒤집은 후, 이를 다시 10진법으로 표현한 수를 return 하도록 solution 함수를 완성해주세요.

    // n은 1 이상 100,000,000 이하인 자연수입니다.
    internal class _040_FlipTernary {
        public class Solution {
            public int solution(int n) {
                Stack<int> stack = new Stack<int>();

                while (n > 0) {
                    stack.Push(n % 3);
                    n /= 3;
                }

                int answer = 0;
                int temp = 1;
                while (stack.Count > 0) {
                    answer += stack.Pop() * temp;
                    temp *= 3;
                }

                return answer;
            }
        }
    }
}
