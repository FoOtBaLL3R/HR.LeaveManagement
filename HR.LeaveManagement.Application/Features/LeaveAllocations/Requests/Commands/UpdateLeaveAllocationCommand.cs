using HR.LeaveManagement.Application.DTO.LeaveAllocation;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveAllocations.Requests.Commands
{
    public class UpdateLeaveAllocationCommand : IRequest<Unit>
    {
        public LeaveAllocationDto LeaveAllocationDto { get; set; }
    }
}
