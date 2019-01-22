using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Telegram.Client.Configurations
{
    public static class EnvironmentVariables
    {
        public const string BotToken = "BotToken";
        public const string Webhook = "Webhook";
        public const string SetWebhook = "SetWebhook";

        public static string GetEnvironmentVariable(string variable, string defaultValue = null)
        {
            var value = Environment.GetEnvironmentVariable(variable);
            return value ?? defaultValue;
        }
    }
}
