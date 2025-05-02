using System;
using System.Globalization;
using System.Text;
using static System.Console;

namespace BackJoon
{
    // 공 바꾸기
    // 1 ~ N까지의 바구니에서 바구니와 같은 번호로 공을 넣음 M 번 공을 교환하는데 바구니 2개 선택해서 서로 위치 바꾸기
    //
    class _10813
    {
        static void Main()
        {
            int[] a = Array.ConvertAll(ReadLine().Split(), int.Parse);
            int n = a[0]; // 바구니 갯수 변수
            int m = a[1]; // 몇 번 스왑 할껀지 변수
            int[] basket = new int[n]; // 인덱스에 번호를 넣을 바구니 배열
            int temp = 0; // 스왑할때 임시 저장값

            // 바구니 갯수만큼 공 넣기
            for (int i = 0; i < n; i++)
            {
                basket[i] = i + 1;
            }
            // 몇 번 스왑 할껀지
            for (int j = 0; j < m; j++)
            {
                int[] b = Array.ConvertAll(ReadLine().Split(), int.Parse); // x ~ y 서로 스왑
                int x = b[0]; // x
                int y = b[1]; // y

                temp = basket[x - 1]; // ex) x = 1이고 y = 2면 temp는 일단 1로 저장하고 
                basket[x - 1] = basket[y - 1]; // 이러면 x = 2가 되고 y도 2인 상태
                basket[y - 1] = temp; // 이러면 x = 2 y는 1이 됨
            }

            // 출력문
            // foreach보다 string.Join(" ", basket); 해도 됨
            foreach (int num in basket)
            {
                Write(num + " ");
            }
        }
    }
}