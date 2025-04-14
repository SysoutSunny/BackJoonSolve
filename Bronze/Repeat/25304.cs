using System;
using static System.Console;

namespace BackJoon
{
    // ������
    // �� ���� ������ ���� X ������ ��� �� ���� ���� �Ϳ� ���� ������ Yes �ƴϸ� No�� ����ϴ� ����
    class _25304
    {
        static void Main()
        {
            int x = int.Parse(ReadLine()); // ���� �� ������ ������ �� �� �� ��
            int n = int.Parse(ReadLine()); // �������� ���� ������ ������ �� ����
            int sum = 0; // ��� �غôµ� ���� �� ��

            for (int i = 0; i < n; i++)
            {
                // ���� ��ȯ�� �ѹ��� �ϴ� ���
                int[] a = Array.ConvertAll(ReadLine().Split(), int.Parse); //��ȯ �� �迭, ��ȯ�� ���� ���� ��
                sum += a[0] * a[1]; // ���� a[0] (���� ����) * a[1](���� ����) �̴�.
                // int[]�� �ݺ����� �� �� �迭�� 0��° 1��°�� �ٲ�
            }

            // ���� ���� ������ ���� ������ ������ �� �����̶� �´ٸ�
            if (x == sum)
            {
                WriteLine("Yes");

            }
            // �ƴϸ�
            else
            {
                WriteLine("No");
            }
        }
    }
}