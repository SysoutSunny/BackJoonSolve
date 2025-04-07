using System;
using static System.Console;

//불기 연도를 서기 연도로 바꿔주는 프로그래밍
namespace BackJoon
{
    class _18108
    {
        static void Main()
        {
            string s = ReadLine(); //문자열 s 읽어오기
            int a = int.Parse(s); // int 형변환
            WriteLine(a - 543); //불기 -> 서기연도
        }
    }
}