using System;
using static System.Console;

namespace BackJoon
{
    // ���� �ð� �˶� �ð�� �ݴ�� ���ϴ� �����̴�.
    // Ư���� �� �ð��� �Է��ؼ� 17 40�� 80 ���ϸ� 19 00�� �Ǵ� ����
    class _2525
    {
        static void Main()
        {
            string[] s = ReadLine().Split();
            int h = int.Parse(s[0]); // �ð�
            int m = int.Parse(s[1]); // ��
            int hm; // 60���� ������ �ð��� ���� ����

            string s2 = ReadLine();
            int a = int.Parse(s2); // �Է¹޴� ��

            m += a; // �Է� �޴� �� ���ϱ�

            if (m >= 60)
            {
                hm = m / 60; // 60�� ���� ���� ���ؼ�
                m = m - 60 * hm;
                h += hm; // �ð��� ����

                if (h >= 24) // ���� �ð��� 24�ð��� �Ѿ�ٸ�
                {
                    h -= 24; // 00�÷� �ʱ�ȭ �ϱ� ���� -24�ð�
                }
            }

            WriteLine($"{h} {m}");
        }
    }
}