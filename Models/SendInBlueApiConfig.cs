using ServerApp.Models.CustomValidators;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ServerApp.Models
{
    public class SendInBlueApiConfig
    {
        public int Id { get; set; }
        [RequiredIfNotDefault]
        public string ApiKey { get; set; }
        [RequiredIfNotDefault]
        public string ApiURL { get; set; }
        [RequiredIfNotDefault]
        public string SMTP_UserName { get; set; }
        [Required]
        public string SMTP_Password { get; set; }
        public bool SystemDefault { get; set; }

        public List<EmailAccount> EmailAccounts { get; set; }
    }
}
