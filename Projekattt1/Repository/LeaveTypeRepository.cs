using Projekattt1.Contracts;
using Projekattt1.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekattt1.Repository
{
    public class LeaveTypeRepository : ILeaveTypeRepositiry
    {
        private readonly ApplicationDbContext _db;
        public LeaveTypeRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public bool Create(LeaveTypes entity)
        {
            _db.LeaveTypes.Add(entity);
            return Save();
        }

        public bool Delete(LeaveTypes entity)
        {
            _db.LeaveTypes.Remove(entity);
            return Save();
        }

        public ICollection<LeaveTypes> FindAll()
        {
            return _db.LeaveTypes.ToList();
        }

        public LeaveTypes FindById(int id)
        {
            var leaveType = _db.LeaveTypes.Find(id);
            return leaveType;
        }

        public ICollection<LeaveTypes> GetEmployeesByLeaveType(int id)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            var changes = _db.SaveChanges();
            return changes > 0;//vraca true ako je >0, false ako je <0
        }

        public bool Update(LeaveTypes entity)
        {
            _db.LeaveTypes.Update(entity);
            return Save();
        }
    }
}
