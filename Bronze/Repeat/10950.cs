using System;
using static System.Console;

namespace BackJoon
{
    // A + B - 3
    // �� ������ ���� �迭�� ��� �����ϴ��� ���
    // �ٵ� �ܼ��ϰ� for�� �ϳ��� �Ἥ �ߴµ� ������� �ϴ� ����� �̰��ε�?

    class _10950
    {
        static void Main()
        {
            int t = int.Parse(ReadLine()); // �� �� �ݺ����� ���� ����
            int[] a = new int[t]; // t���� ���� �迭 a
            int[] b = new int[t]; // t���� ���� �迭 b

            for (int i = 0; i < t; i++)
            {
                string[] s = ReadLine().Split();
                a[i] = int.Parse(s[0]); // a�� �迭�� ���ʴ�� t�� ��ŭ ���� ����
                b[i] = int.Parse(s[1]); // b�� �迭�� ���ʴ�� t�� ��ŭ ���� ����
            }
            //  ��¹�
            for (int i = 0; i < t; i++)
            {
                WriteLine(a[i] + b[i]);
            }
        }
    }
}