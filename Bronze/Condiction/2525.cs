using System;
using static System.Console;

namespace BackJoon
{
    // 오븐 시계 알람 시계와 반대로 더하는 문제이다.
    // 특이한 건 시간을 입력해서 17 40에 80 더하면 19 00이 되는 문제
    class _2525
    {
        static void Main()
        {
            string[] s = ReadLine().Split();
            int h = int.Parse(s[0]); // 시간
            int m = int.Parse(s[1]); // 분
            int hm; // 60분을 나눠서 시간에 더할 변수

            string s2 = ReadLine();
            int a = int.Parse(s2); // 입력받는 분

            m += a; // 입력 받는 분 더하기

            if (m >= 60)
            {
                hm = m / 60; // 60을 나눈 몫을 구해서
                m = m - 60 * hm;
                h += hm; // 시간에 더함

                if (h >= 24) // 만약 시간이 24시간이 넘어간다면
                {
                    h -= 24; // 00시로 초기화 하기 위해 -24시간
                }
            }

            WriteLine($"{h} {m}");
        }
    }
}