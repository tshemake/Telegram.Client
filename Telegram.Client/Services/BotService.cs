using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Client.Configurations;
using Telegram.Library;

namespace Telegram.Client.Services
{
    public class BotService : IBotService
    {
        public BotService(BotConfiguration config)
        {
            Client = new TelegramBotClient(config.BotToken);
        }

        public TelegramBotClient Client { get; }
    }
}
