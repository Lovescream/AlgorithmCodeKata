using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCodeKata {
    // 단어 s의 가운데 글자를 반환하는 함수, solution을 만들어 보세요. 단어의 길이가 짝수라면 가운데 두글자를 반환하면 됩니다.
    // s는 길이가 1 이상, 100이하인 스트링입니다.
    internal class _030_GetCenter {
        public string solution(string s) {
            return s.Substring((s.Length - 1) / 2, s.Length % 2 == 0 ? 2 : 1);
        }
    }
}
