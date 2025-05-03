using System;
using System.Globalization;
using System.Text;
using static System.Console;

namespace BackJoon
{
    // ������
    // 10�� ���� �Է� �ް� ��� 42�� ���� ���� �������� ���� �ٸ� ���� ������ ���ϴ� ����
    // �迭�� Distinct()�� ����ϸ� �迭�� �ߺ��� ���� �� ���� ���� ���ο� �迭�� ����� �����
    // .Count()�� �迭�� ũ�� ���� ��
    class _3052
    {
        static void Main()
        {
            int cnt = 0; // ���� �ٸ� �������� �� �� �ִ��� �� �� �ִ� ����
            bool[] istrue = new bool[42]; // 42�� ������ 42�� ���� �������� �׻� 42 �̸��� true�� �ε����� ������ �� ����

            // 10�� �Է� ���� 42�� ���� ������ ���� ����
            for (int i = 0; i < 10; i++)
            {
                istrue[int.Parse(ReadLine()) % 42] = true; // �̷��� 42ĭ¥�� bool �迭�� �ε��� �ߺ��� ���͵� true�� false �� �� �ϳ��� ��
            }

            for (int j = 0; j < istrue.Length; j++)
            {
                if (istrue[j] == true)
                {
                    cnt++; // ���� ����
                }
            }

            // ���
            WriteLine(cnt);
        }
    }
}