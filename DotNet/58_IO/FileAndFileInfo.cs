using System;
using System.Diagnostics;
using System.IO;

class FileAndFileInfo
{
    static void Main()
    {
        string file = "C:\\C#\\Temp\\Test.txt";

        // File 클래스: 정적 멤버 제공
        if (File.Exists(file))
        {
            Console.WriteLine("{0}", File.GetCreationTime(file));
            File.Copy(file, "C:\\C#\\Temp\\Test2.txt", true); // 파일 복사
        }

        // FileInfo 클래스: 인스턴스 멤버 제공
        FileInfo fi = new FileInfo(file);
        if(fi.Exists)
        {
            Console.WriteLine($"{fi.FullName}");
        }
    }
}