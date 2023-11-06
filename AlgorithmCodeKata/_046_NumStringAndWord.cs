using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCodeKata {
    // 네오와 프로도가 숫자놀이를 하고 있습니다. 네오가 프로도에게 숫자를 건넬 때 일부 자릿수를 영단어로 바꾼 카드를 건네주면 프로도는 원래 숫자를 찾는 게임입니다.
    // 다음은 숫자의 일부 자릿수를 영단어로 바꾸는 예시입니다.
    // 1478 → "one4seveneight"
    // 234567 → "23four5six7"
    // 10203 → "1zerotwozero3"
    // 이렇게 숫자의 일부 자릿수가 영단어로 바뀌어졌거나, 혹은 바뀌지 않고 그대로인 문자열 s가 매개변수로 주어집니다.
    // s가 의미하는 원래 숫자를 return 하도록 solution 함수를 완성해주세요.

    // 1 ≤ s의 길이 ≤ 50
    // s가 "zero" 또는 "0"으로 시작하는 경우는 주어지지 않습니다.
    // return 값이 1 이상 2,000,000,000 이하의 정수가 되는 올바른 입력만 s로 주어집니다.

    internal class _046_NumStringAndWord {
        public int solution(string s) {
            string[] words = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            int[] numbers = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            string resultString = "";

            string temp = "";
            for (int i = 0; i < s.Length; i++) {
                if (int.TryParse(s[i].ToString(), out int number)) {
                    resultString += number.ToString();
                    continue;
                }
                temp += s[i];
                int index = Array.IndexOf(words, temp);
                if (index == -1) continue;
                resultString += numbers[index].ToString();
                temp = "";
            }
            return int.Parse(resultString); ;
        }
    }
}
