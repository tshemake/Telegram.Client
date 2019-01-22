using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Newtonsoft.Json;

namespace Telegram.Library.Types
{
    /// <summary>
    /// точка на карте.
    /// <see href="https://core.telegram.org/bots/api#location"/>
    /// </summary>
    public class Location
    {
        [Key]
        [JsonIgnore]
        public long Id { get; set; }

        /// <summary>
        /// Долгота, как определено отправителем
        /// </summary>
        [Required]
        [JsonProperty(Required = Required.Always)]
        public float Longitude { get; set; }

        /// <summary>
        /// Широта, как определено отправителем
        /// </summary>
        [Required]
        [JsonProperty(Required = Required.Always)]
        public float Latitude { get; set; }
    }
}
