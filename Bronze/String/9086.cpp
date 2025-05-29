#include <iostream>
#include <string>

using namespace std;

// 문자열
// 문자열을 입력받고 처음과 끝을 출력하는 간단한 문제
int main()
{
    int T;
    cin >> T; // 몇 번 반복 할 건지 입력 변수

    for (int i = 0; i < T; i++)
    {
        string s;
        char start, end; // 처음과 끝을 나타내는 단어
        cin >> s;        // 입력 받는 문자열

        start = s[0];            // 문자열의 첫 번째 단어
        end = s[s.length() - 1]; // 문자열의 마지막 단어

        // 출력
        cout << start << end << endl;
    }
}