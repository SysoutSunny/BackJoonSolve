using System;

namespace BackJoon
{
    // 나머지 정리와 곱셈 정리
    // 쉽게 말해서 46 x 36을 30으로 나눈 나머지? 16 x 6 = 96 하면됨
    class _10430
    {
        static void Main()
        {
            string[] s; // 숫자열을 담을 배열
            s = Console.ReadLine().Split(); //문자열 읽고 나누기

            // (A+B)%C
            Console.WriteLine(
            (int.Parse(s[0]) + int.Parse(s[1])) % int.Parse(s[2])
            );

            //((A%C) + (B%C)) % C
            Console.WriteLine(
            ((int.Parse(s[0]) % int.Parse(s[2])) + (int.Parse(s[1]) % int.Parse(s[2]))) % int.Parse(s[2])
            );
            // 소괄호 안써서 나머지 구하는걸 곱셈 정리로 해버린 오류 발생

            //(AxB)%C
            Console.WriteLine(
            (int.Parse(s[0]) * int.Parse(s[1])) % int.Parse(s[2])
            );

            //((A%C) x (B%C)) %C
            Console.WriteLine(
            (int.Parse(s[0]) % int.Parse(s[2])) * (int.Parse(s[1]) % int.Parse(s[2])) % int.Parse(s[2])
            );
        }
    }
}