using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCodeKata {
    // 나만의 카카오 성격 유형 검사지를 만들려고 합니다.
    // 성격 유형 검사는 다음과 같은 4개 지표로 성격 유형을 구분합니다.성격은 각 지표에서 두 유형 중 하나로 결정됩니다.

    // 1번 지표: 라이언형(R), 튜브형(T)
    // 2번 지표: 콘형(C), 프로도형(F)
    // 3번 지표: 제이지형(J), 무지형(M)
    // 4번 지표: 어피치형(A), 네오형(N)

    // 4개의 지표가 있으므로 성격 유형은 총 16(=2 x 2 x 2 x 2)가지가 나올 수 있습니다. 예를 들어, "RFMN"이나 "TCMA"와 같은 성격 유형이 있습니다.
    // 검사지에는 총 n개의 질문이 있고, 각 질문에는 아래와 같은 7개의 선택지가 있습니다.

    // 매우 비동의 / 비동의 / 약간 비동의 / 모르겠음 / 약간 동의 / 동의 / 매우 동의

    // 각 질문은 1가지 지표로 성격 유형 점수를 판단합니다.
    // 예를 들어, 어떤 한 질문에서 4번 지표로 아래 표처럼 점수를 매길 수 있습니다.

    // 매우 비동의: 네오형 +3
    // 비동의: 네오형 +2
    // 약간 비동의: 네오형 +1
    // 모르겠음: (어떤 성격 유형도 점수를 얻지 않음)
    // 약간 동의: 어피치형 +1
    // 동의: 어피치형 +2
    // 매우 동의: 어피치형 +3

    // 이때 검사자가 질문에서 약간 동의 선택지를 선택할 경우 어피치형(A) 성격 유형 1점을 받게 됩니다.
    // 만약 검사자가 매우 비동의 선택지를 선택할 경우 네오형(N) 성격 유형 3점을 받게 됩니다.

    // 위 예시처럼 네오형이 비동의, 어피치형이 동의인 경우만 주어지지 않고, 질문에 따라 네오형이 동의, 어피치형이 비동의인 경우도 주어질 수 있습니다.
    // 하지만 각 선택지는 고정적인 크기의 점수를 가지고 있습니다.

    // 매우 동의, 매우 비동의: +3
    // 동의, 비동의: +2
    // 약곤 동의, 약간 비동의: +1
    // 모르겠음: 점수를 얻지 않음

    // 검사 결과는 모든 질문의 성격 유형 점수를 더하여 각 지표에서 더 높은 점수를 받은 성격 유형이 검사자의 성격 유형이라고 판단합니다.
    // 단, 하나의 지표에서 각 성격 유형 점수가 같으면, 두 성격 유형 중 사전 순으로 빠른 성격 유형을 검사자의 성격 유형이라고 판단합니다.

    // 질문마다 판단하는 지표를 담은 1차원 문자열 배열 survey와 검사자가 각 질문마다 선택한 선택지를 담은 1차원 정수 배열 choices가 매개변수로 주어집니다.
    // 이때, 검사자의 성격 유형 검사 결과를 지표 번호 순서대로 return 하도록 solution 함수를 완성해주세요.

    // 1 ≤ survey의 길이(=n) ≤ 1,000
    // survey의 원소는 "RT", "TR", "FC", "CF", "MJ", "JM", "AN", "NA" 중 하나입니다.
    // survey[i] 의 첫 번째 캐릭터는 i + 1번 질문의 비동의 관련 선택지를 선택하면 받는 성격 유형을 의미합니다.
    // survey[i] 의 두 번째 캐릭터는 i + 1번 질문의 동의 관련 선택지를 선택하면 받는 성격 유형을 의미합니다.

    // choices의 길이 = survey의 길이
    // choices[i] 는 검사자가 선택한 i + 1번째 질문의 선택지를 의미합니다.
    // 1 ≤ choices의 원소 ≤ 7
    // choices: (1: 매우 비동의), (2: 비동의), (3: 약간 비동의), (4: 모르겠음), (5: 약간 동의), (6: 동의), (7: 매우 동의)

    public class _069_PersonalityTypeTest : KataBase {

        public string solution(string[] survey, int[] choices) {
            char[] types = { 'R', 'T', 'C', 'F', 'J', 'M', 'A', 'N' };
            Dictionary<char, int> scores = types.ToDictionary(key => key, value => 0);
            int[] getScores = { 3, 2, 1, 0, 1, 2, 3 };

            for (int i = 0; i < survey.Length; i++) {
                scores[survey[i][choices[i] <= 3 ? 0 : 1]] += getScores[choices[i] - 1];
            }

            char[] resultTypes = new char[4];
            for (int i = 0; i < resultTypes.Length; i++) {
                resultTypes[i] = scores[types[2 * i]] >= scores[types[2 * i + 1]] ? types[2 * i] : types[2 * i + 1];
            }

            return new string(resultTypes);
        }

        public override void Example() {
            string[] survey = { "AN", "CF", "MJ", "RT", "NA" };
            int[] choices = { 5, 3, 2, 7, 5 };
            Console.WriteLine(solution(survey, choices));
        }
    }
}
