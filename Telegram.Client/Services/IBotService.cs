using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Library;

namespace Telegram.Client.Services
{
    public interface IBotService
    {
        TelegramBotClient Client { get; }
    }
}
