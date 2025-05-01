using System;
using System.Text;
using static System.Console;

namespace BackJoon
{
    // �� �ֱ�
    // 1 ~ N���� �ٱ��ϰ� ���� �ٱ��Ͽ� �� 1���� ���� �� ����
    // M�� ���� ���� -> �ٱ��� ������ ���ϰ� ��� ���� ��ȣ ���� ���� -> ���� �̹� ������ �� ���� ���� ���ο� ���� ����
    class _10810
    {
        static void Main()
        {
            int[] a = Array.ConvertAll(ReadLine().Split(), int.Parse);
            int n = a[0]; // �ٱ��� ����
            int m = a[1]; // ���� �� �� ��������

            int[] basket = new int[n]; // �ٱ��� �迭
            StringBuilder sb = new StringBuilder(); // ���߿� ����� ���ڿ�

            for (int i = 0; i < m; i++)
            {
                int[] b = Array.ConvertAll(ReadLine().Split(), int.Parse); // x ~ y������ �ٱ��� �������� z�� ��ȣ ���� �ִ� ���� ����
                int x = b[0]; // �ٱ����� ù ��°���� ����
                int y = b[1]; // �ٱ����� ������ ����
                int z = b[2]; // z��ȣ�� ���� ����
                // x���� y���� �ε� �ٱ��ϴ� 1������ �����̶�
                for (int j = x - 1; j <= y - 1; j++)
                {
                    basket[j] = z;
                }
            }
            // ��� (foreach�� �迭�� ��ȸ�ϸ鼭 ���)
            foreach (int num in basket)
            {
                Write(num + " ");
            }
        }
    }
}