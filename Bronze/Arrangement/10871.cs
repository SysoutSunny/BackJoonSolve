using System;
using System.Text;
using static System.Console;

namespace BackJoon
{
    // X보다 작은 수
    // 배열 크기와 입력 숫자를 입력하고 배열 안에 숫자가 입력 숫자보다 작은 값을 모두 출력
    class _10871
    {
        static void Main()
        {
            int[] a = Array.ConvertAll(ReadLine().Split(), int.Parse); // 배열 크기와 입력 숫자 입력할 배열
            // 굳이 이렇게 안하고 그냥 ReadLine().Split()을 2번 해도 되긴하네   
            int n = a[0]; // 배열 크기
            int x = a[1]; // 입력 숫자 (이거 보다 작은 숫자를 찾아야함)

            int[] b = Array.ConvertAll(ReadLine().Split(), int.Parse); // 배열 안에 숫자들 대입

            StringBuilder sb = new StringBuilder(); // 문자열 저장 했다가 나중에 한번에 출력 할 예정

            for (int i = 0; i < n; i++)
            {
                if (b[i] < x) // 배열 안의 숫자가 입력 숫자보다 작을 경우
                {
                    sb.Append(b[i] + " ");
                }
            }

            WriteLine(sb.ToString());
        }
    }
}