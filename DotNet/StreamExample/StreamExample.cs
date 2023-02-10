using System;
using System.IO;
using System.Text;
using DotNet.StreamExample;

namespace DotNet.StreamExample
{
    class StreamExample
    {
        static void Main()
        {
            string fileName = "SaveFileStream.txt";

            StreamMethod streamMethod = new StreamMethod();
            // streamMethod.SaveByFileStream(fileName);
            streamMethod.SaveByStreamWriter(fileName);
        }
    }
}