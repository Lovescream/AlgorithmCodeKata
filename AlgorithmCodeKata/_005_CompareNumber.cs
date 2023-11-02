using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCodeKata {
    // 정수 num1과 num2가 매개변수로 주어집니다. 두 수가 같으면 1 다르면 -1을 retrun하도록 solution 함수를 완성해주세요.
    // 0 <= num1 <= 10,000
    // 0 <= num2 <= 10,000
    internal class _005_CompareNumber {

        public int solution(int num1, int num2) {
            return num1 == num2 ? 1 : -1;
        }

    }
}
