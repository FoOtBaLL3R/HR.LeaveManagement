
using HR.LeaveManagement.Application.DTO.LeaveAllocation;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveAllocations.Requests.Commands
{
    public class CreateLeaveAllocationCommand : IRequest<Guid>
    {
        public LeaveAllocationDto LeaveAllocationDto { get; set; }
    }
}
