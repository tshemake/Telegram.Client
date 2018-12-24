using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Telegram.Library.Models
{
    /// <summary>
    /// Стикер
    /// <see href="https://core.telegram.org/bots/api#sticker"/>
    /// </summary>
    public class Sticker
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
        /// Необязательный. Миниатюра стикера в формате .webp или .jpg
        /// </summary>
        public PhotoSize Thumb { get; set; }

        /// <summary>
        /// Необязательный. Emoji, связанная со стикером
        /// </summary>
        public string Emoji { get; set; }

        /// <summary>
        /// Необязательный. Название набора стикеров к которому относится данный стикер
        /// </summary>
        public string SetName { get; set; }

        /// <summary>
        /// Необязательный. Для стикеров с маской - место, где должна быть размещена маска
        /// </summary>
        public MaskPosition MaskPosition { get; set; }

        /// <summary>
        /// Необязательный. Размер файла
        /// </summary>
        public int FileSize { get; set; }
    }
}
