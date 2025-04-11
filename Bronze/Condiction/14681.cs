using System;
using static System.Console;

namespace BackJoon
{
    // 사분면 고르기 Quadrant 1 ~ 4는 ㄷ자 모양으로 순서대로 1 = ++, 2 = -+, 3 = --, 4 = +- 이다
    class _14681
    {
        static void Main()
        {
            int x = int.Parse(ReadLine()); // x좌표
            int y = int.Parse(ReadLine()); // y좌표

            // 1사분면
            if (x > 0 && y > 0)
            {
                WriteLine("1");
            }
            // 2사분면
            else if (x < 0 && y > 0)
            {
                WriteLine("2");
            }
            // 3사분면
            else if (x < 0 && y < 0)
            {
                WriteLine("3");
            }
            // 4사분면
            else
            {
                WriteLine("4");
            }

            // 중첩 if문을 활용 할 수 있다.
            // 예시로 if (x > 0) 하고
            // if (y > 0) 하면 1사분면
            // if (y < 0) 하면 4사분면 이런식이다
        }
    }
}