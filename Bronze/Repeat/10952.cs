using System;
using System.Text;
using static System.Console;

namespace BackJoon
{
    // A + B - 5 �ݺ����� ��� �Ǵٰ� 0 0�� ������ ���߱�
    class _10952
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder(); // ���߿� ���ڿ��� �ѹ��� ����� ����

            while (true)
            {
                int[] t = Array.ConvertAll(ReadLine().Split(), int.Parse); // �Է� ���� ���� �迭

                if (t[0] == 0 && t[1] == 0) // t[0]�� 0�̸� t[1]�� 0�� �� 
                {
                    break; // ���� ���� Ż��
                }
                sb.AppendLine((t[0] + t[1]).ToString()); // ���ڿ� �߰�
            }

            Write(sb); // ���
        }
    }
}