using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCodeKata {

    // 각에서 0도 초과 90도 미만은 예각, 90도는 직각, 90도 초과 180도 미만은 둔각 180도는 평각으로 분류합니다. 각 angle이 매개변수로 주어질 때 예각일 때 1, 직각일 때 2, 둔각일 때 3, 평각일 때 4를 return하도록 solution 함수를 완성해주세요.
    
    internal class _008_Protractor {
        public int solution(int angle) {
            if (angle <= 0) return -1;
            else if (angle < 90) return 1;
            else if (angle == 90) return 2;
            else if (angle < 180) return 3;
            else if (angle == 180) return 4;
            else return -1;
        }
    }
}
