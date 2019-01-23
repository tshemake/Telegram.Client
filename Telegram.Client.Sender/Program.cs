using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Telegram.Client.Sender.Infrastructure;

namespace Telegram.Client.Sender
{
    class Program
    {
        static int Main(string[] args)
        {
            try
            {
                MainAsync(args).GetAwaiter().GetResult();
                return 0;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex);
                return -1;
            }
        }

        static async Task MainAsync(string[] args)
        {
            var builder = new HostBuilder()
                .ConfigureAppConfiguration((hostingContext, config) =>
                {
                    config.AddEnvironmentVariables();

                    if (args != null)
                    {
                        config.AddCommandLine(args);
                    }
                })
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddOptions();

                    services.AddSingleton<IHostedService, DaemonService>();
                });

            await builder.RunConsoleAsync();
        }
    }
}
