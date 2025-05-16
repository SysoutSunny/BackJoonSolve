using System;
using System.Text;
using static System.Console;

namespace BackJoon
{
    // 문자와 문자열
    // String과 String의 성질만 안다면 쉽게 풀 수 있음
    class _27866
    {
        static void Main()
        {
            string s = ReadLine(); // 입력 받은 단어 S
            int i = int.Parse(ReadLine()); // 입력 받을 몇 번째 알파벳인지 나타낼 숫자
            // 출력
            WriteLine(s[i - 1]);
        }
    }
}