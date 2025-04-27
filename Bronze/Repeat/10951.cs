using System;
using System.Text;
using static System.Console;

namespace BackJoon
{
    // A + B - 5 �ݺ����� ��� �Ǵٰ� 0 0�� ������ ���߱�
    class _10951
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder(); // ���ڿ��� ������ ���� (���߿� ��¿� ���)

            while (true)
            {
                string s = ReadLine(); // �Է�

                if (string.IsNullOrEmpty(s)) // Null �̰ų� �� ������ ���
                {
                    break;
                }

                string[] s2 = s.Split(); // Split�� ���� �ϴ� ������ �� �迭�� ��ȯ�ؼ� null�� ��

                int a = int.Parse(s2[0]);
                int b = int.Parse(s2[1]);
                sb.AppendLine((a + b).ToString()); // ���ڿ� ���ϱ�
            }

            Write(sb); // ���
        }
    }
}