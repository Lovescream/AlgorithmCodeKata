using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCodeKata {
    // 이 문제에는 표준 입력으로 두 개의 정수 n과 m이 주어집니다.
    // 별(*) 문자를 이용해 가로의 길이가 n, 세로의 길이가 m인 직사각형 형태를 출력해보세요.

    // n과 m은 각각 1000 이하인 자연수입니다.
    internal class _038_RectangularStar {
        public static void Mai2n() {
            String[] s;

            Console.Clear();
            s = Console.ReadLine().Split(' ');

            int a = Int32.Parse(s[0]);
            int b = Int32.Parse(s[1]);

            for (int x = 0; x < b; x++) {
                for (int y = 0; y < a; y++) {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
    }
}
