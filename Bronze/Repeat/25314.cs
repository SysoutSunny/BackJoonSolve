using System;
using System.Text;
using static System.Console;

namespace BackJoon
{
    // �ڵ��� ü������ �Դϴ�
    // long int�� 4����Ʈ, long long int�� 8����Ʈ�� �����ϴ� ���� �ڷ����̴�.
    // 4�� �����ŭ ���ڸ� �Է��ϸ� ��ŭ long�� ����ϰ� �ϴ� ����
    class _25314
    {
        static void Main()
        {
            int n = int.Parse(ReadLine()); // �� ����Ʈ���� �Է��� ����
            int a = n / 4; // long�� �� �� ����� ���� ���� �����ϴ� ����

            StringBuilder sb = new StringBuilder(); // StringBuilder ���ڿ� ���ۿ� ��ü �� �� �̰� ���ڿ� X
            // ���� ������ String�� �Һ�(������ ����)�̶� ���ο� ���ڿ��� +=�� �ϴ� �޸� ���� ����
            // StringBuilder�� ���� ���� (�̸� ������� �迭) �� �̿��Ͽ� ����(����)�ϱ� ����

            for (int i = 0; i < a; i++)
            {
                sb.Append("long "); // ���ڿ��� �߰��ϱ� ���� �Լ�
            }
            sb.Append("int");

            WriteLine(sb.ToString()); // ToString()�� �ϴ� ������ �ᱹ StringBuilder�� ���ڿ��� �ƴϱ� ������ ���ڿ��� ����ϰ� ������ �̷��� �ؾ���
        }
    }
}