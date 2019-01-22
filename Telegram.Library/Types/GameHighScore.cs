using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Newtonsoft.Json;

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
        [JsonProperty(Required = Required.Always)]
        public int Position { get; set; }

        /// <summary>
        /// Пользователь
        /// </summary>
        [Required]
        [JsonProperty(Required = Required.Always)]
        public User User { get; set; }

        /// <summary>
        /// Счет
        /// </summary>
        [Required]
        [JsonProperty(Required = Required.Always)]
        public int Score { get; set; }
    }
}
