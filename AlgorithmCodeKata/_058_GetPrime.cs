using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCodeKata {
    public class _058_GetPrime {
        // 주어진 숫자 중 3개의 수를 더했을 때 소수가 되는 경우의 개수를 구하려고 합니다.
        // 숫자들이 들어있는 배열 nums가 매개변수로 주어질 때,
        // nums에 있는 숫자들 중 서로 다른 3개를 골라 더했을 때 소수가 되는 경우의 개수를 return 하도록 solution 함수를 완성해주세요.

        // nums에 들어있는 숫자의 개수는 3개 이상 50개 이하입니다.
        // nums의 각 원소는 1 이상 1,000 이하의 자연수이며, 중복된 숫자가 들어있지 않습니다.

        public int solution(int[] nums) {
            int answer = 0;
            for (int i = 0; i < nums.Length; i++) {
                for (int j = i + 1; j < nums.Length; j++) {
                    for (int k = j + 1; k < nums.Length; k++) {
                        int sum = nums[i] + nums[j] + nums[k];
                        if (IsPrime(sum)) answer++;
                    }
                }
            }

            return answer;
        }
        private bool IsPrime(int num) {
            if (num <= 1) return false;
            for (int i = 2; i * i <= num; i++) {
                if (num % i == 0) return false;
            }
            return true;
        }
    }
}
