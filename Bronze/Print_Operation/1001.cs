using System;

namespace BackJoon
{
    class _1001
    {
        static void Main()
        {
            string[] s = Console.ReadLine().Split(); // 문자열을 읽고 나눕니다.
            Console.WriteLine(int.Parse(s[0]) - int.Parse(s[1])); // 0번째 문자열 int 32비트 형식으로 형변환 - 1번째 문자열 int 32비트 형식으로 형변환
        }
    }
}