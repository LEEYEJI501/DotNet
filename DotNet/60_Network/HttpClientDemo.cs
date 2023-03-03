using System;
using System.Net.Http;
using System.Threading.Tasks;

class HttpClientDemo
{
    static async Task Main()
    {
        // HttpClient 개체 생성
        HttpClient httpClient = new HttpClient();

        // GetAsync() 메서드 호출
        HttpResponseMessage httpResponseMessage = await httpClient.GetAsync("Http://www.microsoft.com/");

        // HTML 가져오기
        string responseBody = await httpResponseMessage.Content.ReadAsStringAsync();

        // 출력
        Console.WriteLine(responseBody);
    }
}