using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Telegram.Library.Models
{
    /// <summary>
    /// Сообщение.
    /// <see href="https://core.telegram.org/bots/api#message"/>
    /// </summary>
    public class Message
    {
        [Key]
        public long Id { get; set; }

        /// <summary>
        /// Уникальный идентификатор сообщения в этом чате
        /// </summary>
        [Required]
        public int UniqueMessageId { get; set; }

        /// <summary>
        /// Необязательный. Отправитель
        /// </summary>
        /// <remarks>
        /// Отсутствует для сообщений, отправляемых на «channels»
        /// </remarks>
        public User From { get; set; }

        /// <summary>
        /// Дата отправки сообщения в <see href="https://en.wikipedia.org/wiki/Unix_time">Unix времени</see>
        /// </summary>
        [Required]
        public DateTime Date { get; set; }

        /// <summary>
        /// Чат, которому принадлежит сообщение
        /// </summary>
        [Required]
        public Chat Chat { get; set; }

        /// <summary>
        /// Необязательный. Для переадресованных сообщений - отправитель исходного сообщения.
        /// </summary>
        public User ForwardFrom { get; set; }

        /// <summary>
        /// Необязательный. Для сообщений, пересылаемых с «channels», информация об исходном «channel»
        /// </summary>
        public Chat ForwardFromChat { get; set; }

        /// <summary>
        /// Необязательный. Для сообщений, пересылаемых из «channels», идентификатор исходного сообщения в «channel»
        /// </summary>
        public int ForwardFromMessageId { get; set; }

        /// <summary>
        /// Необязательный. Для сообщений, пересылаемых с «channels», подпись автора сообщения, если таковая имеется
        /// </summary>
        public string ForwardSignature { get; set; }

        /// <summary>
        /// Необязательный. Для переадресованных сообщений: дата отправки оригинального сообщения в <see href="https://en.wikipedia.org/wiki/Unix_time">Unix времени</see>
        /// </summary>
        public DateTime? ForwardDate { get; set; }

        /// <summary>
        /// Необязательный. Для ответов оригинальное сообщение.
        /// </summary>
        /// <remarks>
        /// Объект Message в этом поле не будет содержать дополнительных полей <see cref="ReplyToMessage" />, даже если он сам является ответом
        /// </remarks>
        public Message ReplyToMessage { get; set; }

        /// <summary>
        /// Необязательный. Дата последнего редактирования сообщения в <see href="https://en.wikipedia.org/wiki/Unix_time">Unix времени</see>
        /// </summary>
        public DateTime? EditDate { get; set; }

        /// <summary>
        /// Необязательный. Уникальный идентификатор группы мультимедийных сообщений, к которой относится это сообщение
        /// </summary>
        public string MediaGroupId { get; set; }

        /// <summary>
        /// Необязательный. Подпись автора сообщения для сообщений в «channels»
        /// </summary>
        public string AuthorSignature { get; set; }

        /// <summary>
        /// Необязательный. Для текстовых сообщений, в формате UTF-8, до 4096 символов.
        /// </summary>
        [MaxLength(4096)]
        public string Text { get; set; }

        /// <summary>
        /// Необязательный. Для текстовых сообщений в тексте появляются специальные объекты, такие как usernames, URL-адреса, команды ботов и т.д.
        /// </summary>
        public ICollection<MessageEntity> Entities { get; set; }

        /// <summary>
        /// Необязательный. Для сообщений с заголовком, специальные объекты, такие как usernames, URL-адреса, команды ботов и т.д., 
        /// которые появляются в заголовке
        /// </summary>
        public ICollection<MessageEntity> CaptionEntities { get; set; }

        /// <summary>
        /// Необязательный. Сообщение представляет собой аудиофайл, информация о файле
        /// </summary>
        public Audio Audio { get; set; }

        /// <summary>
        /// Необязательный. Сообщение - это общий файл, информация о файле
        /// </summary>
        public Document Document { get; set; }

        /// <summary>
        /// Необязательный. Сообщение - это анимация, информация об анимации.
        /// </summary>
        /// <remarks>
        /// Для обратной совместимости, когда установлено это поле, поле документа также будет установлено
        /// </remarks>
        public Animation Animation { get; set; }

        /// <summary>
        /// Необязательный. Сообщение - игра, информация об игре
        /// </summary>
        /// <remarks>
        /// <see href="https://core.telegram.org/bots/api#games">Подробнее об играх</see>
        /// </remarks>
        public Game Game { get; set; }

        /// <summary>
        /// Необязательный. Сообщение это фото, доступные размеры фото
        /// </summary>
        public ICollection<PhotoSize> Photo { get; set; }

        /// <summary>
        /// Необязательный. Сообщение - стикер, информация о стикере
        /// </summary>
        public Sticker Sticker { get; set; }

        /// <summary>
        /// Необязательный. Сообщение - это видео, информация о видео
        /// </summary>
        public Video Video { get; set; }

        /// <summary>
        /// Необязательный. Сообщение - это голосовое сообщение, информация о файле
        /// </summary>
        public Voice Voice { get; set; }

        /// <summary>
        /// Необязательный. Сообщение - это <see href="https://telegram.org/blog/video-messages-and-telescope">видео заметка</see>, информация о видео сообщении
        /// </summary>
        public VideoNote VideoNote { get; set; }

        /// <summary>
        /// Необязательный. Заголовок для аудио, документа, фото, видео или голоса, до 1024 символа
        /// </summary>
        [MaxLength(1024)]
        public string Caption { get; set; }

        /// <summary>
        /// Необязательный. Сообщение является общим контактом, информация о контакте
        /// </summary>
        public Contact Contact { get; set; }

        /// <summary>
        /// Необязательный. Сообщение является общим местоположением, информация о местоположении
        /// </summary>
        public Location Location { get; set; }

        /// <summary>
        /// Необязательный. Сообщение место проведения, информация о месте
        /// </summary>
        public Venue Venue { get; set; }

        /// <summary>
        /// Необязательный. Новые участники, которые были добавлены в «group» или «supergroup» 
        /// и информация о них (сам бот может быть одним из этих участников)
        /// </summary>
        public ICollection<User> NewChatMembers { get; set; }

        /// <summary>
        /// Необязательный. Участник был удален из группы, информация о них (этим участником может быть сам бот)
        /// </summary>
        public User LeftChatMember { get; set; }

        /// <summary>
        /// Необязательный. Новое название чата
        /// </summary>
        public string NewChatTitle { get; set; }

        /// <summary>
        /// Необязательный. Новая фотография чата
        /// </summary>
        public ICollection<PhotoSize> NewChatPhoto { get; set; }

        /// <summary>
        /// Необязательный. Сервисное сообщение: фотография в чате была удалена
        /// </summary>
        public bool DeleteChatPhoto { get; set; }

        /// <summary>
        /// Необязательный. Сервисное сообщение: «group» создана
        /// </summary>
        public bool GroupChatCreated { get; set; }

        /// <summary>
        /// Необязательный. Сервисное сообщение: «supergroup» создана.
        /// </summary>
        /// <remarks>
        /// Это поле не может быть получено в сообщении, поступающем через обновления, 
        /// потому что бот не может быть членом «supergroup», когда она создается. 
        /// Его можно найти только в <see cref="ReplyToMessage"/>, если кто-то ответит 
        /// на самое первое сообщение в непосредственно созданной «supergroup».
        /// </remarks>
        public bool SupergroupchatCreated { get; set; }

        /// <summary>
        /// Необязательный. Сервисное сообщение: «channel» создан.
        /// </summary>
        /// <remarks>
        /// Это поле не может быть получено в сообщении, поступающем через обновления, 
        /// поскольку бот не может быть участником «channel» при его создании. 
        /// Его можно найти только в <see cref="ReplyToMessage"/>, если кто-то отвечает 
        /// на самое первое сообщение в «channel».
        /// </remarks>
        public bool ChannelChatCreated { get; set; }

        /// <summary>
        /// Необязательный. «group», была перенесена в «supergroup», с указанным идентификатором.
        /// </summary>
        /// <remarks>
        /// Это число может быть больше 32 бит и меньше 52 бит.
        /// </remarks>
        public long MigrateToChatId { get; set; }

        /// <summary>
        /// Необязательный. «supergroup» была перенесена из «group» с указанным идентификатором.
        /// </summary>
        /// <remarks>
        /// Это число может быть больше 32 бит и меньше 52 бит.
        /// </remarks>
        public long MigrateFromChatId { get; set; }

        /// <summary>
        /// Необязательный. Указанное сообщение было закреплено.
        /// </summary>
        /// <remarks>
        /// Обратите внимание, что объект <see cref="Message"/> в этом поле не будет содержать 
        /// дополнительных полей <see cref="ReplyToMessage"/>, даже если он сам является ответом.
        /// </remarks>
        public Message PinnedMessage { get; set; }

        /// <summary>
        /// Необязательный. Сообщение - это счет на <see href="https://core.telegram.org/bots/api#payments">оплату</see>, информация о счете.
        /// </summary>
        /// <remarks>
        /// <see href="https://core.telegram.org/bots/api#payments">Подробнее о платежах</see>
        /// </remarks>
        public Invoice Invoice { get; set; }

        /// <summary>
        /// Необязательный. Сообщение - это служебное сообщение об успешном платеже, информация об оплате.
        /// </summary>
        /// <remarks>
        /// <see href="https://core.telegram.org/bots/api#payments">Подробнее о платежах</see>
        /// </remarks>
        public SuccessfulPayment SuccessfulPayment { get; set; }

        /// <summary>
        /// Необязательный. Доменное имя сайта, на котором зарегистрирован пользователь.
        /// </summary>
        /// <remarks>
        /// <see href="https://core.telegram.org/widgets/login">Подробнее о Telegram Login</see>
        /// </remarks>
        public string ConnectedWebsite { get; set; }

        /// <summary>
        /// Необязательный. Telegram Passport данные
        /// </summary>
        public PassportData PassportData { get; set; }
    }
}
