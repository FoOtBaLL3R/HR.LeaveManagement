﻿using HR.LeaveManagement.Domain.Common;

namespace HR.LeaveManagement.Domain
{
    public class LeaveRequest : BaseDomainEntity
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public LeaveType LeaveType { get; set; }
        public Guid LeaveTypeId { get; set; }
        public DateTime DateRequested {  get; set; }
        public string RequestComments { get; set; }
        public DateTime DateActioned { get; set; }
        public bool? Approved { get; set; }
        public bool Canceled { get; set; }

    }
}
