using System;
using System.Text;
using static System.Console;

namespace BackJoon
{
    // 빠른 A+B
    // C#에서는 WriteLine 함수는 매 출력마다 flush 연산을 수행함
    // 버퍼링 : 입출력 작업을 한 바이트씩 하는 것이 아니라 블록 단위로 한 번에 많은 양의 데이터를 처리
    // 스트림 : 데이터의 연속적인 흐름을 나타내는 개념
    class _15552
    {
        static void Main()
        {
            int t = int.Parse(ReadLine()); // 몇 개 합을 나타내서 출력 할 건지
            int sum = 0; // 총 합
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < t; i++)
            {
                int[] a = Array.ConvertAll(ReadLine().Split(), int.Parse); // 숫자를 공백으로 나눠서 저장할 배열
                sum = a[0] + a[1]; // 총 합 = a[0]번째 배열 + a[1]번째 배열
                sb.AppendLine(sum.ToString()); // AppendLine은 문자열을 \n을 넣어서 추가해주는 방식 sum.ToString을 하는 이유는 Append 함수는 문자열만 가능하니까
            }
            WriteLine(sb.ToString());
        }
    }
}