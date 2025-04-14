using System;
using System.Text;
using static System.Console;

namespace BackJoon
{
    // 코딩은 체육과목 입니다
    // long int는 4바이트, long long int는 8바이트를 저장하는 정수 자료형이다.
    // 4의 배수만큼 숫자를 입력하면 몫만큼 long이 출력하게 하는 문제
    class _25314
    {
        static void Main()
        {
            int n = int.Parse(ReadLine()); // 몇 바이트인지 입력할 정수
            int a = n / 4; // long을 몇 번 출력할 건지 몫을 저장하는 변수

            StringBuilder sb = new StringBuilder(); // StringBuilder 문자열 조작용 객체 이 때 이건 문자열 X
            // 쓰는 이유는 String은 불변(변하지 않음)이라 새로운 문자열을 +=로 하니 메모리 낭비가 심함
            // StringBuilder은 내부 버퍼 (미리 만들어진 배열) 를 이용하여 수정(관리)하기 좋음

            for (int i = 0; i < a; i++)
            {
                sb.Append("long "); // 문자열을 추가하기 위한 함수
            }
            sb.Append("int");

            WriteLine(sb.ToString()); // ToString()을 하는 이유는 결국 StringBuilder은 문자열이 아니기 때문에 문자열로 출력하고 싶으면 이렇게 해야함
        }
    }
}