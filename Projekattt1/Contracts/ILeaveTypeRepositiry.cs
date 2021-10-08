using Projekattt1.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekattt1.Contracts
{
    public interface ILeaveTypeRepositiry : IRepositiryBase<LeaveTypes>
    {
        ICollection<LeaveTypes> GetEmployeesByLeaveType(int id);
    }
}
