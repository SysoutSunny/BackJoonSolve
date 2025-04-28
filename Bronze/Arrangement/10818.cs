using System;
using System.Text;
using static System.Console;

namespace BackJoon
{
    // �ּ�, �ִ� N���� ���� �迭 �ȿ� �ּڰ� �ִ� ���ϴ� ����
    class _10818
    {
        static void Main()
        {
            int n = int.Parse(ReadLine()); // �迭�� ũ��
            int[] a = Array.ConvertAll(ReadLine().Split(), int.Parse); // �迭 ���� ����
            int min = a[0]; // �ּڰ�
            int max = a[0]; // �ִ�

            // �� ��� ���� ���� ���� ����� �ִ� ex) Array.sort �ϸ� ������������ ����
            // List.Min() List.Max() ���
            for (int i = 0; i < n; i++)
            {
                if (a[i] > max) // �ִ� ���� ū ���ڸ� 
                {
                    max = a[i]; // �ִ� ����
                }
                if (a[i] < min) // �ּڰ� ���� ���� ���ڸ�
                {
                    min = a[i]; // �ּڰ� ����
                }
            }

            WriteLine(min + " " + max); // ���
        }
    }
}