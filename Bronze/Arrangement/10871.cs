using System;
using System.Text;
using static System.Console;

namespace BackJoon
{
    // X���� ���� ��
    // �迭 ũ��� �Է� ���ڸ� �Է��ϰ� �迭 �ȿ� ���ڰ� �Է� ���ں��� ���� ���� ��� ���
    class _10871
    {
        static void Main()
        {
            int[] a = Array.ConvertAll(ReadLine().Split(), int.Parse); // �迭 ũ��� �Է� ���� �Է��� �迭
            // ���� �̷��� ���ϰ� �׳� ReadLine().Split()�� 2�� �ص� �Ǳ��ϳ�   
            int n = a[0]; // �迭 ũ��
            int x = a[1]; // �Է� ���� (�̰� ���� ���� ���ڸ� ã�ƾ���)

            int[] b = Array.ConvertAll(ReadLine().Split(), int.Parse); // �迭 �ȿ� ���ڵ� ����

            StringBuilder sb = new StringBuilder(); // ���ڿ� ���� �ߴٰ� ���߿� �ѹ��� ��� �� ����

            for (int i = 0; i < n; i++)
            {
                if (b[i] < x) // �迭 ���� ���ڰ� �Է� ���ں��� ���� ���
                {
                    sb.Append(b[i] + " ");
                }
            }

            WriteLine(sb.ToString());
        }
    }
}