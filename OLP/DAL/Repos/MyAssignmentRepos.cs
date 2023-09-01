using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class MyAssignmentRepos : Repo, IRepo<MyAssignment, bool, int>
    {

        public bool create(MyAssignment obj)
        {
            db.MyAssignments.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool delete(int id)
        {
            var exp = db.MyAssignments.Find(id);
            db.MyAssignments.Remove(exp);
            return db.SaveChanges() > 0;
        }

        public List<MyAssignment> viewAll()
        {
            return db.MyAssignments.ToList();
        }

        public MyAssignment view(int id)
        {
            return db.MyAssignments.Find(id);
        }

        public bool update(MyAssignment obj)
        {
            var exp = db.MyAssignments.Find(obj.Id);
            exp.Title = obj.Title;
            exp.Deadline = obj.Deadline;
            exp.TsrId = obj.TsrId;
            exp.Status = obj.Status;
            exp.CrsId = obj.CrsId;
            exp.StuId = obj.StuId;
            return db.SaveChanges() > 0;
        }
    }
}