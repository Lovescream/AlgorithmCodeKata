﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCodeKata {
    // 한국중학교에 다니는 학생들은 각자 정수 번호를 갖고 있습니다.
    // 이 학교 학생 3명의 정수 번호를 더했을 때 0이 되면 3명의 학생은 삼총사라고 합니다.
    // 예를 들어, 5명의 학생이 있고, 각각의 정수 번호가 순서대로 -2, 3, 0, 2, -5일 때,
    // 첫 번째, 세 번째, 네 번째 학생의 정수 번호를 더하면 0이므로 세 학생은 삼총사입니다.
    // 또한, 두 번째, 네 번째, 다섯 번째 학생의 정수 번호를 더해도 0이므로 세 학생도 삼총사입니다.
    // 따라서 이 경우 한국중학교에서는 두 가지 방법으로 삼총사를 만들 수 있습니다.

    // 한국중학교 학생들의 번호를 나타내는 정수 배열 number가 매개변수로 주어질 때,
    // 학생들 중 삼총사를 만들 수 있는 방법의 수를 return 하도록 solution 함수를 완성하세요.

    // 3 ≤ number의 길이 ≤ 13
    // -1,000 ≤ number의 각 원소 ≤ 1,000
    // 서로 다른 학생의 정수 번호가 같을 수 있습니다.

    internal class _042_ThreeMusketeers {
        private int count;

        public int solution(int[] number) {
            Combine(number, 0, new List<int>());
            return count;
        }

        private void Combine(int[] nums, int index, List<int> selected) {
            if (selected.Count == 3) {
                if (selected[0] + selected[1] + selected[2] == 0) count++;
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
