using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCodeKata {

    // 정수 num1과 num2가 매개변수로 주어질 때, num1을 num2로 나눈 값에 1,000을 곱한 후 정수 부분을 return 하도록 soltuion 함수를 완성해주세요.
    // num1 < 0 <= 100
    // num2 < 0 <= 100

    internal class _007_DivideNum {
        public int solution(int num1, int num2) => (int)(num1 / (float)num2 * 1000);
    }
}
