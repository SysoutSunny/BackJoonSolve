using System;
using static System.Console;

namespace BackJoon
{
    // 두 수 비교하기
    // Switch문으로도 풀 수 있다. 
    // switch 조건에 a > 0을 걸고 case ture면 참
    // case false When a == 0이면 추가적인 조건문을 쓸 수 있다 이 때는 a가 0인 경우
    // default면 위 조건 두 개가 전부 아닌 경우
    class _1330
    {
        static void Main()
        {
            string[] s = ReadLine().Split();
            int a = int.Parse(s[0]);
            int b = int.Parse(s[1]);

            // a가 b보다 작다면 
            if (a < b)
            {
                WriteLine("<");
            }
            // a가 b보다 크다면
            else if (a > b)
            {
                WriteLine(">");
            }
            // 둘 중 아닌 경우는 전부 같다.
            else
            {
                WriteLine("==");
            }
        }
    }
}