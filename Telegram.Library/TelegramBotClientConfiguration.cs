using System;
using System.Collections.Generic;
using System.Text;

namespace Telegram.Library
{
    public sealed class TelegramBotClientConfiguration
    {
        public static string BaseUrl => "https://api.telegram.org/bot";

        public static string BaseFileUrl => "https://api.telegram.org/file/bot";
    }
}
