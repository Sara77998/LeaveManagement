using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projekattt1.Models
{
    public class LeaveAllocationVM
    {       
        public int Id { get; set; }
        
        public int NumberOfDays { get; set; }
        public DateTime DataCreated { get; set; }

        public int Period { get; set; }
        public EmployeeVM Employee { get; set; }
        public string EmployeeId { get; set; }    
        
        public LeaveTypeVM LeaveType { get; set; }
        public int LeaveTypeId { get; set; }


       
        
    }
    public class CreateLeaveAllocationVM
    {
        public int NumberUpdated { get; set; }
        public List<LeaveTypeVM> LeaveTypes { get; set; }
    }
    public class EditLeaveAllocationVM
    {
        public int Id { get; set; }
        public EmployeeVM Employee { get; set; }
        public string EmployeeId { get; set; }
        public int NumberOfDays{ get; set; }
        public List<LeaveTypeVM> LeaveTypes { get; set; }
    }
    public class ViewAllocationsVM
    {
        public EmployeeVM Employee { get; set; }
        public string EmployeeId { get; set; }
        public List<LeaveAllocationVM> LeaveAllocations { get; set; }
    }
}
