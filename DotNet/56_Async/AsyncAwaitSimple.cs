using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;

class AsyncAwaitSimple
{
    // 비동기 메서드를 호출하는 DoAsync() 메서드를 생성할 때는 async 키워드를 붙임
    static async Task DoAsync()
    {
        using (var client = new HttpClient())
        {
            // .NET API의 비동기 메서드를 호출할 때 await 키워드를 붙임
            var r = await client.GetAsync(
                            "https://www.naver.com");
            var c = await r.Content.ReadAsStringAsync();

            Console.WriteLine(c);
        }
    }

    // Main() 메서드를 async 키워드를 붙여 비동기 메서드로 변경
    static async Task Main()
    {
        // 비동기 메서드를 호출할 때 await 키워드를 앞에 붙임
        await DoAsync();
    }
}