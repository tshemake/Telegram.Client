using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Telegram.Client.Configurations;
using Telegram.Library;

namespace Telegram.Client
{
    using System.Threading;

    public class Program
    {
        public static void Main(string[] args)
        {
            var config = new ConfigurationBuilder()
                 .AddCommandLine(args)
                 .AddEnvironmentVariables()
                 .Build();
            ThrowIfInvalidBotToken(config[EnvironmentVariables.BotToken]);
            if ((config[EnvironmentVariables.SetWebhook]?.ToLowerInvariant() ?? "false") == "true")
            {
                ThrowIfInvalidUrl(config[EnvironmentVariables.Webhook]);
                var api = new TelegramBotClient(config[EnvironmentVariables.BotToken]);
                api.SetWebhookAsync(config[EnvironmentVariables.Webhook]).Wait();
            }
            else
            {
                CreateWebHostBuilder(args).Build().Run();
            }
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();

        public static void ThrowIfInvalidBotToken(string token)
        {
            var _token = token ?? throw new ArgumentNullException(nameof(token));
            string[] parts = _token.Split(':');
            if (parts.Length > 1 && int.TryParse(parts[0], out int id))
            {
                return;
            }

            throw new ArgumentException(
                "Invalid format. A valid token looks like \"1234567:4TT8bAc8GHUspu3ERYn-KGcvsvGB9u_n4ddy\".",
                    nameof(token));
        }

        public static void ThrowIfInvalidUrl(string url)
        {
            try
            {
                var u = new Uri(url);
            }
            catch (UriFormatException)
            {
                throw new ArgumentException(
                    "Invalid Webhook url",
                    nameof(url));
            }
        }
    }
}
