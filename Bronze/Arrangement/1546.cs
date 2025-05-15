using System;
using System.Text;
using static System.Console;

namespace BackJoon
{
    // 평균
    // 숫자를 입력 받아서 점수의 갯수를 받고 그것 중에 최댓값을 찾아서 점수/최댓값*100을 한걸 모두 더해서 평균 구하는 문제
    // 처음에 문제 읽고 이해하기 빡셌음
    // 정수 / 정수는 소수점 이하는 전부 버리는 것까지 생각해야함
    class _1546
    {
        static void Main()
        {
            int n = int.Parse(ReadLine()); // 점수 몇 개 받을 지 입력
            double max = 0; // 최댓값 (실수인 이유는 이게 정수 / 정수 하면 소수점 이하는 다 버리기 때문에 0이 됨)
            double sum = 0; // 총합 (실수인 이유는 정수가 나올 수 있기 때문)

            double[] a = Array.ConvertAll(ReadLine().Split(), double.Parse);

            // 최댓값 찾기
            for (int i = 0; i < n; i++)
            {
                // 만약 최댓값보다 점수가 더 크면
                if (max < a[i])
                {
                    max = a[i]; // 그 값이 최댓값
                }
            }
            // 합계 구하기
            for (int j = 0; j < n; j++)
            {
                a[j] = a[j] / max * 100; // 계산식
                sum += a[j]; // 총합
            }
            // 출력
            WriteLine(sum / n);
        }
    }
}