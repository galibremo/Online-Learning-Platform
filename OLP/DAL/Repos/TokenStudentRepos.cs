using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class TokenStudentRepos : Repo, IRepo<TokenStudent, TokenStudent, int>
    {
        public TokenStudent create(TokenStudent obj)
        {
            db.TokenStudents.Add(obj);
            db.SaveChanges();
            return obj;
        }

        public TokenStudent delete(int id)
        {
            throw new NotImplementedException();
        }

        public TokenStudent update(TokenStudent obj)
        {
            throw new NotImplementedException();
        }

        public TokenStudent view(int id)
        {
            return db.TokenStudents.Find(id);
        }

        public List<TokenStudent> viewAll()
        {
            return db.TokenStudents.ToList();
        }
    }
}
