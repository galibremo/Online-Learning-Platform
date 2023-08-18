using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class ContentsRepos : Repo, IRepo<Contents, bool, int>
    {
        public bool create(Contents obj)
        {
            db.Contents.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool delete(int id)
        {
            var exp = db.Contents.Find(id);
            db.Contents.Remove(exp);
            return db.SaveChanges() > 0;
        }

        public bool update(Contents obj)
        {
            throw new NotImplementedException();
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
