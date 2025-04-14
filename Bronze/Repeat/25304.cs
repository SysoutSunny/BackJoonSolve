using System;
using static System.Console;

namespace BackJoon
{
    // 영수증
    // 총 합이 물건의 갯수 X 가격을 모두 한 것을 더한 것에 합이 맞으면 Yes 아니면 No를 출력하는 문제
    class _25304
    {
        static void Main()
        {
            int x = int.Parse(ReadLine()); // 내가 산 물건의 가격을 비교 할 총 합
            int n = int.Parse(ReadLine()); // 영수증에 적힌 구매한 물건의 총 갯수
            int sum = 0; // 계산 해봤는데 나온 총 합

            for (int i = 0; i < n; i++)
            {
                // 형식 변환을 한번에 하는 방법
                int[] a = Array.ConvertAll(ReadLine().Split(), int.Parse); //변환 할 배열, 변환할 형식 쓰면 됨
                sum += a[0] * a[1]; // 합은 a[0] (물건 가격) * a[1](물건 갯수) 이다.
                // int[]이 반복문을 할 때 배열의 0번째 1번째가 바뀜
            }

            // 만약 내가 예상한 가격 총합이 물건을 산 총합이랑 맞다면
            if (x == sum)
            {
                WriteLine("Yes");

            }
            // 아니면
            else
            {
                WriteLine("No");
            }
        }
    }
}