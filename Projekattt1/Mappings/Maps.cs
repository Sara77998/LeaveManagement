using AutoMapper;
using Projekattt1.Data;
using Projekattt1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekattt1.Mappings
{
    public class Maps : Profile
    {
        public Maps()
        {
            CreateMap<LeaveTypes, LeaveTypeVM>().ReverseMap();
            
            CreateMap<LeaveHistory, LeaveHistoryVM>().ReverseMap();
            CreateMap<LeaveAllocation, LeaveAllocationVM>().ReverseMap();
            CreateMap<Employee, EmployeeVM>().ReverseMap();

        }
    }
}
