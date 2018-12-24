using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Telegram.Library.Models
{
    /// <summary>
    /// Type of a <see cref="MessageEntity"/>
    /// </summary>
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
        public long Id { get; set; }

        /// <summary>
        /// Тип вложения.
        /// Могут быть ссылка (@username), hashtag, cashtag, bot_command, URL, email, 
        /// phone_number, bold (полужирный текст), italic (текст курсивом), code (моноширинная строка), 
        /// pre (блок предварительно форматированного текста), text_link (кликабельные URL-адреса),
        /// text_mention (для пользователей <see href="https://telegram.org/blog/edit#new-mentions">без usernames</see>)
        /// </summary>
        [Required]
        public MessageEntityType Type { get; set; }

        /// <summary>
        /// Смещение в кодовых единицах UTF-16 к началу объекта
        /// </summary>
        [Required]
        public int Offset { get; set; }

        /// <summary>
        /// Длина объекта в кодовых единицах UTF-16
        /// </summary>
        [Required]
        public int Length { get; set; }

        /// <summary>
        /// Необязательный. Только для «text_link», URL, который будет открыт после нажатия пользователем текста.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Необязательный. Только для «text_mention», указанный пользователем
        /// </summary>
        public User User { get; set; }
    }
}
