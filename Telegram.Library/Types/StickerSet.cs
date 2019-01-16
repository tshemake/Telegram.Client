using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Telegram.Library.Types
{
    /// <summary>
    /// Набор стикеров.
    /// <see href="https://core.telegram.org/bots/api#stickerset"/>
    /// </summary>
    public class StickerSet
    {
        /// <summary>
        /// Название набора стикеров
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Название стикера
        /// </summary>
        [Required]
        public string Title { get; set; }

        /// <summary>
        /// <c>true</c>, если набор наклеек содержит маски
        /// </summary>
        [Required]
        public bool ContainsMasks { get; set; }

        /// <summary>
        /// Список всех установленных стикеров
        /// </summary>
        [Required]
        public IEnumerable<Sticker> Stickers { get; set; }
    }
}
