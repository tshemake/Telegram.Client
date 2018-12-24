using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Telegram.Library.Models
{
    /// <summary>
    /// Тип чата <see cref="Chat"/>
    /// </summary>
    public enum ChatType : byte
    {
        /// <summary>
        /// Normal one to one <see cref="Chat"/>
        /// </summary>
        Private,

        /// <summary>
        /// Normal groupchat
        /// </summary>
        Group,

        /// <summary>
        /// A channel
        /// </summary>
        Channel,

        /// <summary>
        /// A supergroup
        /// </summary>
        Supergroup
    }

    /// <summary>
    /// Чат.
    /// <see href="https://core.telegram.org/bots/api#chat"/>
    /// </summary>
    public class Chat
    {
        [Key]
        public long Id { get; set; }

        /// <summary>
        /// Уникальный идентификатор для этого чата.
        /// <see href="https://core.telegram.org/bots/api#chat"/>
        /// </summary>
        /// <remarks>
        /// Это число может быть больше 32 бит, но меньше 52 бит.
        /// </remarks>
        [Required]
        public long UniqueChatId { get; set; }

        /// <summary>
        /// Тип чата может быть «private», «group», «supergroup» или «channel»
        /// </summary>
        [Required]
        public ChatType Type { get; set; }

        /// <summary>
        /// Необязательный. Название, для «supergroup», «channel» и «group» чатов
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Необязательный. Имя пользователя, для «private» чатов, «supergroup», «channel», если доступно
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Необязательный. FirstName собеседника в «private» чате
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Необязательный. LastName другой стороны в «private» чате
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Необязательный. Все участники группы являются администраторами?
        /// </summary>
        public bool AllMembersAreAdministrators { get; set; }

        /// <summary>
        /// Необязательный. Фото чата.
        /// </summary>
        public ChatPhoto Photo { get; set; }

        /// <summary>
        /// Необязательный. Описание, для «supergroup» и «channel».
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Необязательный. Инвайт ссылка на чат, для «supergroup» и «channel».
        /// </summary>
        public string InviteLink { get; set; }

        /// <summary>
        /// Необязательный. Закрепленное сообщение, для «supergroup» и «channel».
        /// </summary>
        public Message PinnedMessage { get; set; }

        /// <summary>
        /// Необязательный. Для «supergroup» - название группы стикеров.
        /// </summary>
        public string StickerSetName { get; set; }

        /// <summary>
        /// Необязательный. Бот может изменить набор стикеров группы?
        /// </summary>
        public bool? CanSetStickerSet { get; set; }
    }
}
