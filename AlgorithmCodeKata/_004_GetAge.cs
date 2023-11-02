using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCodeKata {

    // 머쓱이는 40살인 선생님이 몇 년도에 태어났는지 궁금해졌습니다. 나이 age가 주어질 때, 2022년을 기준 출생 연도를 return 하는 solution 함수를 완성해주세요.
    // 0 < age <= 120
    // 나이는 태어난 연도에 1살이며 1년마다 1씩 증가합니다.

    // 40살 2022
    // 39살 2021
    // 40-n살 2022-n
    // 1살 2022-39 = 1983
    // 2022 - (age - 1)


    internal class _004_GetAge {
        public int solution(int age) {
            return 2022 - (age - 1);
        }

    }
}
