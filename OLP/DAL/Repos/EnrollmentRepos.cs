using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class EnrollmentRepos : Repo, IRepo<Enrollments, bool, int>
    {
        public bool create(Enrollments obj)
        {
            throw new NotImplementedException();
        }

        public bool delete(int id)
        {
            var del = db.Enrollments.Find(id);
            db.Enrollments.Remove(del);
            return db.SaveChanges() > 0;
        }

        public bool update(Enrollments e)
        {
            throw new NotImplementedException();
        }

        public Enrollments view(int id)
        {
            return db.Enrollments.Find(id);
        }

        public List<Enrollments> viewAll()
        {
            return db.Enrollments.ToList();
        }

    }
}
