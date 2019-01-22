using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Newtonsoft.Json;

namespace Telegram.Library.Types
{
    /// <summary>
    /// Этот объект представляет собой <see href="https://telegram.org/blog/video-messages-and-telescope">видеосообщение</see>
    /// <see href="https://core.telegram.org/bots/api#videonote"/>
    /// </summary>
    /// <remarks>
    /// Доступно в приложениях Telegram начиная с версии <see href="https://telegram.org/blog/video-messages-and-telescope">4.0</see>
    /// </remarks>
    public class VideoNote
    {
        [Key]
        [JsonIgnore]
        public long Id { get; set; }

        /// <summary>
        /// Уникальный идентификатор этого файла
        /// </summary>
        [Required]
        [JsonProperty(Required = Required.Always)]
        public string UniqueFileId { get; set; }

        /// <summary>
        /// Ширина и высота видео, как определено отправителем
        /// </summary>
        [Required]
        [JsonProperty(Required = Required.Always)]
        public int Length { get; set; }

        /// <summary>
        /// Продолжительность видео в секундах, определяемая отправителем
        /// </summary>
        [Required]
        [JsonProperty(Required = Required.Always)]
        public int Duration { get; set; }

        /// <summary>
        /// Необязательный. Миниатюра видео
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PhotoSize Thumb { get; set; }

        /// <summary>
        /// Необязательный. Размер файла
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int FileSize { get; set; }
    }
}
