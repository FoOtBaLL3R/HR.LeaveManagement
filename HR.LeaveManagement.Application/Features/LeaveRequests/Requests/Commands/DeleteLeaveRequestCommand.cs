using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveRequests.Requests.Commands
{
    public class DeleteLeaveRequestCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
