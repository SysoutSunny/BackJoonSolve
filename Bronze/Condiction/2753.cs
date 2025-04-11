using System;
using static System.Console;

namespace BackJoon
{
    // 윤년 계산하기 윤년은 4의 배수면서 100의 배수가 아닐 때 또는 400의 배수 일 때 윤년임
    class _2753
    {
        static void Main()
        {
            String s = ReadLine();
            int a = int.Parse(s);

            // 4의 배수이면서 100의 배수가 아닌 경우 윤년 (나머지로 계산하여 나머지가 0이면 배수)
            if (a % 4 == 0 && a % 100 != 0)
            {
                WriteLine("1");
            }
            // 400의 배수이면 윤년
            else if (a % 400 == 0)
            {
                WriteLine("1");
            }
            // 한 줄로 쓸 수 있음 if(a % 4 == 0 && (a % 100 != 0 || a % 400 == 0))

            // 위 조건이 전부 아니면 윤년이 아님
            else
            {
                WriteLine("0");
            }
        }
    }
}