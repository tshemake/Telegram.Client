using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Newtonsoft.Json;

namespace Telegram.Library.Types
{
    /// <summary>
    /// Стикер
    /// <see href="https://core.telegram.org/bots/api#sticker"/>
    /// </summary>
    public class Sticker
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
        /// Ширина
        /// </summary>
        [Required]
        [JsonProperty(Required = Required.Always)]
        public int Width { get; set; }

        /// <summary>
        /// Высота
        /// </summary>
        [Required]
        [JsonProperty(Required = Required.Always)]
        public int Height { get; set; }

        /// <summary>
        /// Необязательный. Миниатюра стикера в формате .webp или .jpg
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PhotoSize Thumb { get; set; }

        /// <summary>
        /// Необязательный. Emoji, связанная со стикером
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Emoji { get; set; }

        /// <summary>
        /// Необязательный. Название набора стикеров к которому относится данный стикер
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string SetName { get; set; }

        /// <summary>
        /// Необязательный. Для стикеров с маской - место, где должна быть размещена маска
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public MaskPosition MaskPosition { get; set; }

        /// <summary>
        /// Необязательный. Размер файла
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int FileSize { get; set; }
    }
}
