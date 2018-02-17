using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace HelloWorldAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .PreferHostingUrls(true)
                .UseUrls("http://localhost:5001;")
                .UseStartup<Startup>()
                .Build();
    }
}
