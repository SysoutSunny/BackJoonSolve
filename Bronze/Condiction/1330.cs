using System;
using static System.Console;

namespace BackJoon
{
    // �� �� ���ϱ�
    // Switch�����ε� Ǯ �� �ִ�. 
    // switch ���ǿ� a > 0�� �ɰ� case ture�� ��
    // case false When a == 0�̸� �߰����� ���ǹ��� �� �� �ִ� �� ���� a�� 0�� ���
    // default�� �� ���� �� ���� ���� �ƴ� ���
    class _1330
    {
        static void Main()
        {
            string[] s = ReadLine().Split();
            int a = int.Parse(s[0]);
            int b = int.Parse(s[1]);

            // a�� b���� �۴ٸ� 
            if (a < b)
            {
                WriteLine("<");
            }
            // a�� b���� ũ�ٸ�
            else if (a > b)
            {
                WriteLine(">");
            }
            // �� �� �ƴ� ���� ���� ����.
            else
            {
                WriteLine("==");
            }
        }
    }
}