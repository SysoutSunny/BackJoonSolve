#include <iostream>
#include <string>

using namespace std;

int main()
{
    int cnt = 0; // 문자열 갯수를 세줄 변수
    string s;    // 입력 받는 문자열
    cin >> s;    // 입력받는 문자열

    cnt = s.size();

    // 출력
    cout << cnt << endl;
}