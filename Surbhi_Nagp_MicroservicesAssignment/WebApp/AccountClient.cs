using Microsoft.Extensions.Options;
using Steeltoe.CircuitBreaker.Hystrix;
using System.Net.Http;

namespace WebApp
{
    public class AccountClient : HystrixCommand<string>
    {
        ConfigSettings configSettings { get; set; }

        public AccountClient(IHystrixCommandOptions options, IOptions<ConfigSettings> configSettings)
            : base(options)
        {
            this.configSettings = configSettings.Value;
        }

        protected override string Run()
        {
            var client = new HttpClient();
            var response = client.GetAsync("https://localhost:7002/api/customer").Result;
            var data = response.Content.ReadAsStringAsync().Result;
            return data;
        }

        protected override string RunFallback()
        {
            return "Hey I am from fallback";
        }
    }
}
