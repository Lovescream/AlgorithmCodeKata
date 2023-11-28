using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCodeKata {
    public class _058_GetPrime {
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
