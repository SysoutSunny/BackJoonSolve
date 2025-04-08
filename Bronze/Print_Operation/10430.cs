using System;

namespace BackJoon
{
    // ������ ������ ���� ����
    // ���� ���ؼ� 46 x 36�� 30���� ���� ������? 16 x 6 = 96 �ϸ��
    class _10430
    {
        static void Main()
        {
            string[] s; // ���ڿ��� ���� �迭
            s = Console.ReadLine().Split(); //���ڿ� �а� ������

            // (A+B)%C
            Console.WriteLine(
            (int.Parse(s[0]) + int.Parse(s[1])) % int.Parse(s[2])
            );

            //((A%C) + (B%C)) % C
            Console.WriteLine(
            ((int.Parse(s[0]) % int.Parse(s[2])) + (int.Parse(s[1]) % int.Parse(s[2]))) % int.Parse(s[2])
            );
            // �Ұ�ȣ �ȽἭ ������ ���ϴ°� ���� ������ �ع��� ���� �߻�

            //(AxB)%C
            Console.WriteLine(
            (int.Parse(s[0]) * int.Parse(s[1])) % int.Parse(s[2])
            );

            //((A%C) x (B%C)) %C
            Console.WriteLine(
            (int.Parse(s[0]) % int.Parse(s[2])) * (int.Parse(s[1]) % int.Parse(s[2])) % int.Parse(s[2])
            );
        }
    }
}