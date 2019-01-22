using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Newtonsoft.Json;

namespace Telegram.Library.Types
{
    /// <summary>
    /// Этот объект представляет общий файл (в отличие от <see cref="PhotoSize"/>, <see cref="Voice"/> и <see cref="Audio"/>).
    /// <see href="https://core.telegram.org/bots/api#document"/>
    /// </summary>
    public class Document
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
        /// Необязательный. Миниатюра документа, как определено отправителем
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PhotoSize Thumb { get; set; }

        /// <summary>
        /// Необязательный. Исходное имя файла, как определено отправителем
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string FileName { get; set; }

        /// <summary>
        /// Необязательный. MIME-тип файла, определенный отправителем
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
