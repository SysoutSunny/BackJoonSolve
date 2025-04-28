using System;
using System.Text;
using static System.Console;

namespace BackJoon
{
    // 개수 세기
    // 배열 안에 숫자를 찾고 그 숫자의 갯수가 몇 개인지 찾는 문제
    // 처음에 인덱스를 찾는 건줄 알고 뻘짓했네
    class _10807
    {
        static void Main()
        {
            int n = int.Parse(ReadLine()); // 배열의 크기를 입력하는 정수
            int[] a = new int[n]; // 배열 생성
            int cnt = 0; // 배열 안에 숫자가 몇 개 있는지 알려주는 변수

            a = Array.ConvertAll(ReadLine().Split(), int.Parse); // a를 공백을 기준으로 배열 안에 값을 넣고
            int b = int.Parse(ReadLine()); // 배열의 인덱스 값

            for (int i = 0; i < n; i++)
            {
                if (b == a[i]) // 만약 찾으려는 정수가 인덱스 배열 안에 있으면
                {
                    cnt++; // 갯수 증가
                }

            }

            WriteLine(cnt); // 출력
        }
    }
}