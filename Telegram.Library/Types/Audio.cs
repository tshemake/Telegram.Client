using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Telegram.Library.Types
{
    /// <summary>
    /// Аудиофайл, который клиенты Telegram будут рассматривать как музыку.
    /// <see href="https://core.telegram.org/bots/api#audio"/>
    /// </summary>
    public class Audio
    {
        [Key]
        public long Id { get; set; }

        /// <summary>
        /// Уникальный идентификатор этого файла
        /// </summary>
        [Required]
        public string UniqueFileId { get; set; }

        /// <summary>
        /// Продолжительность аудио в секундах, как определено отправителем
        /// </summary>
        [Required]
        public int Duration { get; set; }

        /// <summary>
        /// Необязательный. Исполнитель аудио, как определено отправителем или аудио тегами
        /// </summary>
        public string Performer { get; set; }

        /// <summary>
        /// Необязательный. Название аудио, как определено отправителем или аудио тегами
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Необязательный. MIME-тип файла, определенный отправителем
        /// </summary>
        public string MimeType { get; set; }

        /// <summary>
        /// Необязательный. Размер файла
        /// </summary>
        public int FileSize { get; set; }
    }
}
