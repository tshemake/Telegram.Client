using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Telegram.Library.Types
{
    public enum MessageType
    {
        /// <summary>
        /// The <see cref="Message"/> is unknown
        /// </summary>
        Unknown = 0,

        /// <summary>
        /// The <see cref="Message"/> contains text
        /// </summary>
        Text,

        /// <summary>
        /// The <see cref="Message"/> contains a <see cref="PhotoSize"/>
        /// </summary>
        Photo,

        /// <summary>
        /// The <see cref="Message"/> contains an <see cref="Types.Audio"/>
        /// </summary>
        Audio,

        /// <summary>
        /// The <see cref="Message"/> contains a <see cref="Types.Video"/>
        /// </summary>
        Video,

        /// <summary>
        /// The <see cref="Message"/> contains a <see cref="Types.Voice"/>
        /// </summary>
        Voice,

        /// <summary>
        /// The <see cref="Message"/> contains a <see cref="Types.Document"/>
        /// </summary>
        Document,

        /// <summary>
        /// The <see cref="Message"/> contains a <see cref="Types.Sticker"/>
        /// </summary>
        Sticker,

        /// <summary>
        /// The <see cref="Message"/> contains a <see cref="Types.Location"/>
        /// </summary>
        Location,

        /// <summary>
        /// The <see cref="Message"/> contains a <see cref="Types.Contact"/>
        /// </summary>
        Contact,

        /// <summary>
        /// The <see cref="Message"/> contains a <see cref="Types.Venue"/>
        /// </summary>
        Venue,

        /// <summary>
        /// The <see cref="Message"/> contains a <see cref="Types.Game"/>
        /// </summary>
        Game,

        /// <summary>
        /// The <see cref="Message"/> contains a <see cref="Types.VideoNote"/>
        /// </summary>
        VideoNote,

        /// <summary>
        /// The <see cref="Message"/> contains a <see cref="Invoice"/>
        /// </summary>
        Invoice,

        /// <summary>
        /// The <see cref="Message"/> contains a <see cref="SuccessfulPayment"/>
        /// </summary>
        SuccessfulPayment,

        /// <summary>
        /// The <see cref="Message"/> contains a <see cref="Message.ConnectedWebsite"/>
        /// </summary>
        WebsiteConnected,

        /// <summary>
        /// The <see cref="Message"/> contains a <see cref="Message.NewChatMembers"/>
        /// </summary>
        ChatMembersAdded,

        /// <summary>
        /// The <see cref="Message"/> contains a <see cref="Message.LeftChatMember"/>
        /// </summary>
        ChatMemberLeft,

        /// <summary>
        /// The <see cref="Message"/> contains a <see cref="Message.NewChatTitle"/>
        /// </summary>
        ChatTitleChanged,

        /// <summary>
        /// The <see cref="Message"/> contains a <see cref="Message.NewChatPhoto"/>
        /// </summary>
        ChatPhotoChanged,

        /// <summary>
        /// The <see cref="Message"/> contains a <see cref="Message.PinnedMessage"/>
        /// </summary>
        MessagePinned,

        /// <summary>
        /// The <see cref="Message"/> contains a <see cref="Message.DeleteChatPhoto"/>
        /// </summary>
        ChatPhotoDeleted,

        /// <summary>
        /// The <see cref="Message"/> contains a <see cref="Message.GroupChatCreated"/>
        /// </summary>
        GroupCreated,

        /// <summary>
        /// The <see cref="Message"/> contains a <see cref="Message.SupergroupChatCreated"/>
        /// </summary>
        SupergroupCreated,

        /// <summary>
        /// The <see cref="Message"/> contains a <see cref="Message.ChannelChatCreated"/>
        /// </summary>
        ChannelCreated,

        /// <summary>
        /// The <see cref="Message"/> contains non-default <see cref="Message.MigrateFromChatId"/>
        /// </summary>
        MigratedToSupergroup,

        /// <summary>
        /// The <see cref="Message"/> contains non-default <see cref="Message.MigrateToChatId"/>
        /// </summary>
        MigratedFromGroup,

        /// <summary>
        /// The <see cref="Message"/> contains non-default <see cref="Message.Animation"/>
        /// </summary>
        Animation,
    }

    /// <summary>
    /// Сообщение.
    /// <see href="https://core.telegram.org/bots/api#message"/>
    /// </summary>
    public class Message
    {
        [Key]
        [JsonIgnore]
        public long Id { get; set; }

        /// <summary>
        /// Уникальный идентификатор сообщения в этом чате
        /// </summary>
        [Required]
        [JsonProperty("message_id", Required = Required.Always)]
        public int UniqueMessageId { get; set; }

        /// <summary>
        /// Необязательный. Отправитель
        /// </summary>
        /// <remarks>
        /// Отсутствует для сообщений, отправляемых на «channels»
        /// </remarks>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public User From { get; set; }

        /// <summary>
        /// Дата отправки сообщения в <see href="https://en.wikipedia.org/wiki/Unix_time">Unix времени</see>
        /// </summary>
        [Required]
        [JsonProperty(Required = Required.Always)]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Date { get; set; }

        /// <summary>
        /// Чат, которому принадлежит сообщение
        /// </summary>
        [Required]
        [JsonProperty(Required = Required.Always)]
        public Chat Chat { get; set; }

        /// <summary>
        /// Необязательный. Для переадресованных сообщений - отправитель исходного сообщения.
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public User ForwardFrom { get; set; }

        /// <summary>
        /// Необязательный. Для сообщений, пересылаемых с «channels», информация об исходном «channel»
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Chat ForwardFromChat { get; set; }

        /// <summary>
        /// Необязательный. Для сообщений, пересылаемых из «channels», идентификатор исходного сообщения в «channel»
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int ForwardFromMessageId { get; set; }

        /// <summary>
        /// Необязательный. Для сообщений, пересылаемых с «channels», подпись автора сообщения, если таковая имеется
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ForwardSignature { get; set; }

        /// <summary>
        /// Необязательный. Для переадресованных сообщений: дата отправки оригинального сообщения в <see href="https://en.wikipedia.org/wiki/Unix_time">Unix времени</see>
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? ForwardDate { get; set; }

        /// <summary>
        /// Необязательный. Для ответов оригинальное сообщение.
        /// </summary>
        /// <remarks>
        /// Объект Message в этом поле не будет содержать дополнительных полей <see cref="ReplyToMessage" />, даже если он сам является ответом
        /// </remarks>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Message ReplyToMessage { get; set; }

        /// <summary>
        /// Необязательный. Дата последнего редактирования сообщения в <see href="https://en.wikipedia.org/wiki/Unix_time">Unix времени</see>
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? EditDate { get; set; }

        /// <summary>
        /// Необязательный. Уникальный идентификатор группы мультимедийных сообщений, к которой относится это сообщение
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string MediaGroupId { get; set; }

        /// <summary>
        /// Необязательный. Подпись автора сообщения для сообщений в «channels»
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string AuthorSignature { get; set; }

        /// <summary>
        /// Необязательный. Для текстовых сообщений, в формате UTF-8, до 4096 символов.
        /// </summary>
        [MaxLength(4096)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Text { get; set; }

        /// <summary>
        /// Необязательный. Для текстовых сообщений в тексте появляются специальные объекты, такие как usernames, URL-адреса, команды ботов и т.д.
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IEnumerable<MessageEntity> Entities { get; set; }

        /// <summary>
        /// Необязательный. Для сообщений с заголовком, специальные объекты, такие как usernames, URL-адреса, команды ботов и т.д., 
        /// которые появляются в заголовке
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IEnumerable<MessageEntity> CaptionEntities { get; set; }

        /// <summary>
        /// Необязательный. Сообщение представляет собой аудиофайл, информация о файле
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Audio Audio { get; set; }

        /// <summary>
        /// Необязательный. Сообщение - это общий файл, информация о файле
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Document Document { get; set; }

        /// <summary>
        /// Необязательный. Сообщение - это анимация, информация об анимации.
        /// </summary>
        /// <remarks>
        /// Для обратной совместимости, когда установлено это поле, поле документа также будет установлено
        /// </remarks>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Animation Animation { get; set; }

        /// <summary>
        /// Необязательный. Сообщение - игра, информация об игре
        /// </summary>
        /// <remarks>
        /// <see href="https://core.telegram.org/bots/api#games">Подробнее об играх</see>
        /// </remarks>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Game Game { get; set; }

        /// <summary>
        /// Необязательный. Сообщение это фото, доступные размеры фото
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IEnumerable<PhotoSize> Photo { get; set; }

        /// <summary>
        /// Необязательный. Сообщение - стикер, информация о стикере
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Sticker Sticker { get; set; }

        /// <summary>
        /// Необязательный. Сообщение - это видео, информация о видео
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Video Video { get; set; }

        /// <summary>
        /// Необязательный. Сообщение - это голосовое сообщение, информация о файле
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Voice Voice { get; set; }

        /// <summary>
        /// Необязательный. Сообщение - это <see href="https://telegram.org/blog/video-messages-and-telescope">видео заметка</see>, информация о видео сообщении
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public VideoNote VideoNote { get; set; }

        /// <summary>
        /// Необязательный. Заголовок для аудио, документа, фото, видео или голоса, до 1024 символа
        /// </summary>
        [MaxLength(1024)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Caption { get; set; }

        /// <summary>
        /// Необязательный. Сообщение является общим контактом, информация о контакте
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Contact Contact { get; set; }

        /// <summary>
        /// Необязательный. Сообщение является общим местоположением, информация о местоположении
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Location Location { get; set; }

        /// <summary>
        /// Необязательный. Сообщение место проведения, информация о месте
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Venue Venue { get; set; }

        /// <summary>
        /// Необязательный. Новые участники, которые были добавлены в «group» или «supergroup» 
        /// и информация о них (сам бот может быть одним из этих участников)
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IEnumerable<User> NewChatMembers { get; set; }

        /// <summary>
        /// Необязательный. Участник был удален из группы, информация о них (этим участником может быть сам бот)
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public User LeftChatMember { get; set; }

        /// <summary>
        /// Необязательный. Новое название чата
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string NewChatTitle { get; set; }

        /// <summary>
        /// Необязательный. Новая фотография чата
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IEnumerable<PhotoSize> NewChatPhoto { get; set; }

        /// <summary>
        /// Необязательный. Сервисное сообщение: фотография в чате была удалена
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool DeleteChatPhoto { get; set; }

        /// <summary>
        /// Необязательный. Сервисное сообщение: «group» создана
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
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
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool SupergroupChatCreated { get; set; }

        /// <summary>
        /// Необязательный. Сервисное сообщение: «channel» создан.
        /// </summary>
        /// <remarks>
        /// Это поле не может быть получено в сообщении, поступающем через обновления, 
        /// поскольку бот не может быть участником «channel» при его создании. 
        /// Его можно найти только в <see cref="ReplyToMessage"/>, если кто-то отвечает 
        /// на самое первое сообщение в «channel».
        /// </remarks>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool ChannelChatCreated { get; set; }

        /// <summary>
        /// Необязательный. «group», была перенесена в «supergroup», с указанным идентификатором.
        /// </summary>
        /// <remarks>
        /// Это число может быть больше 32 бит и меньше 52 бит.
        /// </remarks>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long MigrateToChatId { get; set; }

        /// <summary>
        /// Необязательный. «supergroup» была перенесена из «group» с указанным идентификатором.
        /// </summary>
        /// <remarks>
        /// Это число может быть больше 32 бит и меньше 52 бит.
        /// </remarks>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long MigrateFromChatId { get; set; }

        /// <summary>
        /// Необязательный. Указанное сообщение было закреплено.
        /// </summary>
        /// <remarks>
        /// Обратите внимание, что объект <see cref="Message"/> в этом поле не будет содержать 
        /// дополнительных полей <see cref="ReplyToMessage"/>, даже если он сам является ответом.
        /// </remarks>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Message PinnedMessage { get; set; }

        /// <summary>
        /// Необязательный. Сообщение - это счет на <see href="https://core.telegram.org/bots/api#payments">оплату</see>, информация о счете.
        /// </summary>
        /// <remarks>
        /// <see href="https://core.telegram.org/bots/api#payments">Подробнее о платежах</see>
        /// </remarks>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Invoice Invoice { get; set; }

        /// <summary>
        /// Необязательный. Сообщение - это служебное сообщение об успешном платеже, информация об оплате.
        /// </summary>
        /// <remarks>
        /// <see href="https://core.telegram.org/bots/api#payments">Подробнее о платежах</see>
        /// </remarks>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SuccessfulPayment SuccessfulPayment { get; set; }

        /// <summary>
        /// Необязательный. Доменное имя сайта, на котором зарегистрирован пользователь.
        /// </summary>
        /// <remarks>
        /// <see href="https://core.telegram.org/widgets/login">Подробнее о Telegram Login</see>
        /// </remarks>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ConnectedWebsite { get; set; }

        /// <summary>
        /// Необязательный. Telegram Passport данные
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PassportData PassportData { get; set; }

        public MessageType Type
        {
            get
            {
                if (Audio != null) return MessageType.Audio;
                if (Document != null) return MessageType.Document;
                if (Game != null) return MessageType.Game;
                if (Photo != null) return MessageType.Photo;
                if (Sticker != null) return MessageType.Sticker;
                if (Video != null) return MessageType.Video;
                if (Voice != null) return MessageType.Voice;
                if (Contact != null) return MessageType.Contact;
                if (Venue != null) return MessageType.Venue;
                if (Location != null) return MessageType.Location;
                if (Text != null) return MessageType.Text;
                if (Invoice != null) return MessageType.Invoice;
                if (SuccessfulPayment != null) return MessageType.SuccessfulPayment;
                if (VideoNote != null) return MessageType.VideoNote;
                if (ConnectedWebsite != null) return MessageType.WebsiteConnected;
                if (NewChatMembers?.Any() == true) return MessageType.ChatMembersAdded;
                if (LeftChatMember != null) return MessageType.ChatMemberLeft;
                if (NewChatTitle != null) return MessageType.ChatTitleChanged;
                if (NewChatPhoto != null) return MessageType.ChatPhotoChanged;
                if (PinnedMessage != null) return MessageType.MessagePinned;
                if (DeleteChatPhoto) return MessageType.ChatPhotoDeleted;
                if (GroupChatCreated) return MessageType.GroupCreated;
                if (SupergroupChatCreated) return MessageType.SupergroupCreated;
                if (ChannelChatCreated) return MessageType.ChannelCreated;
                if (MigrateFromChatId != 0) return MessageType.MigratedFromGroup;
                if (MigrateToChatId != 0) return MessageType.MigratedToSupergroup;

                return MessageType.Unknown;
            }
        }
    }
}
