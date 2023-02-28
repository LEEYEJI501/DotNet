using System;

class GetFileNameDemo
{
    static void Main()
    {
        // 입력
        string dir = "c:\\C#\\Sample\\test.txt";
        string fullName = String.Empty;
        string name = "";
        string ext = name;

        // 처리
        fullName = dir.Substring(dir.LastIndexOf('\\') + 1);
        name = fullName.Substring(0, fullName.LastIndexOf("."));
        ext = fullName.Substring(fullName.LastIndexOf(".") + 1);

        // 출력
        Console.WriteLine($"전체 파일 이름 : {fullName}");
        Console.WriteLine($"순수 파일 이름 : {name}");
        Console.WriteLine($"확장자 : {ext}");
    }
}