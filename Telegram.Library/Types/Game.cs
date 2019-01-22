using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Newtonsoft.Json;

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
        [JsonIgnore]
        public long Id { get; set; }

        /// <summary>
        /// Название игры
        /// </summary>
        [Required]
        [JsonProperty(Required = Required.Always)]
        public string Title { get; set; }

        /// <summary>
        /// Описание игры
        /// </summary>
        [Required]
        [JsonProperty(Required = Required.Always)]
        public string Description { get; set; }

        /// <summary>
        /// Фотография, которая будет отображаться в игровом сообщении в чатах.
        /// </summary>
        [Required]
        [JsonProperty(Required = Required.Always)]
        public IEnumerable<PhotoSize> Photo { get; set; }

        /// <summary>
        /// Необязательный. Краткое описание игры или рекорды, включенные в игровое сообщение. 
        /// </summary>
        [MaxLength(4096)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Text { get; set; }

        /// <summary>
        /// Необязательный. Специальные объекты, которые появляются в тексте, такие как usernames, URL-адреса, команды ботов и т.д.
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IEnumerable<MessageEntity> TextEntities { get; set; }

        /// <summary>
        /// Необязательный. Анимация, которая будет отображаться в игровом сообщении в чатах.
        /// </summary>
        /// <remarks>
        /// Загружать через <see href="https://t.me/botfather">BotFather</see>
        /// </remarks>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Animation Animation { get; set; }
    }
}
