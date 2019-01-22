using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using DryIoc;
using DryIoc.Microsoft.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json.Serialization;
using Telegram.Client.Configurations;
using Telegram.Client.Ioc;
using Telegram.Client.Services;

namespace Telegram.Client
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        private static IServiceProvider Container { get; set; }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2).AddJsonOptions(
                options =>
                {
                    options.SerializerSettings.ContractResolver = new DefaultContractResolver()
                    {
                        NamingStrategy = new SnakeCaseNamingStrategy()
                    };
                });

            var botConfiguration = new BotConfiguration
            {
                BotToken = EnvironmentVariables.GetEnvironmentVariable(EnvironmentVariables.BotToken)
            };
            var container = new Container(rules => rules.WithoutThrowOnRegisteringDisposableTransient());
            container.UseInstance(botConfiguration);

            Ioc.Services.Load(container);

            var serviceProvider = container.WithDependencyInjectionAdapter(services, throwIfUnresolved: type => true);
            Container = serviceProvider.BuildServiceProvider();
            return Container;
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
            }

            app.UseMvc();
        }
    }
}
