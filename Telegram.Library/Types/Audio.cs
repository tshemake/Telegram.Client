using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Newtonsoft.Json;

namespace Telegram.Library.Types
{
    /// <summary>
    /// Аудиофайл, который клиенты Telegram будут рассматривать как музыку.
    /// <see href="https://core.telegram.org/bots/api#audio"/>
    /// </summary>
    public class Audio
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
        /// Продолжительность аудио в секундах, как определено отправителем
        /// </summary>
        [Required]
        [JsonProperty(Required = Required.Always)]
        public int Duration { get; set; }

        /// <summary>
        /// Необязательный. Исполнитель аудио, как определено отправителем или аудио тегами
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Performer { get; set; }

        /// <summary>
        /// Необязательный. Название аудио, как определено отправителем или аудио тегами
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Title { get; set; }

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
