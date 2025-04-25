using System;
using static System.Console;

namespace BackJoon
{
    // A+B를 세련?되게 적는 문제
    class _11021
    {
        static void Main()
        {
            int t = int.Parse(ReadLine()); // 테스트 케이스 갯수를 몇개 입력 하는 변수
            int[] a = new int[t]; // A+B의 A의 배열
            int[] b = new int[t]; // A+B의 B의 배열
            int[] sum = new int[t]; // A+B의 합 배열

            for (int i = 0; i < t; i++)
            {
                string[] s = ReadLine().Split();

                a[i] = int.Parse(s[0]); // a배열에 저장
                b[i] = int.Parse(s[1]); // b배열에 저장
                sum[i] = a[i] + b[i]; // A+B를 sum 배열에 저장
            }
            // 출력문
            for (int i = 0; i < t; i++)
            {
                WriteLine($"Case #{i + 1}: " + sum[i]);
            }
        }
    }
}