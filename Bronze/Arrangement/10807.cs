using System;
using System.Text;
using static System.Console;

namespace BackJoon
{
    // ���� ����
    // �迭 �ȿ� ���ڸ� ã�� �� ������ ������ �� ������ ã�� ����
    // ó���� �ε����� ã�� ���� �˰� �����߳�
    class _10807
    {
        static void Main()
        {
            int n = int.Parse(ReadLine()); // �迭�� ũ�⸦ �Է��ϴ� ����
            int[] a = new int[n]; // �迭 ����
            int cnt = 0; // �迭 �ȿ� ���ڰ� �� �� �ִ��� �˷��ִ� ����

            a = Array.ConvertAll(ReadLine().Split(), int.Parse); // a�� ������ �������� �迭 �ȿ� ���� �ְ�
            int b = int.Parse(ReadLine()); // �迭�� �ε��� ��

            for (int i = 0; i < n; i++)
            {
                if (b == a[i]) // ���� ã������ ������ �ε��� �迭 �ȿ� ������
                {
                    cnt++; // ���� ����
                }

            }

            WriteLine(cnt); // ���
        }
    }
}