using System;
using static System.Console;

namespace BackJoon
{
    // �˶� �ð� �ð����� -45���� ���� �� 0 0�� ���� ���� 11 15�� �Ǿ���
    // �� ������ �����ȴ�..
    class _2884
    {
        static void Main()
        {
            string[] s1 = ReadLine().Split();
            int a = int.Parse(s1[0]); // �ð�
            int b = int.Parse(s1[1]); // ��

            // �п� 45���� �ϴ� ����
            b -= 45;

            // ���� ���� �������
            if (b < 0)
            {
                // 60���� ���ϰ� �ð� -1�� ����
                b += 60;
                a -= 1;
                // ���� �ð��� �������
                if (a < 0)
                {
                    // 24�ð��� ������
                    a += 24;
                }
            }
            // ��¹��� $�� ���̸� ���� �̷��� ��� �� �� �ִ�.
            WriteLine($"{a} {b}");
        }
    }
}