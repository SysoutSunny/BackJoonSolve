using System;
using System.Text;
using static System.Console;

namespace BackJoon
{
    // A + B - 5 반복문이 계속 되다가 0 0이 들어오면 멈추기
    class _10952
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder(); // 나중에 문자열을 한번에 출력할 변수

            while (true)
            {
                int[] t = Array.ConvertAll(ReadLine().Split(), int.Parse); // 입력 받을 숫자 배열

                if (t[0] == 0 && t[1] == 0) // t[0]이 0이며 t[1]이 0일 때 
                {
                    break; // 무한 루프 탈출
                }
                sb.AppendLine((t[0] + t[1]).ToString()); // 문자열 추가
            }

            Write(sb); // 출력
        }
    }
}