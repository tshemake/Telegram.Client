using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Telegram.Library.Models
{
    /// <summary>
    /// Содержит информацию о документах или других элементах Telegram Passport, которыми пользователь делится с ботом.
    /// <see href="https://core.telegram.org/bots/api#encryptedpassportelement"/>
    /// </summary>
    public class EncryptedPassportElement
    {
        [Key]
        public long Id { get; set; }

        /// <summary>
        /// Тип элемента. Один из  "personal_details", "passport", "driver_license", "identity_card",
        /// "internal_passport", "address", "utility_bill", "bank_statement", "rental_agreement",
        /// "passport_registration", "temporary_registration", "phone_number", "email".
        /// </summary>
        [Required]
        public string Type { get; set; }

        /// <summary>
        /// Хэш-элемент в кодировке Base64 для использования в <see cref="PassportElementErrorUnspecified"/>
        /// </summary>
        [Required]
        public string Hash { get; set; }

        /// <summary>
        /// Необязательный. Зашифрованные Base64 данные зашифрованного элемента Telegram Passport, предоставленные пользователем, 
        /// доступны для типов "personal_details", "passport", "driver_license", "identity_card", "identity_passport" and "address".
        /// Может быть расшифрован и проверен с использованием <see cref="EncryptedCredentials"/>.
        /// </summary>
        public string Data { get; set; }

        /// <summary>
        /// Необязательный. Подтвержденный пользователем номер телефона, доступен только для типа «номер телефона»
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Необязательный. Подтвержденный пользователем адрес электронной почты, доступный только для типа «электронная почта»
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Необязательный. Массив зашифрованных файлов с документами, предоставленными пользователем, 
        /// доступными для типов "utility_bill", "bank_statement", "rental_agreement", "passport_registration" 
        /// и "temporary_registration" types.
        /// </summary>
        /// <remarks>
        /// Файлы могут быть расшифрованы и проверены с помощью <see cref="EncryptedCredentials"/>.
        /// </remarks>
        public PassportFile[] Files { get; set; }

        /// <summary>
        /// Необязательный. Зашифрованный файл с лицевой стороны документа, предоставленный пользователем. 
        /// Доступно для "passport", "driver_license", "identity_card" и "internal_passport"
        /// </summary>
        /// <remarks>
        /// Файл может быть расшифрован и проверен с помощью <see cref="EncryptedCredentials"/>.
        /// </remarks>
        public PassportFile FrontSide { get; set; }

        /// <summary>
        /// Необязательный. Зашифрованный файл с обратной стороной документа, предоставленный пользователем.
        /// Доступно для "driver_license" и "identity_card".
        /// </summary>
        /// <remarks>
        /// Файл может быть расшифрован и проверен с помощью <see cref="EncryptedCredentials"/>.
        /// </remarks>
        public PassportFile ReverseSide { get; set; }

        /// <summary>
        /// Необязательный. Зашифрованный файл с селфи пользователя, имеющего документ, предоставленный пользователем;
        /// доступны для "passport", "driver_license", "identity_card" и "internal_passport".
        /// </summary>
        /// <remarks>
        /// Файл может быть расшифрован и проверен с помощью <see cref="EncryptedCredentials"/>.
        /// </remarks>
        public PassportFile Selfie { get; set; }

        /// <summary>
        /// Необязательный. Массив зашифрованных файлов с переведенными версиями документов, предоставленных пользователем.
        /// Доступно, если запрошено для типов "passport", "driver_license", "identity_card", "internal_passport",
        /// "utility_bill", "bank_statement", "rental_agreement", "passport_registration" и
        /// "temporary_registration".
        /// </summary>
        /// <remarks>
        /// Файл может быть расшифрован и проверен с помощью <see cref="EncryptedCredentials"/>.
        /// </remarks>
        public PassportFile[] Translation { get; set; }
    }
}
