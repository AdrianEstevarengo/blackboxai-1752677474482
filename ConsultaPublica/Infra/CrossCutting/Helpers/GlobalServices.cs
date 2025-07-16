using Microsoft.Extensions.Configuration;

namespace Infra.CrossCutting.Common
{
    public static class GlobalServices
    {
        public static HttpClient? HttpClient { get; set; }
        public static IConfiguration? Configuration { get; set; }

        public static void Configure(HttpClient httpClient, IConfiguration configuration)
        {
            HttpClient = httpClient;
            Configuration = configuration;
        }
    }
}