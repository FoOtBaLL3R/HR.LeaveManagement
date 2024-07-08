﻿using HR.LeaveManagement.Application.DTO.Common;

namespace HR.LeaveManagement.Application.DTO.LeaveAllocation
{
    public class UpdateLeaveAllocationDto : BaseDto
    {
        public int NumberOfDays { get; set; }
        public Guid LeaveTypeId { get; set; }
        public int Period { get; set; }
    }
}
