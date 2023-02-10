using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.StreamExample
{
    public class StreamMethod
    {
        private string strData = "1.This\n2.is\n3.Test";
        private string[] arrData = { "1.This", "2.is", "3.Test" };

        // 폴더 경로 지정
        private const string path = @"D:\"; // @ 뒤에 있는 string은 디렉터리를 표시

        // 1. FileStream
        public void SaveByFileStream(string fileName)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(path);
            sb.Append("/");
            sb.Append(fileName);

            try
            {
                FileStream fs = new FileStream(sb.ToString(), FileMode.Create, FileAccess.Write);

                byte[] bytes = Encoding.UTF8.GetBytes(strData);
                fs.Write(bytes, 0, bytes.Length);
                fs.Close();
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine("폴더가 없습니다. 폴더를 생성합니다.");
                Directory.CreateDirectory(path);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            Console.WriteLine("저장 완료");
        }
    }
}
