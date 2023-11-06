using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCodeKata {
    // 행렬의 덧셈은 행과 열의 크기가 같은 두 행렬의 같은 행, 같은 열의 값을 서로 더한 결과가 됩니다.
    // 2개의 행렬 arr1과 arr2를 입력받아, 행렬 덧셈의 결과를 반환하는 함수, solution을 완성해주세요.

    // 행렬 arr1, arr2의 행과 열의 길이는 500을 넘지 않습니다.
    internal class _037_AdditionOfMatrices {
        public int[,] solution(int[,] arr1, int[,] arr2) {
            int[,] answer = new int[arr1.GetLength(0), arr1.GetLength(1)];
            for (int x = 0; x < arr1.GetLength(0); x++) {
                for (int y = 0; y < arr1.GetLength(1); y++) {
                    answer[x, y] = arr1[x, y] + arr2[x, y];
                }
            }
            return answer;
        }
    }
}
