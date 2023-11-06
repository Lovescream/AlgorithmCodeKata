using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCodeKata {
    // 정수 배열 numbers가 주어집니다.
    // numbers에서 서로 다른 인덱스에 있는 두 개의 수를 뽑아 더해서 만들 수 있는 모든 수를 배열에 오름차순으로 담아 return 하도록 solution 함수를 완성해주세요.

    // numbers의 길이는 2 이상 100 이하입니다.
    // numbers의 모든 수는 0 이상 100 이하입니다.
    internal class _049_SelectTwoSum {
        private List<int> list = new List<int>();

        public int[] solution(int[] numbers) {
            Combine(numbers, 0, new List<int>());
            return list.OrderBy(x => x).ToArray();
        }

        private void Combine(int[] nums, int index, List<int> selected) {
            if (selected.Count == 2) {
                int sum = selected[0] + selected[1];
                if (!list.Contains(sum)) list.Add(sum);
                return;
            }
            for (int i = index; i < nums.Length; i++) {
                selected.Add(nums[i]);
                Combine(nums, i + 1, selected);
                selected.RemoveAt(selected.Count - 1);
            }
        }
    }
}
