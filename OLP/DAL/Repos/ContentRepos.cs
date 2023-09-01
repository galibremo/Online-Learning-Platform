using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class ContentRepos : Repo, IRepo<Contents, bool, int>
    {
        public bool create(Contents obj)
        {
            var data = db.Courses.Find(obj.cid);
            if (data != null)
            {
                db.Contents.Add(obj);
                return db.SaveChanges() > 0;
            }
            return false;
        }

        public bool delete(int id)
        {
            var del = db.Contents.Find(id);
            db.Contents.Remove(del);
            return db.SaveChanges() > 0;
        }

        public bool update(Contents c)
        {
            var up = db.Contents.Find(c.id);
            up.title = c.title;
            up.created = c.created;
            return db.SaveChanges() > 0;


        }

        public Contents view(int id)
        {
            return db.Contents.Find(id);
        }

        public List<Contents> viewAll()
        {
            return db.Contents.ToList();
        }
    }
}
