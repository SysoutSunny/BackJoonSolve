using System;
using static System.Console;

namespace BackJoon
{
    class _11382
    {
        static void Main()
        {
            string input = ReadLine();
            string[] s = input.Split(' '); // ������ �������� ���ڸ� ���ڿ��� ������
            WriteLine(long.Parse(s[0]) + long.Parse(s[1]) + long.Parse(s[2])); //���ڿ� �迭�� �ִ� ���ڵ��� ���ϱ�
            // int�� 32bit �������̴�. �� �ִ� 21����� �Ǵµ� ���� ������ 10^12 = 1������ ����� �ؾ��Ѵ�
            // �� Long 64bit �������� ��� 1800����� Ŀ�� �Ǵ� �����̴�.
        }
    }
}