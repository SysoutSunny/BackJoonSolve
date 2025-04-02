using System; // 기본 using 정의 
using static System.Console; // 정의를 미리 해놓음으로서 Console을 앞에 안 써도됨

namespace BackJoon
{
    class MainProgram
    {
        static void Main() //메인문
        {
            string[] s = ReadLine().Split(); // 입력 된 문자열을 공백을 기준으로 자른다.
            WriteLine(int.Parse(s[0]) + int.Parse(s[1]));
        }
    }
}