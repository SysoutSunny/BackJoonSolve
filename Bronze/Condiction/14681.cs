using System;
using static System.Console;

namespace BackJoon
{
    // ��и� ���� Quadrant 1 ~ 4�� ���� ������� ������� 1 = ++, 2 = -+, 3 = --, 4 = +- �̴�
    class _14681
    {
        static void Main()
        {
            int x = int.Parse(ReadLine()); // x��ǥ
            int y = int.Parse(ReadLine()); // y��ǥ

            // 1��и�
            if (x > 0 && y > 0)
            {
                WriteLine("1");
            }
            // 2��и�
            else if (x < 0 && y > 0)
            {
                WriteLine("2");
            }
            // 3��и�
            else if (x < 0 && y < 0)
            {
                WriteLine("3");
            }
            // 4��и�
            else
            {
                WriteLine("4");
            }

            // ��ø if���� Ȱ�� �� �� �ִ�.
            // ���÷� if (x > 0) �ϰ�
            // if (y > 0) �ϸ� 1��и�
            // if (y < 0) �ϸ� 4��и� �̷����̴�
        }
    }
}