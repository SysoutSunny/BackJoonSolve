using System;
using System.Text;
using static System.Console;

namespace BackJoon
{
    // 공 넣기
    // 1 ~ N개의 바구니가 있음 바구니에 공 1개만 넣을 수 있음
    // M번 공을 넣음 -> 바구니 범위를 정하고 모두 같은 번호 공을 넣음 -> 공이 이미 있으면 그 공을 빼고 새로운 공을 넣음
    class _10810
    {
        static void Main()
        {
            int[] a = Array.ConvertAll(ReadLine().Split(), int.Parse);
            int n = a[0]; // 바구니 갯수
            int m = a[1]; // 공을 몇 번 넣을건지

            int[] basket = new int[n]; // 바구니 배열
            StringBuilder sb = new StringBuilder(); // 나중에 출력할 문자열

            for (int i = 0; i < m; i++)
            {
                int[] b = Array.ConvertAll(ReadLine().Split(), int.Parse); // x ~ y까지의 바구니 범위에서 z의 번호 공을 넣는 수를 저장
                int x = b[0]; // 바구니의 첫 번째부터 변수
                int y = b[1]; // 바구니의 마지막 변수
                int z = b[2]; // z번호를 넣을 변수
                // x부터 y까지 인데 바구니는 1번부터 시작이라
                for (int j = x - 1; j <= y - 1; j++)
                {
                    basket[j] = z;
                }
            }
            // 출력 (foreach로 배열을 순회하면서 출력)
            foreach (int num in basket)
            {
                Write(num + " ");
            }
        }
    }
}