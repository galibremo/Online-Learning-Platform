using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class FeedbackRepos : Repo, IRepo<Feedback, bool, int>
    {
        public bool create(Feedback obj)
        {
            db.Feedbacks.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool delete(int id)
        {
            var del = db.Feedbacks.Find(id);
            db.Feedbacks.Remove(del);
            return db.SaveChanges() > 0;
        }

        public bool update(Feedback obj)
        {
            var data = db.Feedbacks.Find(obj.id);
            data.sid = obj.sid;
            data.cid = obj.cid;
            data.message = obj.message;
            data.rating = obj.rating;
            return db.SaveChanges() > 0;
        }

        public Feedback view(int id)
        {
            throw new NotImplementedException();
        }

        public List<Feedback> viewAll()
        {
            return db.Feedbacks.ToList();
        }
    }
}
