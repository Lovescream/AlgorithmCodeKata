using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCodeKata {
    // 머쓱이는 태어난 지 11개월 된 조카를 돌보고 있습니다.
    // 조카는 아직 "aya", "ye", "woo", "ma" 네 가지 발음과 네 가지 발음을 조합해서 만들 수 있는 발음밖에 하지 못하고 연속해서 같은 발음을 하는 것을 어려워합니다.
    // 문자열 배열 babbling이 매개변수로 주어질 때, 머쓱이의 조카가 발음할 수 있는 단어의 개수를 return하도록 solution 함수를 완성해주세요.

    // 1 ≤ babbling의 길이 ≤ 100
    // 1 ≤ babbling[i] 의 길이 ≤ 30
    // 문자열은 알파벳 소문자로만 이루어져 있습니다.
    internal class _062_Babble {
        public class Solution {
            public int solution(string[] babbling) {
                int count = 0;
                string[] sounds = { "aya", "ye", "woo", "ma" };

                foreach (string word in babbling) {
                    string tempWord = word;
                    string lastSound = "";
                    bool isValid = true;

                    while (tempWord.Length > 0 && isValid) {
                        bool found = false;

                        foreach (string sound in sounds) {
                            if (tempWord.StartsWith(sound)) {
                                if (sound == lastSound) {
                                    isValid = false;
                                    break;
                                }
                                lastSound = sound;
                                tempWord = tempWord.Substring(sound.Length);
                                found = true;
                                break;
                            }
                        }
                        if (!found) isValid = false;
                    }
                    if (isValid) count++;
                }
                return count;
            }
        }
    }
}
