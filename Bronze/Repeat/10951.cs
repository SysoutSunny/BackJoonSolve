using System;
using System.Text;
using static System.Console;

namespace BackJoon
{
    // A + B - 5 반복문이 계속 되다가 0 0이 들어오면 멈추기
    class _10951
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder(); // 문자열을 저장할 변수 (나중에 출력에 사용)

            while (true)
            {
                string s = ReadLine(); // 입력

                if (string.IsNullOrEmpty(s)) // Null 이거나 빈 공백일 경우
                {
                    break;
                }

                string[] s2 = s.Split(); // Split를 따로 하는 이유는 빈 배열을 반환해서 null이 됨

                int a = int.Parse(s2[0]);
                int b = int.Parse(s2[1]);
                sb.AppendLine((a + b).ToString()); // 문자열 더하기
            }

            Write(sb); // 출력
        }
    }
}