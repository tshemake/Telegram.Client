using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Telegram.Library.Types
{
    /// <summary>
    /// ChatMember status
    /// </summary>
    public enum ChatMemberStatus
    {
        /// <summary>
        /// Creator of the <see cref="Chat"/>
        /// </summary>
        Creator,

        /// <summary>
        /// Administrator of the <see cref="Chat"/>
        /// </summary>
        Administrator,

        /// <summary>
        /// Normal member of the <see cref="Chat"/>
        /// </summary>
        Member,

        /// <summary>
        /// A <see cref="User"/> who is restricted in the <see cref="Chat"/>
        /// </summary>
        Restricted,

        /// <summary>
        /// A <see cref="User"/> who left the <see cref="Chat"/>
        /// </summary>
        Left,

        /// <summary>
        /// A <see cref="User"/> who was kicked from the <see cref="Chat"/>
        /// </summary>
        Kicked
    }

    /// <summary>
    /// Информация об одном из участников чата.
    /// <see href="https://core.telegram.org/bots/api#chatmember"/>
    /// </summary>
    public class ChatMember
    {
        /// <summary>
        /// Информация о пользователе
        /// </summary>
        [Required]
        public User User { get; set; }

        /// <summary>
        /// Статус участника в чате. Может быть «creator», «administrator», «member», «restricted», «left» или «kicked»
        /// </summary>
        [Required]
        public ChatMemberStatus Status { get; set; }

        /// <summary>
        /// Необязательный. Только для статусов «restricted» и «kicked». 
        /// Дата в <see href="https://en.wikipedia.org/wiki/Unix_time">Unix времени</see>, когда ограничения будут сняты для этого пользователя
        /// </summary>
        public DateTime? UntilDate { get; set; }

        /// <summary>
        /// Необязательный. Только «administrator». <c>true</c>, если боту разрешено редактировать права администратора этого пользователя
        /// </summary>
        public bool? CanBeEdited { get; set; }

        /// <summary>
        /// Необязательный. Только «administrator». <c>true</c>, если администратор может изменить заголовок чата, фотографию и другие настройки
        /// </summary>
        public bool? CanChangeInfo { get; set; }

        /// <summary>
        /// Необязательный. Только «administrator». <c>true</c>, если администратор может публиковать в «channel». Только «channels»
        /// </summary>
        public bool? CanPostMessages { get; set; }

        /// <summary>
        /// Необязательный. Только «administrator». <c>true</c>, если администратор может редактировать сообщения других пользователей
        /// и может закреплять сообщения. Только «channels»
        /// </summary>
        public bool? CanEditMessages { get; set; }

        /// <summary>
        /// Необязательный. Только «administrator». <c>true</c>, если администратор может удалять сообщения других пользователей
        /// </summary>
        public bool? CanDeleteMessages { get; set; }

        /// <summary>
        /// Необязательный. Только «administrator». <c>true</c>, если администратор может приглашать новых пользователей в чат
        /// </summary>
        public bool? CanInviteUsers { get; set; }

        /// <summary>
        /// Необязательный. Только «administrator». <c>true</c>, если администратор может ограничить, забанить или разблокировать участников чата
        /// </summary>
        public bool? CanRestrictMembers { get; set; }

        /// <summary>
        /// Необязательный. Только «administrator». <c>true</c>, если администратор может закреплять сообщения. Только «supergroup»
        /// </summary>
        public bool? CanPinMessages { get; set; }

        /// <summary>
        /// Необязательный. Только «administrator». <c>true</c>, если администратор может добавлять новых администраторов
        /// с подмножеством своих собственных привилегий или понижать администраторов, которых он назначил, прямо или косвенно
        /// (продвигаемых администраторами, которые были назначены пользователем)
        /// </summary>
        public bool? CanPromoteMembers { get; set; }

        /// <summary>
        /// Необязательный. Только «restricted». <c>true</c>, если пользователь может отправлять текстовые сообщения, контакты, 
        /// локации и места проведения
        /// </summary>
        public bool? CanSendMessages { get; set; }

        /// <summary>
        /// Необязательный. Только «restricted». <c>true</c>, если пользователь может отправлять аудио, документы, фотографии, видео, 
        /// видео и голосовые заметки.
        /// Подразумевается <see cref="CanSendMessages"/>
        /// </summary>
        public bool? CanSendMediaMessages { get; set; }

        /// <summary>
        /// Необязательный. Только «restricted». <c>true</c>, если пользователь может отправлять анимацию, игры, стикеры 
        /// и использовать встроенных ботов.
        /// Подразумевается <see cref="CanSendMediaMessages"/>
        /// </summary>
        public bool? CanSendOtherMessages { get; set; }

        /// <summary>
        /// Необязательный. Только «restricted». <c>true</c>, если пользователь может добавлять предварительные просмотры веб-страниц 
        /// в свои сообщения
        /// Подразумевается <see cref="CanSendMediaMessages"/>
        /// </summary>
        public bool? CanAddWebPagePreviews { get; set; }
    }
}
