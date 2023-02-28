using System;
using System.IO;

class StreamWriterWriteLineDemo
{
    static void Main()
    {
        string data =
            "안녕하세요.\r\n반갑습니다." + Environment.NewLine + "또 만나요.";

        // C 드라이브에 Temp 폴더를 미리 생성
        StreamWriter sw = new StreamWriter("C:\\C#\\Temp\\Test.txt");

        // Write() 메서드: 저장
        sw.WriteLine(data);

        // StreamWrite 객체 생성했으면 반드시 닫기
        sw.Close();

        // 메모리 해제
        sw.Dispose();
    }
}