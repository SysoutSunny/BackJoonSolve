using System;
using static System.Console;

namespace BackJoon
{
    // �� ��� �ݺ����� �ܰ� ����
    // ���� �ݺ����� ��ķ� �����ϸ� ���ϴ�
    // ù ��° for�� i=0�� ����ǰ� �� ��° for���� �� ����ǰ� �ٽ� i�� ���½�

    class _2438
    {
        static void Main()
        {
            int n = int.Parse(ReadLine()); // �� N���� ���� ����

            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Write("*");
                }
                WriteLine();
            }
        }
    }
}