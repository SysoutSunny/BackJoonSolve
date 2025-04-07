using System;
using static System.Console;

namespace BackJoon
{
    class _10869
    {
        static void Main()
        {
            string[] s;
            s = ReadLine().Split();
            WriteLine(int.Parse(s[0]) + int.Parse(s[1]));
            WriteLine(int.Parse(s[0]) - int.Parse(s[1]));
            WriteLine(int.Parse(s[0]) * int.Parse(s[1]));
            WriteLine(int.Parse(s[0]) / int.Parse(s[1]));
            WriteLine(int.Parse(s[0]) % int.Parse(s[1]));
            // int형인 이유는 몫과 나머지를 구하기 위해서
        }
    }
}