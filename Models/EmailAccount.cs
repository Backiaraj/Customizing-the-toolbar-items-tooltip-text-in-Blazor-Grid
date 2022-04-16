using ServerApp.Models.CustomValidators;
using System;
using System.ComponentModel.DataAnnotations;

namespace ServerApp.Models
{
    public class EmailAccount : IEquatable<EmailAccount>
    {
        public int Id { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string IMAP_Host { get; set; }
        [Required]
        public string IMAP_Port { get; set; }
        public bool IMAP_UseSSL { get; set; }

        [RequiredIfNotExternalSMTP]
        public string SMTP_Host { get; set; }

        [RequiredIfNotExternalSMTP]
        public string SMTP_Port { get; set; }
        public bool SMTP_UseSSL { get; set; }

        public bool IsDefault { get; set; }

        public bool UseExternalSMTP_Provider { get; set; }

        public int SendInBlueApiConfigId { get; set; }

        [RequiredIfExplicityRequired]
        public SendInBlueApiConfig SendInBlueApiConfig { get; set; }

        public bool Equals(EmailAccount other)
        {
            if (Equals(Id, other.Id) &&
                Equals(Email, other.Email) &&
                Equals(UserName, other.UserName) &&
                Equals(Password, other.Password) &&
                Equals(IMAP_Host, other.IMAP_Host) &&
                Equals(IMAP_Port, other.IMAP_Port) &&
                Equals(IMAP_UseSSL, other.IMAP_UseSSL) &&
                Equals(SMTP_Host, other.SMTP_Host) &&
                Equals(SMTP_Port, other.SMTP_Port) &&
                Equals(SMTP_UseSSL, other.SMTP_UseSSL) &&
                Equals(IsDefault, other.IsDefault) &&
                Equals(SendInBlueApiConfigId, other.SendInBlueApiConfigId))
                return true;
            return false;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as EmailAccount);
        }

        public override int GetHashCode()
        {
            return Id ^ Email?.GetHashCode() ?? 0 ^
                        UserName?.GetHashCode() ?? 0 ^
                        Password?.GetHashCode() ?? 0 ^
                        IMAP_Host?.GetHashCode() ?? 0 ^
                        IMAP_Port?.GetHashCode() ?? 0 ^
                        IMAP_UseSSL.GetHashCode() ^
                        SMTP_Host?.GetHashCode() ?? 0 ^
                        SMTP_Port?.GetHashCode() ?? 0 ^
                        SMTP_UseSSL.GetHashCode() ^
                        IsDefault.GetHashCode() ^
                        SendInBlueApiConfigId;

        }
    }
}
