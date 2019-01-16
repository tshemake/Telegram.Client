using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Telegram.Library.Types
{
    /// <summary>
    /// Одна строка таблицы рекордов для игры.
    /// <see href="https://core.telegram.org/bots/api#gamehighscore"/>
    /// </summary>
    public class GameHighScore
    {
        /// <summary>
        /// Положение в таблице рекордов по игре
        /// </summary>
        [Required]
        public int Position { get; set; }

        /// <summary>
        /// Пользователь
        /// </summary>
        [Required]
        public User User { get; set; }

        /// <summary>
        /// Счет
        /// </summary>
        [Required]
        public int Score { get; set; }
    }
}
