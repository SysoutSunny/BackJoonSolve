using System;
using static System.Console;

namespace BackJoon
{
    // ������ N���� �Է� ������ N���� ��� �ǰ� �ϴ� ��
    // �� �� N�� 1���� 9����
    class _2739
    {
        static void Main()
        {
            int n = int.Parse(ReadLine());

            for (int i = 1; i < 10; i++)
            {
                WriteLine($"{n} * {i} = {n * i}");
            }
        }
    }
}