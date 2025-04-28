using System;
using System.Text;
using static System.Console;

namespace BackJoon
{
    // 최소, 최대 N개의 정수 배열 안에 최솟값 최댓값 구하는 문제
    class _10818
    {
        static void Main()
        {
            int n = int.Parse(ReadLine()); // 배열의 크기
            int[] a = Array.ConvertAll(ReadLine().Split(), int.Parse); // 배열 안의 숫자
            int min = a[0]; // 최솟값
            int max = a[0]; // 최댓값

            // 이 방식 말고 여러 가지 방법이 있다 ex) Array.sort 하면 오름차순으로 정렬
            // List.Min() List.Max() 등등
            for (int i = 0; i < n; i++)
            {
                if (a[i] > max) // 최댓값 보다 큰 숫자면 
                {
                    max = a[i]; // 최댓값 변경
                }
                if (a[i] < min) // 최솟값 보다 작은 숫자면
                {
                    min = a[i]; // 최솟값 변경
                }
            }

            WriteLine(min + " " + max); // 출력
        }
    }
}