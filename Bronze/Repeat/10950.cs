using System;
using static System.Console;

namespace BackJoon
{
    // A + B - 3
    // 이 문제로 숫자 배열을 어떻게 생성하는지 배움
    // 다들 단순하게 for문 하나만 써서 했는데 문제대로 하는 방법은 이거인듯?

    class _10950
    {
        static void Main()
        {
            int t = int.Parse(ReadLine()); // 몇 번 반복문을 돌릴 건지
            int[] a = new int[t]; // t개의 정수 배열 a
            int[] b = new int[t]; // t개의 정수 배열 b

            for (int i = 0; i < t; i++)
            {
                string[] s = ReadLine().Split();
                a[i] = int.Parse(s[0]); // a의 배열에 차례대로 t개 만큼 숫자 저장
                b[i] = int.Parse(s[1]); // b의 배열에 차례대로 t개 만큼 숫자 저장
            }
            //  출력문
            for (int i = 0; i < t; i++)
            {
                WriteLine(a[i] + b[i]);
            }
        }
    }
}