using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class TeacherProfRepos : Repo, IRepo<Teacher, bool, int>, ITeacherAuth
    {
        public Teacher AuthenticateTeacher(string username, string password)
        {
            var data = (from t in db.Teachers where t.name == username && t.password == password select t).SingleOrDefault();
            return data;
        }

        public bool create(Teacher obj)
        {
            var check = (from i in db.Teachers where i.name.Equals(obj.name) select i).SingleOrDefault();
            if (check == null)
            {
                db.Teachers.Add(obj);
                return db.SaveChanges() > 0;
            }
            return false;

        }

        public bool delete(int id)
        {
            var del = db.Teachers.Find(id);
            db.Teachers.Remove(del);
            return db.SaveChanges() > 0;
        }

        public bool update(Teacher t)
        {
            var up = db.Teachers.Find(t.id);
            up.name = t.name;
            up.email = t.email;
            up.password = t.password;
            return db.SaveChanges() > 0;
        }

        public Teacher view(int id)
        {
            return db.Teachers.Find(id);
        }

        public List<Teacher> viewAll()
        {
            return db.Teachers.ToList();
        }
    }
}
