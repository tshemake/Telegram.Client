using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Newtonsoft.Json;

namespace Telegram.Library.Types
{
    /// <summary>
    /// Этот объект представляет один размер фотографии или миниатюра <see cref="Document">файла</see> / <see cref="Sticker">стикера</see>.
    /// <see href="https://core.telegram.org/bots/api#photosize"/>
    /// </summary>
    /// <remarks>
    /// Отсутствующий эскиз для файла (или наклейки) представляется как пустой объект.
    /// </remarks>
    public class PhotoSize
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
        /// Необязательный. Размер файла
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int FileSize { get; set; }
    }
}
