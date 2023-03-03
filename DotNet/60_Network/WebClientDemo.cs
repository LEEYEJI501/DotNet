using System;
using System.Net;
using System.Threading;

class WebClientDemo
{
    static void Main()
    {
        WebClient client = new WebClient();

        // 동기적으로 출력
        string google = client.DownloadString("http://www.google.co.kr");
        Console.WriteLine("Google : " + google.Substring(0, 10));

        string naver = client.DownloadString(new Uri("http://www.naver.com"));
        Console.WriteLine("Naver : " + naver.Substring(0, 10));

        // 비동기적으로 출력
        client.DownloadStringAsync(new Uri("http://www.dotnetkorea.com"));
        client.DownloadStringCompleted += Client_DownloadStringCompleted;
        Thread.Sleep(3000);
    }

    private static void Client_DownloadStringCompleted(object sender,
        DownloadStringCompletedEventArgs e)
    {
        string r = e.Result.Replace("\n", "").Substring(0, 10);
        Console.WriteLine($"DotNetKorea : {r}");
    }
}