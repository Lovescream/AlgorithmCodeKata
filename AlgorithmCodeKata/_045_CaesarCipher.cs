using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCodeKata {
    // 어떤 문장의 각 알파벳을 일정한 거리만큼 밀어서 다른 알파벳으로 바꾸는 암호화 방식을 시저 암호라고 합니다.
    // 예를 들어 "AB"는 1만큼 밀면 "BC"가 되고, 3만큼 밀면 "DE"가 됩니다."z"는 1만큼 밀면 "a"가 됩니다.
    // 문자열 s와 거리 n을 입력받아 s를 n만큼 민 암호문을 만드는 함수, solution을 완성해 보세요.
    internal class _045_CaesarCipher {
        public string solution(string s, int n) {
            string answer = "";
            for (int i = 0; i < s.Length; i++) {
                if (s[i] == ' ') {
                    answer += " ";
                    continue;
                }
                int num = (int)s[i];
                if (65 <= num && num <= 90)
                    answer += (char)Push(num, n, 65, 90);
                else if (97 <= num && num <= 122)
                    answer += (char)Push(num, n, 97, 122);
            }


            return answer;
        }

        private int Push(int number, int distance, int min, int max) {
            number += distance;
            while (number > max) number = number - max + min - 1;
            return number;
        }
    }
}
