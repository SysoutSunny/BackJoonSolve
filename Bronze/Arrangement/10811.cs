using System;
using System.Text;
using static System.Console;

namespace BackJoon
{
    // �ٱ��� ������
    // ���� ��ü�� �������� �ٱ��ϸ� �����ϴ� ����
    // while �����ϴ°� ������� ���� ��
    class _10811
    {
        static void Main()
        {
            int[] a = Array.ConvertAll(ReadLine().Split(), int.Parse); // ������ �������� ���������� ����ȯ & �о����
            int n = a[0]; // �ٱ��� ����
            int m = a[1]; // �� �� ���� �� ����
            int temp = 0; // �ڸ� �ٲ� �� ���� �ӽ� ����

            int[] basket = new int[n]; // �ٱ��� �迭

            // �ٱ��Ͽ� ���� �ֱ�
            for (int k = 0; k < n; k++)
            {
                basket[k] = k + 1;
            }
            // m�� ����
            for (int i = 0; i < m; i++)
            {
                int[] b = Array.ConvertAll(ReadLine().Split(), int.Parse); // x���� y���� ������ �����ؼ� ����
                int x = b[0] - 1;
                int y = b[1] - 1;

                // ������ ���� �ϱ�
                while (x < y) //(���� �� ������ x���� y���� �ݺ��ҷ���) (1 4) �� (0 3) (1 2) �����ϰ� (2 1) �� �� ���� 
                {
                    temp = basket[x]; // �ӽð��� ����
                    basket[x++] = basket[y]; // 1�� 4�� ù ��°�� 4��°�� �ٲٰ� x�� ����
                    basket[y--] = temp; // ���������� y�� ���� �ٲٰ� y�� ����
                }

            }
            // ���
            foreach (int num in basket)
            {
                Write(num + " ");
            }
        }
    }
}