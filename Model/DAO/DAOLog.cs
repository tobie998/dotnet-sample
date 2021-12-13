using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagedList;
using Model.Framework;

namespace Model.DAO
{
    public class DAOLog
    {
        ManagerDBContext context;
        public DAOLog()
        {
            context = new ManagerDBContext();
        }

        public long Insert(AssignRecord entity)
        {
            context.AssignRecords.Add(entity);
            context.SaveChanges();
            return entity.ID;
        }

        public bool Update(AssignRecord entity)
        {
            try
            {
                var assignRecord = context.AssignRecords.Find(entity.ID);
                assignRecord.WorkDate = entity.WorkDate;
                assignRecord.StartTime = entity.StartTime;
                assignRecord.EndTime = entity.EndTime;
                assignRecord.Shift = entity.Shift;
                //assignRecord.ProductID = entity.ProductID;
                context.SaveChanges();
                return true;
            }
            catch (Exception error)
            {
                return false;
            } 
        }

        public AssignRecord ViewByID (int id)
        {
            return context.AssignRecords.Find(id);
        }

        public bool Delete(int id)
        {
            try
            {
                var assignRecord = context.AssignRecords.Find(id);
                context.AssignRecords.Remove(assignRecord);
                context.SaveChanges();
                return true;
            } catch (Exception error)
            {
                return false;
            }
        }

        public IEnumerable<AssignRecord> ListAllPaging(int page, int pageSize)
        {
            return context.AssignRecords.OrderBy(x => x.ID).ToPagedList(page, pageSize);
        }
    }
}
