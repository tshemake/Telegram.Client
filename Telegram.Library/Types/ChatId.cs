using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Telegram.Library.Types
{
    [JsonConverter(typeof(ChatIdConverter))]
    public class ChatId
    {
        public readonly long ChatIdentifier;
        public readonly string ChannelUsername;

        public ChatId(long identifier)
        {
            ChatIdentifier = identifier;
        }

        public ChatId(string channelUsername)
        {
            if (channelUsername.Length > 1 && channelUsername.Substring(0, 1) == "@")
            {
                ChannelUsername = channelUsername;
            }
            else if (long.TryParse(channelUsername, out long identifier))
            {
                ChatIdentifier = identifier;
            }
            else
            {
                throw new ArgumentNullException("Не верный уникальный идентификатор чата или имя пользователя канала (в формате @username)", nameof(channelUsername));
            }
        }
    }


    internal class ChatIdConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var chatId = (ChatId)value;

            if (!string.IsNullOrEmpty(chatId.ChannelUsername))
            {
                writer.WriteValue(chatId.ChannelUsername);
            }
            else
            {
                writer.WriteValue(chatId.ChatIdentifier);
            }
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
                return null;

            var value = JToken.ReadFrom(reader).Value<string>();

            return new ChatId(value);
        }

        public override bool CanConvert(Type objectType)
            => typeof(ChatId).IsAssignableFrom(objectType);
    }
}
