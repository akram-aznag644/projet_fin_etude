using System.ComponentModel.DataAnnotations;

namespace projet_fin_etude.Validation
{
    public class RoleValidation : ValidationAttribute
    {
        private readonly string[] _allowedRoles = { "Admin", "JobApplicant", "Employer" };

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value is string role && _allowedRoles.Contains(role)){

                return ValidationResult.Success;
            }

            return new ValidationResult($"Role must be one of: {string.Join(", ", _allowedRoles)}");
        }
    }
}
