﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCodeKata {

    // 수포자는 수학을 포기한 사람의 준말입니다.
    // 수포자 삼인방은 모의고사에 수학 문제를 전부 찍으려 합니다.
    // 수포자는 1번 문제부터 마지막 문제까지 다음과 같이 찍습니다.

    // 1번 수포자가 찍는 방식: 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, ...
    // 2번 수포자가 찍는 방식: 2, 1, 2, 3, 2, 4, 2, 5, 2, 1, 2, 3, 2, 4, 2, 5, ...
    // 3번 수포자가 찍는 방식: 3, 3, 1, 1, 2, 2, 4, 4, 5, 5, 3, 3, 1, 1, 2, 2, 4, 4, 5, 5, ...

    // 시험은 최대 10,000 문제로 구성되어있습니다.
    // 문제의 정답은 1, 2, 3, 4, 5중 하나입니다.
    // 가장 높은 점수를 받은 사람이 여럿일 경우, return하는 값을 오름차순 정렬해주세요.

    // 1번 문제부터 마지막 문제까지의 정답이 순서대로 들은 배열 answers가 주어졌을 때,
    // 가장 많은 문제를 맞힌 사람이 누구인지 배열에 담아 return 하도록 solution 함수를 작성해주세요.

    public class _057_MockTest {
        public int[] solution(int[] answers) {
            List<Tester> tester = new List<Tester> {
            new Tester(1, new int[] { 1, 2, 3, 4, 5 }),
            new Tester(2, new int[] { 2, 1, 2, 3, 2, 4, 2, 5 }),
            new Tester(3, new int[] { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 }),
        };
            int max = tester.Select(x => x.Score(answers)).Max(x => x);
            return tester.Where(x => x.Count == max).Select(x => x.Index).OrderBy(x => x).ToArray();
        }
        class Tester {
            public int Index { get; private set; }
            public int Count { get; private set; }
            private int[] how;

            public Tester(int index, int[] how) {
                Index = index;
                this.how = how;
            }

            public int Score(int[] answer) {
                for (int i = 0; i < answer.Length; i++)
                    if (how[i % how.Length] == answer[i]) Count++;
                return Count;
            }
        }
    }
}
