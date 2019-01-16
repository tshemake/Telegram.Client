using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Telegram.Library.Types
{
    /// <summary>
    /// Файл, загруженный в Telegram Passport.
    /// <see href="https://core.telegram.org/bots/api#passportfile"/>
    /// </summary>
    /// <remarks>
    /// В настоящее время все файлы Telegram Passport
    /// в расшифрованном виде имеют формат JPEG и не превышают 10 МБ.
    /// </remarks>
    public class PassportFile
    {
        [Key]
        public long Id { get; set; }

        /// <summary>
        /// Уникальный идентификатор этого файла
        /// </summary>
        [Required]
        public string UniqueFileId { get; set; }

        /// <summary>
        /// Необязательный. Размер файла
        /// </summary>
        public int FileSize { get; set; }

        /// <summary>
        /// <see href="https://en.wikipedia.org/wiki/Unix_time">Unix время</see>, когда файл был загружен
        /// </summary>
        [Required]
        public DateTime FileDate { get; set; }
    }
}
