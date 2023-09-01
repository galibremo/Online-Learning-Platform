using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class TokenTeacherRepo : Repo, IRepo<TokenTeacher, TokenTeacher, int>
    {
        public TokenTeacher create(TokenTeacher obj)
        {
            db.TokenTeachers.Add(obj);
            db.SaveChanges();
            return obj;

        }

        public TokenTeacher delete(int id)
        {
            throw new NotImplementedException();
        }

        public TokenTeacher update(TokenTeacher obj)
        {
            throw new NotImplementedException();
        }

        public TokenTeacher view(int id)
        {
            return db.TokenTeachers.Find(id);
        }

        public List<TokenTeacher> viewAll()
        {
            return db.TokenTeachers.ToList();
        }
    }
}
