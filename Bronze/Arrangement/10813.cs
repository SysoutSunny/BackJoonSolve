using System;
using System.Globalization;
using System.Text;
using static System.Console;

namespace BackJoon
{
    // �� �ٲٱ�
    // 1 ~ N������ �ٱ��Ͽ��� �ٱ��Ͽ� ���� ��ȣ�� ���� ���� M �� ���� ��ȯ�ϴµ� �ٱ��� 2�� �����ؼ� ���� ��ġ �ٲٱ�
    //
    class _10813
    {
        static void Main()
        {
            int[] a = Array.ConvertAll(ReadLine().Split(), int.Parse);
            int n = a[0]; // �ٱ��� ���� ����
            int m = a[1]; // �� �� ���� �Ҳ��� ����
            int[] basket = new int[n]; // �ε����� ��ȣ�� ���� �ٱ��� �迭
            int temp = 0; // �����Ҷ� �ӽ� ���尪

            // �ٱ��� ������ŭ �� �ֱ�
            for (int i = 0; i < n; i++)
            {
                basket[i] = i + 1;
            }
            // �� �� ���� �Ҳ���
            for (int j = 0; j < m; j++)
            {
                int[] b = Array.ConvertAll(ReadLine().Split(), int.Parse); // x ~ y ���� ����
                int x = b[0]; // x
                int y = b[1]; // y

                temp = basket[x - 1]; // ex) x = 1�̰� y = 2�� temp�� �ϴ� 1�� �����ϰ� 
                basket[x - 1] = basket[y - 1]; // �̷��� x = 2�� �ǰ� y�� 2�� ����
                basket[y - 1] = temp; // �̷��� x = 2 y�� 1�� ��
            }

            // ��¹�
            // foreach���� string.Join(" ", basket); �ص� ��
            foreach (int num in basket)
            {
                Write(num + " ");
            }
        }
    }
}