using System;
using static System.Console;

namespace BackJoon
{
    // 합 = N을 주었을 때 1부터 N까지의 합을 구하는 문제
    class _8393
    {
        static void Main()
        {
            int n = int.Parse(ReadLine()); // 입력받을 N
            int a = 0; // 저장할 변수 C#은 초기화를 해줘야 사용할 수 있다.

            for (int i = 1; i < n + 1; i++)
            {
                a += i;
            }

            WriteLine(a);
        }
    }
}