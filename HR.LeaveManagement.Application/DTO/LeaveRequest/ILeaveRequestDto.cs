using HR.LeaveManagement.Application.DTO.LeaveType;

namespace HR.LeaveManagement.Application.DTO.LeaveRequest
{
    public interface ILeaveRequestDto
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Guid LeaveTypeId { get; set; }
    }
}
