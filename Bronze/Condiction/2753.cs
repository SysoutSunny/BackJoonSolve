using System;
using static System.Console;

namespace BackJoon
{
    // ���� ����ϱ� ������ 4�� ����鼭 100�� ����� �ƴ� �� �Ǵ� 400�� ��� �� �� ������
    class _2753
    {
        static void Main()
        {
            String s = ReadLine();
            int a = int.Parse(s);

            // 4�� ����̸鼭 100�� ����� �ƴ� ��� ���� (�������� ����Ͽ� �������� 0�̸� ���)
            if (a % 4 == 0 && a % 100 != 0)
            {
                WriteLine("1");
            }
            // 400�� ����̸� ����
            else if (a % 400 == 0)
            {
                WriteLine("1");
            }
            // �� �ٷ� �� �� ���� if(a % 4 == 0 && (a % 100 != 0 || a % 400 == 0))

            // �� ������ ���� �ƴϸ� ������ �ƴ�
            else
            {
                WriteLine("0");
            }
        }
    }
}