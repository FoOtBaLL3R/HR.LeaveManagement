﻿
using FluentValidation;
using HR.LeaveManagement.Application.Persistence.Contracts;

namespace HR.LeaveManagement.Application.DTO.LeaveRequest.Validators
{
    public class CreateLeaveRequestDtoValidator : AbstractValidator<CreateLeaveRequestDto>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        public CreateLeaveRequestDtoValidator()
        {
            RuleFor(p => p.StartDate)
                .LessThan(p => p.EndDate).WithMessage("{PropertyName} must be before {ComparisonValue}");

            RuleFor(p => p.EndDate)
                .GreaterThan(p => p.StartDate).WithMessage("{PropertyName} must be after {ComparisonValue}");

            RuleFor(p => p.LeaveTypeId)
                .NotEmpty()
                /*.MustAsync(async (id, token) =>
                {
                    var leaveTypeExists = await _leaveTypeRepository.Exists(id);
                    return !leaveTypeExists;

                })*/
                .WithMessage("{PropertyName} does not exist ");
        }
    }
}