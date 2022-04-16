using System.ComponentModel.DataAnnotations;

namespace ServerApp.Models.CustomValidators
{
    public class RequiredIfNotExternalSMTP : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var property = validationContext.ObjectType.GetProperty("UseExternalSMTP_Provider");
            if (property == null)
                return new ValidationResult(string.Format("Unknown property: {0}", "UseExternalSMTP_Provider"));
            var systemDefault = property.GetValue(validationContext.ObjectInstance, null) as bool?;
            if (!systemDefault.HasValue)
                return new ValidationResult(string.Format("System Default: {0}", "null"));
            if (systemDefault.Value)
                return null;
            else
                return new ValidationResult(string.Format("The Field: {0} is Reqired !", validationContext.DisplayName));
        }
    }
}
