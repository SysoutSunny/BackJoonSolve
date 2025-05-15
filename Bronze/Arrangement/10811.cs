using System;
using System.Text;
using static System.Console;

namespace BackJoon
{
    // 바구니 뒤집기
    // 범위 전체를 역순으로 바구니를 정렬하는 문제
    // while 이해하는게 어려워서 답을 봄
    class _10811
    {
        static void Main()
        {
            int[] a = Array.ConvertAll(ReadLine().Split(), int.Parse); // 공백을 기준으로 정수형으로 형변환 & 읽어오기
            int n = a[0]; // 바구니 갯수
            int m = a[1]; // 몇 번 실행 할 건지
            int temp = 0; // 자리 바꿀 때 쓰는 임시 번수

            int[] basket = new int[n]; // 바구니 배열

            // 바구니에 숫자 넣기
            for (int k = 0; k < n; k++)
            {
                basket[k] = k + 1;
            }
            // m번 실행
            for (int i = 0; i < m; i++)
            {
                int[] b = Array.ConvertAll(ReadLine().Split(), int.Parse); // x부터 y까지 범위를 지정해서 스왑
                int x = b[0] - 1;
                int y = b[1] - 1;

                // 리버스 역순 하기
                while (x < y) //(참이 될 때까지 x부터 y까지 반복할려고) (1 4) 면 (0 3) (1 2) 실행하고 (2 1) 될 때 종료 
                {
                    temp = basket[x]; // 임시값을 저장
                    basket[x++] = basket[y]; // 1과 4면 첫 번째와 4번째를 바꾸고 x를 증감
                    basket[y--] = temp; // 마찬가지로 y의 값을 바꾸고 y을 증감
                }

            }
            // 출력
            foreach (int num in basket)
            {
                Write(num + " ");
            }
        }
    }
}