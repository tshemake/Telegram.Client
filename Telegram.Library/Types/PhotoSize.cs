using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

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
        public long Id { get; set; }

        /// <summary>
        /// Уникальный идентификатор этого файла
        /// </summary>
        [Required]
        public string UniqueFileId { get; set; }

        /// <summary>
        /// Ширина
        /// </summary>
        [Required]
        public int Width { get; set; }

        /// <summary>
        /// Высота
        /// </summary>
        [Required]
        public int Height { get; set; }

        /// <summary>
        /// Необязательный. Размер файла
        /// </summary>
        public int FileSize { get; set; }
    }
}
