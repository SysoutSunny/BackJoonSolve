using System;
using static System.Console;

namespace BackJoon
{
    class _1008
    {
        static void Main()
        {
            string[] s = ReadLine().Split();
            //double�� 8����Ʈ float�� 4����Ʈ, double�� �Ҽ��� 15�ڸ����� ��
            WriteLine(double.Parse(s[0]) / double.Parse(s[1])); //Double�̿����� float�� �Ҽ� 7��° �ڸ��� �ٷ� �� ����
        }
    }
}