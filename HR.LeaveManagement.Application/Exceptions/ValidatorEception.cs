using FluentValidation.Results;

namespace HR.LeaveManagement.Application.Exceptions
{
    public class ValidatorEception : ApplicationException
    {
        public List<string> Errors { get; set; } = new List<string>();

        public ValidatorEception(ValidationResult validationResult)
        {
            foreach (var error in validationResult.Errors)
            {
                Errors.Add(error.ErrorMessage);
            }
        }
    }
}
