using System;
using System.Collections.Generic;
using System.Text;

namespace Telegram.Library
{
    public class Bot
    {
        private readonly object syncHandle = new object();
        public int Id { get; private set; }
        public string Token { get; set; }
        public string BaseRequestUrl => string.IsNullOrEmpty(Token) ?
            string.Empty : $"{TelegramBotClientConfiguration.BaseUrl}{Token}/";

        public (int, string) SetToken(string token)
        {
            if (string.IsNullOrEmpty(token)
                && !EnvironmentSettings.GetEnvironmentVariable("TELEGRAM_BOT_TOKEN", out token))
                throw new ArgumentNullException("Токен не может быть null или пустым", nameof(token));

            string[] parts = token.Split(':');
            if (parts.Length > 1 && int.TryParse(parts[0], out int id))
            {
                lock (syncHandle)
                {
                    Id = id;
                    Token = token;
                }
            }
            else
            {
                throw new ArgumentException(
                    "Ошибка формата. Валидный токен выглядит так \"1234567:4TT8bAc8GHUspu3ERYn-KGcvsvGB9u_n4ddy\".",
                    nameof(token)
                );
            }

            return (Id, Token);
        }

        public static string TryGetBaseRequestUrl(string token)
        {
            return TokenIsValid(token) ? $"{TelegramBotClientConfiguration.BaseUrl}{token}/" : null;
        }

        public static bool TokenIsValid(string token)
        {
            if (string.IsNullOrEmpty(token)) return false;
            string[] parts = token.Split(':');
            return parts.Length > 1 && int.TryParse(parts[0], out int id);
        }
    }
}
