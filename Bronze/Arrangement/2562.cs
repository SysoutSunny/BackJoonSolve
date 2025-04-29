using System;
using System.Text;
using static System.Console;

namespace BackJoon
{
    // 최댓값 9개의 서로 다른 자연수 중 최댓값을 찾고 몇 번째 수인지 찾는 문제
    // 리스트로 List<int> a = new List<int>();
    // a.IndexOf(a.Max() + 1) 이런식으로 해도 됨
    class _2562
    {
        static void Main()
        {
            int max = 0; // 최댓값
            int cnt = 0; // 몇 번째 변수인지 계산하는 변수
            int[] a = new int[9]; // ReadLine으로 받은 숫자를 저장하는 배열

            for (int i = 0; i < 9; i++)
            {
                int n = int.Parse(ReadLine()); // 입력을 한 줄로 받고
                a[i] = n;

                if (max < a[i])
                {
                    max = a[i]; // 최댓값을 변경
                    cnt = i + 1; // 몇 번째 인덱스인지 저장 (+1을 하는 이유는 0부터 시작이라 0 ~ 8임
                }
            }
            // 출력
            WriteLine(max);
            WriteLine(cnt);

        }
    }
}