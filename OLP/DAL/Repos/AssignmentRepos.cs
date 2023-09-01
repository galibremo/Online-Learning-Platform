using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class AssignmentRepos : Repo, IRepo<Assignments, bool, int>
    {
        public bool create(Assignments obj)
        {
            db.Assignments.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool delete(int id)
        {
            var del = db.Assignments.Find(id);
            if (del != null)
            {
                if (del.deadline > DateTime.Now)
                {
                    del.status = "Inactive";
                }
            }

            return db.SaveChanges() > 0;
        }

        public bool update(Assignments a)
        {
            var up = db.Assignments.Find(a.id);
            up.title = a.title;
            up.deadline = a.deadline;
            return db.SaveChanges() > 0;
        }

        public Assignments view(int id)
        {
            return db.Assignments.Find(id);
        }

        public List<Assignments> viewAll()
        {
            return db.Assignments.ToList();
        }
    }
}
