using System;

namespace BackJoon
{
    class _1001
    {
        static void Main()
        {
            string[] s = Console.ReadLine().Split(); // ���ڿ��� �а� �����ϴ�.
            Console.WriteLine(int.Parse(s[0]) - int.Parse(s[1])); // 0��° ���ڿ� int 32��Ʈ �������� ����ȯ - 1��° ���ڿ� int 32��Ʈ �������� ����ȯ
        }
    }
}