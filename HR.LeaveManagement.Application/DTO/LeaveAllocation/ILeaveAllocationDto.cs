using HR.LeaveManagement.Application.DTO.LeaveType;

namespace HR.LeaveManagement.Application.DTO.LeaveAllocation
{
    public interface ILeaveAllocationDto
    {
        public Guid LeaveTypeId { get; set; }
        public int NumberOfDays { get; set; }
        public int Period { get; set; }
    }
}