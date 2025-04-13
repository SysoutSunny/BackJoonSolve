using System;
using static System.Console;

namespace BackJoon
{
    // 주사위 세개 같은 눈 3개면 10,000 + (같은 눈) x 1,000
    // 같은 눈 2개면 1,000 + (같은 눈) x 100
    // 모두 다른 눈 (가장 큰 눈) x 100

    // 이 문제를 쉽게 풀 수 있는데 오름차 순으로 정리해서 풀면 쉬워진다
    // 그 이유는 3 4 4면 첫 번째와 두 번째를 비교 3 == 4 or 두 번째와 세 번째를 비교 4 == 4를 한다면
    // 둘 중 하나가 같은 조건을 충족을 시킨다
    class _2525
    {
        static void Main()
        {
            string[] s = ReadLine().Split();
            int a = int.Parse(s[0]); // 주사위 1
            int b = int.Parse(s[1]); // 주사위 2
            int c = int.Parse(s[2]); // 주사위 3
            int d; // 같은눈 변수
            int money; // 출력할 돈

            // 주사위 3개가 같은 눈인 경우
            if (a == b && b == c)
            {
                d = a;
                money = 10_000 + d * 1_000;
            }

            // 주사위 2개가 같은 눈인 경우
            // a랑 b가 같은 경우
            // b랑 c가 같은 경우
            // c랑 a가 같은 경우
            else if (a == b)
            {
                d = a;
                money = 1_000 + d * 100;
            }
            else if (b == c)
            {
                d = b;
                money = 1_000 + d * 100;
            }
            else if (c == a)
            {
                d = c;
                money = 1_000 + d * 100;
            }
            // 주사위 3개가 모두 다른 경우
            // a가 b보다 큰 경우
            // b가 c보다 큰 경우
            else
            {
                // 첫 눈이 가장 큰 경우로 생각하고 d에 넣음
                d = a;
                // 만약 a보다 b가 더 크면 b가 최대값
                if (d < b)
                {
                    d = b;
                }
                // 만약 a보다 c가 더 크면 c가 최대값
                // 순서대로 내려오기 때문에 b가 c보다 더 크면도 가능함
                if (d < c)
                {
                    d = c;
                }
                money = d * 100;
            }

            WriteLine(money);
        }
    }
}