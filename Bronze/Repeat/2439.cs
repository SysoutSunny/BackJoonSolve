using System;
using static System.Console;

namespace BackJoon
{
    // �� ��� - 2
    // ������ ����� �ϴ°�
    // ��ó� �׳� ��ĭ�� �̷��� �ִ±���
    class _2439
    {
        static void Main()
        {
            int n = int.Parse(ReadLine()); // �� �� ���� �Է� ���� n

            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < n - i; j++) // ���� 5�� ��ĭ�� 4�� ������ �׷� �Է� ���� - i�� �ϸ� ��
                {
                    Write(" ");
                }
                for (int k = 0; k < i; k++) // ��ĭ�� ������ ���� �� ������ �Ȱ��� ���
                {
                    Write("*");
                }
                WriteLine(); // �ٹٲ�
            }

        }
    }
}