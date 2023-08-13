using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class TokenRepos : Repo, IRepo<Token, Token, int>
    {
        public Token create(Token obj)
        {
            db.Tokens.Add(obj);
            db.SaveChanges();
            return obj;

        }

        public bool delete(int id)
        {
            throw new NotImplementedException();
        }

        public Token update(Token obj)
        {
            throw new NotImplementedException();
        }

        public Token view(int id)
        {
            return db.Tokens.Find(id);
        }

        public List<Token> viewAll()
        {
            throw new NotImplementedException();
        }
    }
}
