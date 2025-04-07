using System;
using static System.Console;

namespace BackJoon
{
    class _1008
    {
        static void Main()
        {
            string[] s = ReadLine().Split();
            //double은 8바이트 float는 4바이트, double은 소수점 15자리까지 됨
            WriteLine(double.Parse(s[0]) / double.Parse(s[1])); //Double이여야함 float는 소수 7번째 자리만 다룰 수 있음
        }
    }
}