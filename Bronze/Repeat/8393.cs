using System;
using static System.Console;

namespace BackJoon
{
    // �� = N�� �־��� �� 1���� N������ ���� ���ϴ� ����
    class _8393
    {
        static void Main()
        {
            int n = int.Parse(ReadLine()); // �Է¹��� N
            int a = 0; // ������ ���� C#�� �ʱ�ȭ�� ����� ����� �� �ִ�.

            for (int i = 1; i < n + 1; i++)
            {
                a += i;
            }

            WriteLine(a);
        }
    }
}