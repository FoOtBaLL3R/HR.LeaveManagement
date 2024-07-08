using HR.LeaveManagement.Application.DTO.LeaveType;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveTypes.Requests.Commands
{
    public class CreateLeaveTypeCommand : IRequest<Guid>
    {
        public CreateLeaveTypeDto LeaveTypeDto { get; set; }
    }
}
