using System;
using System.Globalization;
using System.Text;
using static System.Console;

namespace BackJoon
{
    // 과제 안 내신 분...?
    // 1 ~ 30까지의 학생 중 전체적으로 순회해서 안 낸 2명의 학생을 찾는 문제
    // 중복 X 작은 순으로 출력
    class _5597
    {
        static void Main()
        {
            int[] n = new int[30]; // 총 학생수 배열
            int[] m = new int[30]; // 숫자를 찾는 배열

            // 30개의 학생을 전부 넣는 반복문
            for (int i = 0; i < 30; i++)
            {
                n[i] = i + 1;
            }

            // 28명의 학생을 입력 받는 반복문
            for (int j = 0; j < 28; j++)
            {
                int k = int.Parse(ReadLine());
                m[j] = k;
            }

            // var은 변수 자료형 자동저장 (지역변수로 해야하고 선언과 동시에 초기화를 해줘야함)
            var except = n.Except(m);

            // 출력
            foreach (int num in except)
            {
                WriteLine(num);
            }
        }
    }
}