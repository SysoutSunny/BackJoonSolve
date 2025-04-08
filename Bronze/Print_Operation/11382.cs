using System;
using static System.Console;

namespace BackJoon
{
    class _11382
    {
        static void Main()
        {
            string input = ReadLine();
            string[] s = input.Split(' '); // 공백을 기준으로 문자를 문자열로 저장함
            WriteLine(long.Parse(s[0]) + long.Parse(s[1]) + long.Parse(s[2])); //문자열 배열에 있는 숫자들을 더하기
            // int는 32bit 정수형이다. 즉 최대 21억까지 되는데 문제 조건은 10^12 = 1조까지 계산을 해야한다
            // 즉 Long 64bit 정수형을 써야 1800경까지 커버 되는 문제이다.
        }
    }
}