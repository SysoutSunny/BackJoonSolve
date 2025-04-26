using System;
using static System.Console;

namespace BackJoon
{
    // 별 찍기 반복문의 단골 문제
    // 이중 반복문은 행렬로 생각하면 편하다
    // 첫 번째 for문 i=0이 실행되고 두 번째 for문이 다 실행되고 다시 i로 가는식

    class _2438
    {
        static void Main()
        {
            int n = int.Parse(ReadLine()); // 별 N개를 찍을 변수

            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Write("*");
                }
                WriteLine();
            }
        }
    }
}