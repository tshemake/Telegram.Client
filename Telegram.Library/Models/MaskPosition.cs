using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Telegram.Library.Models
{
    /// <summary>
    /// Часть лица, относительно которой должна быть размещена маска. Один из "лоб", "глаза", "рот" или "подбородок".
    /// </summary>
    public enum MaskPositionPoint
    {
        /// <summary>
        /// Лоб
        /// </summary>
        Forehead,
        /// <summary>
        /// Глаза
        /// </summary>
        Eyes,
        /// <summary>
        /// Рот
        /// </summary>
        Mouth,
        /// <summary>
        /// Подбородок
        /// </summary>
        Chin
    }

    /// <summary>
    /// Этот объект описывает положение на гранях, где маска должна быть размещена по умолчанию.
    /// <see href="https://core.telegram.org/bots/api#maskposition"/>
    /// </summary>
    public class MaskPosition
    {
        [Key]
        public long Id { get; set; }

        /// <summary>
        /// Часть лица, относительно которой должна быть размещена маска. Один из «лоб», «глаза», «рот» или «подбородок».
        /// </summary>
        [Required]
        public MaskPositionPoint Point { get; set; }

        /// <summary>
        /// Сдвиг по оси X, измеренный по ширине маски, масштабированной по размеру лица, слева направо. 
        /// </summary>
        /// <remarks>
        /// Например, при выборе -1.0 маска будет размещена слева от позиции маски по умолчанию.
        /// </remarks>
        [Required]
        public float XShift { get; set; }

        /// <summary>
        /// Смещение по оси Y, измеренное в высотах маски, масштабированной по размеру лица, сверху вниз.
        /// </summary>
        /// <remarks>
        /// Например, при выборе 1.0 поместит маску чуть ниже позиции маски по умолчанию.
        /// </remarks>
        [Required]
        public float YShift { get; set; }

        /// <summary>
        /// Масштабирующий коэффициент маски
        /// </summary>
        /// <remarks>
        /// Например, 2.0 означает двойной размер.
        /// </remarks>
        [Required]
        public float Scale { get; set; }
    }
}
