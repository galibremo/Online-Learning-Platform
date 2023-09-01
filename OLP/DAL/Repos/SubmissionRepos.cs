using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class SubmissionRepos : Repo, IRepo<Submission, bool, int>, ISubMarks
    {
        public bool AddMarks(int id, int mark)
        {
            var data = db.Submissions.Find(id);
            if (data != null)
            {
                data.marks = mark;
            }

            return db.SaveChanges() > 0;
        }

        public bool create(Submission obj)
        {
            throw new NotImplementedException();
        }

        public bool delete(int id)
        {
            var del = db.Submissions.Find(id);
            db.Submissions.Remove(del);
            return db.SaveChanges() > 0;
        }

        public bool update(Submission s)
        {
            throw new NotImplementedException();
        }

        public Submission view(int id)
        {
            var data = db.Submissions.Find(id);
            return data;
        }

        public List<Submission> viewAll()
        {
            return db.Submissions.ToList();
        }
    }
}
