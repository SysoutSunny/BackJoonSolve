using System;
using static System.Console;

namespace BackJoon
{
    // ���� ����
    // A : 90 ~ 100, B : 80 ~ 89, C : 70 ~ 79, D : 60 ~ 69, ������ F 
    class _9498
    {
        static void Main()
        {
            string s = ReadLine();
            int a = int.Parse(s);

            // A : 90 ~ 100 &&���� ���� �� ���� ���� �� ��� A ���
            if (a >= 90 && a <= 100)
            {
                WriteLine("A");
            }
            // B : 80 ~ 89 &&���� ���� �� ���� ���� �� ��� B ���
            else if (a >= 80 && a <= 89)
            {
                WriteLine("B");
            }
            // C : 70 ~ 79 &&���� ���� �� ���� ���� �� ��� C ���
            else if (a >= 70 && a <= 79)
            {
                WriteLine("C");
            }
            // D : 60 ~ 69 &&���� ���� �� ���� ���� �� ��� A ���
            else if (a >= 60 && a <= 69)
            {
                WriteLine("D");
            }
            // �� �� ���� F
            else
            {
                WriteLine("F");
            }
        }
    }
}