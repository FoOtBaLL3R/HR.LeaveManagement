using HR.LeaveManagement.Application.DTO.LeaveType;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveTypes.Requests.Commands
{
    public class CreateLeaveTypeRequestCommand : IRequest<Guid>
    {
        public LeaveTypeDto LeaveTypeDto { get; set; }
    }
}
