using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class MyCourseRepos : Repo, IRepo<MyCourse, bool, int>
    {
        public bool create(MyCourse obj)
        {
            db.MyCourses.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool delete(int id)
        {
            var exp = db.MyCourses.Find(id);
            db.MyCourses.Remove(exp);
            return db.SaveChanges() > 0;
        }

        public List<MyCourse> viewAll()
        {
            return db.MyCourses.ToList();
        }

        public MyCourse view(int id)
        {
            return db.MyCourses.Find(id);
        }

        public bool update(MyCourse obj)
        {
            var exp = db.MyCourses.Find(obj.Id);
            exp.Title = obj.Title;
            exp.Description = obj.Description;
            exp.EnrDate = obj.EnrDate;
            exp.StuId = obj.StuId;
            return db.SaveChanges() > 0;
        }
    }
}
