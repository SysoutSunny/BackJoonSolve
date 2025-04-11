using System;
using static System.Console;

namespace BackJoon
{
    // 알람 시계 시간에서 -45분을 빼는 것 0 0이 자정 빼면 11 15가 되야함
    // 아 답지를 봐버렸다..
    class _2884
    {
        static void Main()
        {
            string[] s1 = ReadLine().Split();
            int a = int.Parse(s1[0]); // 시간
            int b = int.Parse(s1[1]); // 분

            // 분에 45분을 일단 빼기
            b -= 45;

            // 만약 분이 음수라면
            if (b < 0)
            {
                // 60분을 더하고 시간 -1을 해줌
                b += 60;
                a -= 1;
                // 만약 시간이 음수라면
                if (a < 0)
                {
                    // 24시간을 더해줌
                    a += 24;
                }
            }
            // 출력문에 $을 붙이면 값을 이렇게 출력 할 수 있다.
            WriteLine($"{a} {b}");
        }
    }
}