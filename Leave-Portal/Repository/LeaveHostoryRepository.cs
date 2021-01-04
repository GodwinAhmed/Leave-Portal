using Leave_Portal.Contracts;
using Leave_Portal.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_Portal.Repository
{
    public class LeaveHistoryRepository : ILeaveHistoryRepository
    {
        private readonly ApplicationDbContext _db;

        public LeaveHistoryRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool Create(LeaveHistory entity)
        {
            _db.LeaveHistories.Add(entity);
            return Save();
        }

        public bool Delete(LeaveHistory entity)
        {
            _db.LeaveHistories.Remove(entity);
            return Save();
        }

        public ICollection<LeaveHistory> FindAll()
        {
            var LeaveHostories = _db.LeaveHistories.ToList();
            return LeaveHostories;
        }

        public LeaveHistory FindById(int id)
        {
            var LeaveHistory = _db.LeaveHistories.Find(id);
            return LeaveHistory;
        }

        public ICollection<LeaveHistory> GetEmployeesByLeaveHistory(int id)
        {
            throw new NotImplementedException();
        }

        public ICollection<LeaveType> GetEmployeesByLeaveType(int id)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            var changes = _db.SaveChanges();
            return changes > 0;
        }

        public bool Update(LeaveHistory entity)
        {
            _db.LeaveHistories.Update(entity);
            return Save();
        }
    }
}
