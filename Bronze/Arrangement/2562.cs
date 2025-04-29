using System;
using System.Text;
using static System.Console;

namespace BackJoon
{
    // �ִ� 9���� ���� �ٸ� �ڿ��� �� �ִ��� ã�� �� ��° ������ ã�� ����
    // ����Ʈ�� List<int> a = new List<int>();
    // a.IndexOf(a.Max() + 1) �̷������� �ص� ��
    class _2562
    {
        static void Main()
        {
            int max = 0; // �ִ�
            int cnt = 0; // �� ��° �������� ����ϴ� ����
            int[] a = new int[9]; // ReadLine���� ���� ���ڸ� �����ϴ� �迭

            for (int i = 0; i < 9; i++)
            {
                int n = int.Parse(ReadLine()); // �Է��� �� �ٷ� �ް�
                a[i] = n;

                if (max < a[i])
                {
                    max = a[i]; // �ִ��� ����
                    cnt = i + 1; // �� ��° �ε������� ���� (+1�� �ϴ� ������ 0���� �����̶� 0 ~ 8��
                }
            }
            // ���
            WriteLine(max);
            WriteLine(cnt);

        }
    }
}