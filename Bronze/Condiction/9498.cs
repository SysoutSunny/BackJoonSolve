using System;
using static System.Console;

namespace BackJoon
{
    // 시험 성적
    // A : 90 ~ 100, B : 80 ~ 89, C : 70 ~ 79, D : 60 ~ 69, 나머지 F 
    class _9498
    {
        static void Main()
        {
            string s = ReadLine();
            int a = int.Parse(s);

            // A : 90 ~ 100 &&으로 조건 두 개를 충족 할 경우 A 출력
            if (a >= 90 && a <= 100)
            {
                WriteLine("A");
            }
            // B : 80 ~ 89 &&으로 조건 두 개를 충족 할 경우 B 출력
            else if (a >= 80 && a <= 89)
            {
                WriteLine("B");
            }
            // C : 70 ~ 79 &&으로 조건 두 개를 충족 할 경우 C 출력
            else if (a >= 70 && a <= 79)
            {
                WriteLine("C");
            }
            // D : 60 ~ 69 &&으로 조건 두 개를 충족 할 경우 A 출력
            else if (a >= 60 && a <= 69)
            {
                WriteLine("D");
            }
            // 그 외 전부 F
            else
            {
                WriteLine("F");
            }
        }
    }
}