using System; // �⺻ using ���� 
using static System.Console; // ���Ǹ� �̸� �س������μ� Console�� �տ� �� �ᵵ��

namespace BackJoon
{
    class MainProgram
    {
        static void Main() //���ι�
        {
            string[] s = ReadLine().Split(); // �Է� �� ���ڿ��� ������ �������� �ڸ���.
            WriteLine(int.Parse(s[0]) + int.Parse(s[1]));
        }
    }
}