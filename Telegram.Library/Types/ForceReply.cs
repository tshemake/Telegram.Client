﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.Library.Types
{
    /// <summary>
    /// После получения сообщения с этим объектом Telegram клиенты отобразят 
    /// интерфейс ответа пользователю (действуйте так, как будто пользователь
    /// выбрал сообщение бота и нажал «Ответить»).
    /// <see href="https://core.telegram.org/bots/api#forcereply"/>
    /// </summary>
    /// <remarks>
    /// Это может быть чрезвычайно полезно, если вы хотите создать удобные
    /// пошаговые интерфейсы без ущерба для <see href="https://core.telegram.org/bots#privacy-mode">режима конфиденциальности</see>.
    /// </remarks>
    public class ForceReplyMarkup : IReplyMarkup
    {
        /// <summary>
        /// Показывает интерфейс ответа для пользователя,
        /// как будто он вручную выбрал сообщение бота и нажал «Ответить»
        /// </summary>
        [Required]
        [JsonProperty(Required = Required.Always)]
        public bool ForceReply { get; set; }

        /// <summary>
        /// Необязательный. Используйте этот параметр, если вы хотите получить ответ только от определенных пользователей.
        /// Цели:
        ///     1) пользователи, которые упоминаются в тексте объекта <see cref="Message"/>;
        ///     2) если сообщение бота является ответом (имеет <see cref="Message.ReplyToMessage"/>), исходного сообщения.
        /// </summary>
        /// <example>
        /// Бот для опроса групп работает в приватном режиме (только получает команды, отвечает на его сообщения и ссылки username).
        /// Может быть два способа создать новый опрос:
        ///     1) Объясните пользователю, как отправить команду с параметрами (например, /newpoll question answer1 answer2).
        ///     Может быть привлекательным для продвинутых пользователей.
        ///     2) Проведите пользователя через пошаговый процесс. 
        ///     «Пожалуйста, пришлите мне свой вопрос», «Круто, теперь давайте добавим первый вариант ответа», 
        ///     «Отлично. Продолжайте добавлять варианты ответов, а затем отправьте /done, когда будете готовы».
        ///     
        ///     Последний вариант определенно более привлекательный. И если вы используете <see cref="ForceReplyMarkup"/> 
        ///     в вопросах своего бота, он будет получать ответы пользователя, даже если он только получает ответы, 
        ///     команды и ссылки username - без какой-либо дополнительной работы для пользователя.
        /// </example>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Selective { get; set; }
    }
}
