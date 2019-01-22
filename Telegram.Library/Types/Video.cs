using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Newtonsoft.Json;

namespace Telegram.Library.Types
{
    /// <summary>
    /// Видео файл.
    /// <see href="https://core.telegram.org/bots/api#video"/>
    /// </summary>
    public class Video
    {
        [Key]
        [JsonIgnore]
        public long Id { get; set; }

        /// <summary>
        /// Уникальный идентификатор этого файла
        /// </summary>
        [Required]
        [JsonProperty("file_id", Required = Required.Always)]
        public string UniqueFileId { get; set; }

        /// <summary>
        /// Ширина видео, определенное отправителем
        /// </summary>
        [Required]
        [JsonProperty(Required = Required.Always)]
        public int Width { get; set; }

        /// <summary>
        /// Высота видео, определенное отправителем
        /// </summary>
        [Required]
        [JsonProperty(Required = Required.Always)]
        public int Height { get; set; }

        /// <summary>
        /// Продолжительность видео в секундах, определенное отправителем
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
        /// Необязательный. Тип MIME файла, как определено отправителем
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string MimeType { get; set; }

        /// <summary>
        /// Необязательный. Размер файла
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int FileSize { get; set; }
    }
}
