using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot;

namespace Telegram.Client.Services
{
    public class BotService : IBotService
    {
        public BotService()
        {
            Client = new TelegramBotClient(GetEnvironmentVariable("BotToken"));
        }

        public TelegramBotClient Client { get; }

        public static string GetEnvironmentVariable(string variable, string defaultValue = null)
        {
            var value = Environment.GetEnvironmentVariable(variable);
            return value ?? defaultValue;
        }
    }
}
