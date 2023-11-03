using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCodeKata {
    // 정수를 담고 있는 배열 arr의 평균값을 return하는 함수, solution을 완성해보세요.

    // arr은 길이 1 이상, 100 이하인 배열입니다.
    // arr의 원소는 -10,000 이상 10,000 이하인 정수입니다.

    internal class _012_Average {

        public double solution(int[] arr) {
            double average = 0;
            foreach (int i in arr) average += i;
            average /= arr.Length;
            return average;
        }
    }
}
