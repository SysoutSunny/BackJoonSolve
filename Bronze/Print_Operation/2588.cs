using System;
using static System.Console;

namespace BackJoon
{

    class _2588
    {
        static void Main()
        {
            string s1; // 첫 번째 곱셈 받을 숫자
            s1 = ReadLine();
            int a = int.Parse(s1);

            string s2;
            s2 = ReadLine();
            int b = int.Parse(s2);
            // int.Parse()는 char을 int형변환을 하지 못함
            // ToString()을 사용하면 char을 string으로 형변환
            int x = int.Parse(s2[0].ToString()); // 1번째 숫자를 int 형변환
            int y = int.Parse(s2[1].ToString()); // 2번째 숫자를 int 형변환
            int z = int.Parse(s2[2].ToString()); // 3번째 숫자를 int 형변환

            WriteLine(a * z);
            WriteLine(a * y);
            WriteLine(a * x);
            WriteLine(a * b);
        }
    }
}