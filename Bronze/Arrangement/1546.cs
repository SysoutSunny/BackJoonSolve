using System;
using System.Text;
using static System.Console;

namespace BackJoon
{
    // ���
    // ���ڸ� �Է� �޾Ƽ� ������ ������ �ް� �װ� �߿� �ִ��� ã�Ƽ� ����/�ִ�*100�� �Ѱ� ��� ���ؼ� ��� ���ϴ� ����
    // ó���� ���� �а� �����ϱ� ������
    // ���� / ������ �Ҽ��� ���ϴ� ���� ������ �ͱ��� �����ؾ���
    class _1546
    {
        static void Main()
        {
            int n = int.Parse(ReadLine()); // ���� �� �� ���� �� �Է�
            double max = 0; // �ִ� (�Ǽ��� ������ �̰� ���� / ���� �ϸ� �Ҽ��� ���ϴ� �� ������ ������ 0�� ��)
            double sum = 0; // ���� (�Ǽ��� ������ ������ ���� �� �ֱ� ����)

            double[] a = Array.ConvertAll(ReadLine().Split(), double.Parse);

            // �ִ� ã��
            for (int i = 0; i < n; i++)
            {
                // ���� �ִ񰪺��� ������ �� ũ��
                if (max < a[i])
                {
                    max = a[i]; // �� ���� �ִ�
                }
            }
            // �հ� ���ϱ�
            for (int j = 0; j < n; j++)
            {
                a[j] = a[j] / max * 100; // ����
                sum += a[j]; // ����
            }
            // ���
            WriteLine(sum / n);
        }
    }
}