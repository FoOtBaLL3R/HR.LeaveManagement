using HR.LeaveManagement.Application.DTO.LeaveRequest;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveRequests.Requests.Commands
{
    public class CreateLeaveRequestCommand : IRequest<Guid>
    {
        public CreateLeaveRequestDto LeaveRequestDto { get; set; }
    }
}
