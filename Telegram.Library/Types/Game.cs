using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Telegram.Library.Types
{
    /// <summary>
    /// Игра. 
    /// <see href="https://core.telegram.org/bots/api#game"/>
    /// </summary>
    /// <remarks>
    /// Используйте <see href="https://t.me/botfather">BotFather</see> для создания и редактирования игр, их короткие имена будут выступать в качестве уникальных идентификаторов.
    /// </remarks>
    public class Game
    {
        [Key]
        public long Id { get; set; }

        /// <summary>
        /// Название игры
        /// </summary>
        [Required]
        public string Title { get; set; }

        /// <summary>
        /// Описание игры
        /// </summary>
        [Required]
        public string Description { get; set; }

        /// <summary>
        /// Фотография, которая будет отображаться в игровом сообщении в чатах.
        /// </summary>
        [Required]
        public PhotoSize[] Photo { get; set; }

        /// <summary>
        /// Необязательный. Краткое описание игры или рекорды, включенные в игровое сообщение. 
        /// </summary>
        [MaxLength(4096)]
        public string Text { get; set; }

        /// <summary>
        /// Необязательный. Специальные объекты, которые появляются в тексте, такие как usernames, URL-адреса, команды ботов и т.д.
        /// </summary>
        public MessageEntity[] TextEntities { get; set; }

        /// <summary>
        /// Необязательный. Анимация, которая будет отображаться в игровом сообщении в чатах.
        /// </summary>
        /// <remarks>
        /// Загружать через <see href="https://t.me/botfather">BotFather</see>
        /// </remarks>
        public Animation Animation { get; set; }
    }
}
