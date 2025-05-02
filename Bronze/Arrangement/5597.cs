using System;
using System.Globalization;
using System.Text;
using static System.Console;

namespace BackJoon
{
    // ���� �� ���� ��...?
    // 1 ~ 30������ �л� �� ��ü������ ��ȸ�ؼ� �� �� 2���� �л��� ã�� ����
    // �ߺ� X ���� ������ ���
    class _5597
    {
        static void Main()
        {
            int[] n = new int[30]; // �� �л��� �迭
            int[] m = new int[30]; // ���ڸ� ã�� �迭

            // 30���� �л��� ���� �ִ� �ݺ���
            for (int i = 0; i < 30; i++)
            {
                n[i] = i + 1;
            }

            // 28���� �л��� �Է� �޴� �ݺ���
            for (int j = 0; j < 28; j++)
            {
                int k = int.Parse(ReadLine());
                m[j] = k;
            }

            // var�� ���� �ڷ��� �ڵ����� (���������� �ؾ��ϰ� ����� ���ÿ� �ʱ�ȭ�� �������)
            var except = n.Except(m);

            // ���
            foreach (int num in except)
            {
                WriteLine(num);
            }
        }
    }
}