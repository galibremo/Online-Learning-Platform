using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class StudentRepos : Repo, IRepo<Student, bool, int>
    {
        public bool create(Student obj)
        {
            db.Students.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool delete(int id)
        {
            var exp = db.Students.Find(id);
            db.Students.Remove(exp);
            return db.SaveChanges() > 0;
        }

        public List<Student> viewAll()
        {
            return db.Students.ToList();
        }

        public Student view(int id)
        {
            return db.Students.Find(id);
        }

        public bool update(Student obj)
        {
            var exp = db.Students.Find(obj.Student_Id);
            exp.Student_Name = obj.Student_Name;
            exp.Email = obj.Email;
            exp.DOB = obj.DOB;
            return db.SaveChanges() > 0;
        }
    }
}
