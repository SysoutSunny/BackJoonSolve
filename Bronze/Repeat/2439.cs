using System;
using static System.Console;

namespace BackJoon
{
    // 별 찍기 - 2
    // 역으로 별찍기 하는거
    // 답봤네 그냥 빈칸을 이렇게 넣는구나
    class _2439
    {
        static void Main()
        {
            int n = int.Parse(ReadLine()); // 몇 줄 찍을 입력 변수 n

            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < n - i; j++) // 만약 5면 빈칸이 4번 들어가야함 그럼 입력 변수 - i를 하면 됨
                {
                    Write(" ");
                }
                for (int k = 0; k < i; k++) // 빈칸이 들어갔으면 별은 전 문제와 똑같이 찍기
                {
                    Write("*");
                }
                WriteLine(); // 줄바꿈
            }

        }
    }
}