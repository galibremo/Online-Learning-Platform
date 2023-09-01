using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class CourseRepos : Repo, IRepo<Course, bool, int>
    {
        public bool create(Course obj)
        {
            db.Courses.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool delete(int id)
        {
            var del = db.Courses.Find(id);
            db.Courses.Remove(del);
            return db.SaveChanges() > 0;
        }

        public bool update(Course c)
        {
            var up = db.Courses.Find(c.id);
            up.title = c.title;
            up.created = c.created;
            up.description = c.description;
            return db.SaveChanges() > 0;


        }

        public Course view(int id)
        {
            return db.Courses.Find(id);
        }

        public List<Course> viewAll()
        {
            return db.Courses.ToList();
        }
    }
}
