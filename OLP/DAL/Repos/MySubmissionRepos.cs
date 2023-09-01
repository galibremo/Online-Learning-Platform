using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class MySubmissionRepos : Repo, IRepo<MySubmission, bool, int>
    {
        public bool create(MySubmission obj)
        {
            db.MySubmissions.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool delete(int id)
        {
            var exp = db.MySubmissions.Find(id);
            db.MySubmissions.Remove(exp);
            return db.SaveChanges() > 0;
        }

        public List<MySubmission> viewAll()
        {
            return db.MySubmissions.ToList();
        }

        public MySubmission view(int id)
        {
            return db.MySubmissions.Find(id);
        }

        public bool update(MySubmission obj)
        {
            var exp = db.MySubmissions.Find(obj.Id);
            exp.SubmitDate = obj.SubmitDate;
            exp.CourseContent = obj.CourseContent;
            exp.AssId = obj.AssId;
            exp.StuId = obj.StuId;
            return db.SaveChanges() > 0;
        }
    }
}