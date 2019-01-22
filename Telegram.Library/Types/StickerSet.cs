using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Newtonsoft.Json;

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
        [JsonProperty(Required = Required.Always)]
        public string Name { get; set; }

        /// <summary>
        /// Название стикера
        /// </summary>
        [Required]
        [JsonProperty(Required = Required.Always)]
        public string Title { get; set; }

        /// <summary>
        /// <c>true</c>, если набор наклеек содержит маски
        /// </summary>
        [Required]
        [JsonProperty(Required = Required.Always)]
        public bool ContainsMasks { get; set; }

        /// <summary>
        /// Список всех установленных стикеров
        /// </summary>
        [Required]
        [JsonProperty(Required = Required.Always)]
        public IEnumerable<Sticker> Stickers { get; set; }
    }
}
