using System;
using static System.Console;

namespace BackJoon
{

    class _2588
    {
        static void Main()
        {
            string s1; // ù ��° ���� ���� ����
            s1 = ReadLine();
            int a = int.Parse(s1);

            string s2;
            s2 = ReadLine();
            int b = int.Parse(s2);
            // int.Parse()�� char�� int����ȯ�� ���� ����
            // ToString()�� ����ϸ� char�� string���� ����ȯ
            int x = int.Parse(s2[0].ToString()); // 1��° ���ڸ� int ����ȯ
            int y = int.Parse(s2[1].ToString()); // 2��° ���ڸ� int ����ȯ
            int z = int.Parse(s2[2].ToString()); // 3��° ���ڸ� int ����ȯ

            WriteLine(a * z);
            WriteLine(a * y);
            WriteLine(a * x);
            WriteLine(a * b);
        }
    }
}