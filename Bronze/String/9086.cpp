#include <iostream>
#include <string>

using namespace std;

// ���ڿ�
// ���ڿ��� �Է¹ް� ó���� ���� ����ϴ� ������ ����
int main()
{
    int T;
    cin >> T; // �� �� �ݺ� �� ���� �Է� ����

    for (int i = 0; i < T; i++)
    {
        string s;
        char start, end; // ó���� ���� ��Ÿ���� �ܾ�
        cin >> s;        // �Է� �޴� ���ڿ�

        start = s[0];            // ���ڿ��� ù ��° �ܾ�
        end = s[s.length() - 1]; // ���ڿ��� ������ �ܾ�

        // ���
        cout << start << end << endl;
    }
}