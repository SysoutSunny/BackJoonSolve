using System;
using System.Globalization;
using System.Text;
using static System.Console;

namespace BackJoon
{
    // 나머지
    // 10개 값을 입력 받고 모두 42로 나눈 값의 나머지를 구해 다른 값의 갯수를 구하는 문제
    // 배열에 Distinct()를 사용하면 배열의 중복된 값을 한 개로 묶어 새로운 배열을 만드는 기능임
    // .Count()는 배열의 크기 세는 것
    class _3052
    {
        static void Main()
        {
            int cnt = 0; // 서로 다른 나머지가 몇 개 있는지 알 수 있는 변수
            bool[] istrue = new bool[42]; // 42인 이유는 42로 나눈 나머지는 항상 42 미만임 true인 인덱스의 갯수만 셀 예정

            // 10번 입력 받음 42로 나눈 나머지 값을 저장
            for (int i = 0; i < 10; i++)
            {
                istrue[int.Parse(ReadLine()) % 42] = true; // 이러면 42칸짜리 bool 배열에 인덱스 중복이 나와도 true나 false 둘 중 하나가 됨
            }

            for (int j = 0; j < istrue.Length; j++)
            {
                if (istrue[j] == true)
                {
                    cnt++; // 갯수 증가
                }
            }

            // 출력
            WriteLine(cnt);
        }
    }
}