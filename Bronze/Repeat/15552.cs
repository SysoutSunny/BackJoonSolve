using System;
using System.Text;
using static System.Console;

namespace BackJoon
{
    // ���� A+B
    // C#������ WriteLine �Լ��� �� ��¸��� flush ������ ������
    // ���۸� : ����� �۾��� �� ����Ʈ�� �ϴ� ���� �ƴ϶� ��� ������ �� ���� ���� ���� �����͸� ó��
    // ��Ʈ�� : �������� �������� �帧�� ��Ÿ���� ����
    class _15552
    {
        static void Main()
        {
            int t = int.Parse(ReadLine()); // �� �� ���� ��Ÿ���� ��� �� ����
            int sum = 0; // �� ��
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < t; i++)
            {
                int[] a = Array.ConvertAll(ReadLine().Split(), int.Parse); // ���ڸ� �������� ������ ������ �迭
                sum = a[0] + a[1]; // �� �� = a[0]��° �迭 + a[1]��° �迭
                sb.AppendLine(sum.ToString()); // AppendLine�� ���ڿ��� \n�� �־ �߰����ִ� ��� sum.ToString�� �ϴ� ������ Append �Լ��� ���ڿ��� �����ϴϱ�
            }
            WriteLine(sb.ToString());
        }
    }
}