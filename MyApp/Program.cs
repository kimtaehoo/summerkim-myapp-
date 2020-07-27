using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace MyApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)  //웹 애플리케이션 실행을 위한 기본적인 실행
                .UseStartup<Startup>();
    }
}
