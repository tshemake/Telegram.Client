using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Telegram.Library.Types;

namespace Telegram.Library.Requests
{
    [JsonConverter(typeof(StringEnumConverter), true)]
    public enum ChatAction
    {
        /// <summary>
        /// Typing
        /// </summary>
        Typing,

        /// <summary>
        /// Uploading a <see cref="PhotoSize"/>
        /// </summary>
        [EnumMember(Value = "upload_photo")]
        UploadPhoto,

        /// <summary>
        /// Recording a <see cref="Video"/>
        /// </summary>
        [EnumMember(Value = "record_video")]
        RecordVideo,

        /// <summary>
        /// Uploading a <see cref="Video"/>
        /// </summary>
        [EnumMember(Value = "upload_video")]
        UploadVideo,

        /// <summary>
        /// Recording an <see cref="Audio"/>
        /// </summary>
        [EnumMember(Value = "record_audio")]
        RecordAudio,

        /// <summary>
        /// Uploading an <see cref="Audio"/>
        /// </summary>
        [EnumMember(Value = "upload_audio")]
        UploadAudio,

        /// <summary>
        /// Uploading <see cref="Document"/>
        /// </summary>
        [EnumMember(Value = "upload_document")]
        UploadDocument,

        /// <summary>
        /// Finding a <see cref="Location"/>
        /// </summary>
        [EnumMember(Value = "find_location")]
        FindLocation,

        /// <summary>
        /// Recording a <see cref="VideoNote"/>
        /// </summary>
        [EnumMember(Value = "record_video_note")]
        RecordVideoNote,

        /// <summary>
        /// Uploading a <see cref="VideoNote"/>
        /// </summary>
        [EnumMember(Value = "upload_video_note")]
        UploadVideoNote,
    }

    public class SendChatActionRequest : RequestWithParameters
    {
        public SendChatActionRequest(ChatId chatId, ChatAction action)
            : base("sendChatAction")
        {
            ChatId = chatId;
            Action = action;
        }

        [JsonProperty(Required = Required.Always)]
        public ChatId ChatId { get; }

        [JsonProperty(Required = Required.Always)]
        public ChatAction Action { get; }
    }
}
