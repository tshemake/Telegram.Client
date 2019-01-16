using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Telegram.Library.Types
{
    /// <summary>
    /// точка на карте.
    /// <see href="https://core.telegram.org/bots/api#location"/>
    /// </summary>
    public class Location
    {
        [Key]
        public long Id { get; set; }

        /// <summary>
        /// Долгота, как определено отправителем
        /// </summary>
        [Required]
        public float Longitude { get; set; }

        /// <summary>
        /// Широта, как определено отправителем
        /// </summary>
        [Required]
        public float Latitude { get; set; }
    }
}
