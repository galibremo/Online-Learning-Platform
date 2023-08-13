using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class UserRepos : Repo, IRepo<User, bool, string>, IAuth
    {
        public User Authenticate(string username, string password, string type)
        {
            var data = from u in db.Users
                       where u.Username.Equals(username)
                       && u.Password.Equals(password)
                       && u.UserType.Equals(type)
                       select u;
            return data.SingleOrDefault();
        }

        public bool create(User obj)
        {
            throw new NotImplementedException();
        }

        public bool delete(string id)
        {
            throw new NotImplementedException();
        }

        public bool update(User obj)
        {
            throw new NotImplementedException();
        }

        public User view(string id)
        {
            throw new NotImplementedException();
        }

        public List<User> viewAll()
        {
            throw new NotImplementedException();
        }
    }
}
