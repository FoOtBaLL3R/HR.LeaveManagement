namespace HR.LeaveManagement.Application.DTO.LeaveRequest
{
    public class CreateLeaveRequestDto : ILeaveRequestDto
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Guid LeaveTypeId { get; set; }        
        public string RequstComments { get; set; }

    }
}
