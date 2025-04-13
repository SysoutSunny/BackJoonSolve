using System;
using static System.Console;

namespace BackJoon
{
    // 구구단 N단을 입력 받으면 N단이 출력 되게 하는 것
    // 이 때 N은 1부터 9까지
    class _2739
    {
        static void Main()
        {
            int n = int.Parse(ReadLine());

            for (int i = 1; i < 10; i++)
            {
                WriteLine($"{n} * {i} = {n * i}");
            }
        }
    }
}