using System;
using System.Text;
using static System.Console;

namespace BackJoon
{
    // ���ڿ� ���ڿ�
    // String�� String�� ������ �ȴٸ� ���� Ǯ �� ����
    class _27866
    {
        static void Main()
        {
            string s = ReadLine(); // �Է� ���� �ܾ� S
            int i = int.Parse(ReadLine()); // �Է� ���� �� ��° ���ĺ����� ��Ÿ�� ����
            // ���
            WriteLine(s[i - 1]);
        }
    }
}