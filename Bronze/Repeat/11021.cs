using System;
using static System.Console;

namespace BackJoon
{
    // A+B�� ����?�ǰ� ���� ����
    class _11021
    {
        static void Main()
        {
            int t = int.Parse(ReadLine()); // �׽�Ʈ ���̽� ������ � �Է� �ϴ� ����
            int[] a = new int[t]; // A+B�� A�� �迭
            int[] b = new int[t]; // A+B�� B�� �迭
            int[] sum = new int[t]; // A+B�� �� �迭

            for (int i = 0; i < t; i++)
            {
                string[] s = ReadLine().Split();

                a[i] = int.Parse(s[0]); // a�迭�� ����
                b[i] = int.Parse(s[1]); // b�迭�� ����
                sum[i] = a[i] + b[i]; // A+B�� sum �迭�� ����
            }
            // ��¹�
            for (int i = 0; i < t; i++)
            {
                WriteLine($"Case #{i + 1}: " + sum[i]);
            }
        }
    }
}