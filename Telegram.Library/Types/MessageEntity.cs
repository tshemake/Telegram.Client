using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Telegram.Library.Types
{
    /// <summary>
    /// Type of a <see cref="MessageEntity"/>
    /// </summary>
    [JsonConverter(typeof(MessageEntityTypeConverter))]
    public enum MessageEntityType : byte
    {

        /// <summary>
        /// Unknown entity type
        /// </summary>
        Unknown = 0,

        /// <summary>
        /// A mentioned <see cref="User"/> (@username)
        /// </summary>
        Mention,

        /// <summary>
        /// A searchable Hashtag
        /// </summary>
        Hashtag,

        /// <summary>
        /// A Bot command
        /// </summary>
        BotCommand,

        /// <summary>
        /// An url
        /// </summary>
        Url,

        /// <summary>
        /// An email
        /// </summary>
        Email,

        /// <summary>
        /// Bold text
        /// </summary>
        Bold,

        /// <summary>
        /// Italic text
        /// </summary>
        Italic,

        /// <summary>
        /// Monowidth string
        /// </summary>
        Code,

        /// <summary>
        /// Monowidth block
        /// </summary>
        Pre,

        /// <summary>
        /// Clickable text urls
        /// </summary>
        TextLink,

        /// <summary>
        /// Mentions for a <see cref="User"/> without <see cref="User.Username"/>
        /// </summary>
        TextMention,

        /// <summary>
        /// Phone number
        /// </summary>
        PhoneNumber,

        /// <summary>
        /// A cashtag (e.g. $EUR, $USD) - $ followed by the short currency code
        /// </summary>
        Cashtag
    }

    /// <summary>
    /// Представляет вложение в текстовом сообщении. Например, хэштеги, имена usernames, URL и т.д.
    /// <see href="https://core.telegram.org/bots/api#messageentity"/>
    /// </summary>
    public class MessageEntity
    {
        [Key]
        [JsonIgnore]
        public long Id { get; set; }

        /// <summary>
        /// Тип вложения.
        /// Могут быть ссылка (@username), hashtag, cashtag, bot_command, URL, email, 
        /// phone_number, bold (полужирный текст), italic (текст курсивом), code (моноширинная строка), 
        /// pre (блок предварительно форматированного текста), text_link (кликабельные URL-адреса),
        /// text_mention (для пользователей <see href="https://telegram.org/blog/edit#new-mentions">без usernames</see>)
        /// </summary>
        [Required]
        [JsonProperty(Required = Required.Always)]
        public MessageEntityType Type { get; set; }

        /// <summary>
        /// Смещение в кодовых единицах UTF-16 к началу объекта
        /// </summary>
        [Required]
        [JsonProperty(Required = Required.Always)]
        public int Offset { get; set; }

        /// <summary>
        /// Длина объекта в кодовых единицах UTF-16
        /// </summary>
        [Required]
        [JsonProperty(Required = Required.Always)]
        public int Length { get; set; }

        /// <summary>
        /// Необязательный. Только для «text_link», URL, который будет открыт после нажатия пользователем текста.
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// Необязательный. Только для «text_mention», указанный пользователем
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public User User { get; set; }
    }

    internal class MessageEntityTypeConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var messageEntityType = (MessageEntityType)value;
            var convertedEntityType = messageEntityType.ToStringValue();
            writer.WriteValue(convertedEntityType);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            string value = JToken.ReadFrom(reader).Value<string>();
            return value.ToMessageType();
        }

        public override bool CanConvert(Type objectType) => typeof(MessageEntityType) == objectType;
    }

    internal static class MessageEntityTypeExtensions
    {

        internal static string ToStringValue(this MessageEntityType value) =>
            EnumToString.TryGetValue(value, out var messageEntityType)
                ? messageEntityType
                : throw new NotSupportedException();

        internal static MessageEntityType ToMessageType(this string value) =>
            StringToEnum.TryGetValue(value, out var messageEntityType)
                ? messageEntityType
                : MessageEntityType.Unknown;

        internal static readonly IDictionary<string, MessageEntityType> StringToEnum =
            new Dictionary<string, MessageEntityType>
            {
                { "mention", MessageEntityType.Mention },
                { "hashtag", MessageEntityType.Hashtag },
                { "bot_command", MessageEntityType.BotCommand },
                { "url", MessageEntityType.Url },
                { "email", MessageEntityType.Email },
                { "bold", MessageEntityType.Bold },
                { "italic", MessageEntityType.Italic },
                { "code", MessageEntityType.Code },
                { "pre", MessageEntityType.Pre },
                { "text_link", MessageEntityType.TextLink },
                { "text_mention", MessageEntityType.TextMention },
                { "phone_number", MessageEntityType.PhoneNumber },
                { "cashtag", MessageEntityType.Cashtag },
            };

        internal static readonly IDictionary<MessageEntityType, string> EnumToString =
            new Dictionary<MessageEntityType, string>
            {
                { MessageEntityType.Mention, "mention" },
                { MessageEntityType.Hashtag, "hashtag" },
                { MessageEntityType.BotCommand, "bot_command" },
                { MessageEntityType.Url, "url" },
                { MessageEntityType.Email, "email" },
                { MessageEntityType.Bold, "bold" },
                { MessageEntityType.Italic, "italic" },
                { MessageEntityType.Code, "code" },
                { MessageEntityType.Pre, "pre" },
                { MessageEntityType.TextLink, "text_link" },
                { MessageEntityType.TextMention, "text_mention" },
                { MessageEntityType.PhoneNumber, "phone_number" },
                { MessageEntityType.Cashtag, "cashtag" },
                { MessageEntityType.Unknown, "unknown" },
            };
    }
}
