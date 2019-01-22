using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Newtonsoft.Json;

namespace Telegram.Library.Types
{
    /// <summary>
    /// Файл, готовый для загрузки.
    /// Файл можно скачать по ссылке <see href="https://api.telegram.org/file/bot<token>/<file_path>"/>.
    /// <see href="https://core.telegram.org/bots/api#file"/>
    /// </summary>
    /// <remarks>
    /// Гарантируется, что ссылка будет действительна не менее 1 часа.
    /// Когда срок действия ссылки истекает, можно запросить новую
    /// Максимальный размер файла для загрузки составляет 20 МБ
    /// </remarks>
    public class File
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
        /// Необязательный. Путь файла.
        /// Используйте <see href="https://api.telegram.org/file/bot<token>/<file_path>"/> чтобы получить файл.
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string FilePath { get; set; }

        /// <summary>
        /// Необязательный. Размер файла
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int FileSize { get; set; }
    }
}
