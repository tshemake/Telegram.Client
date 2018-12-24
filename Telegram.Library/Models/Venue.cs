using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Telegram.Library.Models
{
    /// <summary>
    /// Место проведения.
    /// <see href="https://core.telegram.org/bots/api#venue"/>
    /// </summary>
    public class Venue
    {
        [Key]
        public long Id { get; set; }

        /// <summary>
        /// Место проведения
        /// </summary>
        [Required]
        public Location Location { get; set; }

        /// <summary>
        /// Название места проведения
        /// </summary>
        [Required]
        public string Title { get; set; }

        /// <summary>
        /// Адрес места проведения
        /// </summary>
        [Required]
        public string Address { get; set; }

        /// <summary>
        /// Необязательный. Идентификатор «foursquare» места проведения
        /// </summary>
        public string FoursquareId { get; set; }

        /// <summary>
        /// Необязательный. Тип «foursquare».
        /// </summary>
        /// <example>
        /// «arts_entertainment/default», «arts_entertainment/aquarium» или «food/icecream»
        /// </example>
        public string FoursquareType { get; set; }
    }
}
