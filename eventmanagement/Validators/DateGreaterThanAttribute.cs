using System.ComponentModel.DataAnnotations;

namespace eventmanagement.Validators
{
    public class DateGreaterThanAttribute : ValidationAttribute
    {
        private readonly string _comparisonPropertyName;

        public DateGreaterThanAttribute(string comparisonPropertyName)
        {
            _comparisonPropertyName = comparisonPropertyName;
        }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var currentDate = (DateTime) value;
            var dateToCompare = (DateTime) validationContext.ObjectType
                .GetProperty(_comparisonPropertyName).GetValue(validationContext.ObjectInstance);

            if (currentDate <= dateToCompare)
            {
                return new ValidationResult(ErrorMessage = $"Дата {validationContext.MemberName} должна быть больше чем {dateToCompare}.");
            }

            return ValidationResult.Success;
        }
    }
}
