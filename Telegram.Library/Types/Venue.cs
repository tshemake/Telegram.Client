using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Newtonsoft.Json;

namespace Telegram.Library.Types
{
    /// <summary>
    /// Место проведения.
    /// <see href="https://core.telegram.org/bots/api#venue"/>
    /// </summary>
    public class Venue
    {
        [Key]
        [JsonIgnore]
        public long Id { get; set; }

        /// <summary>
        /// Место проведения
        /// </summary>
        [Required]
        [JsonProperty(Required = Required.Always)]
        public Location Location { get; set; }

        /// <summary>
        /// Название места проведения
        /// </summary>
        [Required]
        [JsonProperty(Required = Required.Always)]
        public string Title { get; set; }

        /// <summary>
        /// Адрес места проведения
        /// </summary>
        [Required]
        [JsonProperty(Required = Required.Always)]
        public string Address { get; set; }

        /// <summary>
        /// Необязательный. Идентификатор «foursquare» места проведения
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string FoursquareId { get; set; }

        /// <summary>
        /// Необязательный. Тип «foursquare».
        /// </summary>
        /// <example>
        /// «arts_entertainment/default», «arts_entertainment/aquarium» или «food/icecream»
        /// </example>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string FoursquareType { get; set; }
    }
}
