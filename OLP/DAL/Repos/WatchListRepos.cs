using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class WatchListRepos : Repo, IRepo<WatchList, bool, int>
    {
        public bool create(WatchList obj)
        {
            db.WatchLists.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool delete(int id)
        {
            var exp = db.WatchLists.Find(id);
            db.WatchLists.Remove(exp);
            return db.SaveChanges() > 0;
        }

        public bool update(WatchList obj)
        {
            var exp = db.WatchLists.Find(obj.Id);
            exp.CourseTitle = obj.CourseTitle;
            exp.ContentTitle = obj.ContentTitle;
            exp.ContentStatus = obj.ContentStatus;
            exp.StuId = obj.StuId;
            exp.CntId = obj.CntId;
            exp.CrsId = obj.CrsId;
            exp.MyCrsId = obj.MyCrsId;
            return db.SaveChanges() > 0;
        }

        public WatchList view(int id)
        {
            return db.WatchLists.Find(id);
        }

        public List<WatchList> viewAll()
        {
            return db.WatchLists.ToList();
        }
    }
}
