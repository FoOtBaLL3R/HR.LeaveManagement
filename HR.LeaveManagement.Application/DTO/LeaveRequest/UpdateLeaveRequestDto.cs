using HR.LeaveManagement.Application.DTO.Common;

namespace HR.LeaveManagement.Application.DTO.LeaveRequest
{
    public class UpdateLeaveRequestDto : BaseDto
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Guid LeaveTypeId { get; set; }
        public string RequestComments { get; set; }
        public bool Canceled { get; set; }
    }
}
