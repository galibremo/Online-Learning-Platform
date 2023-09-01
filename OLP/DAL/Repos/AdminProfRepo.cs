using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DAL.Repos
{
    internal class AdminProfRepo : Repo, IRepo<Admin, bool, int>, IAdminAuth
    {
        public Admin AuthenticateAdmin(string username, string password)
        {
            var data = (from t in db.Admins where t.username == username && t.password == password select t).SingleOrDefault();
            return data;
        }
        public bool create(Admin obj)
        {
            db.Admins.Add(obj);
            return db.SaveChanges() > 0;
        }



        public bool delete(int id)
        {
            var exp = db.Admins.Find(id);
            db.Admins.Remove(exp);
            return db.SaveChanges() > 0;
        }



        public bool update(Admin obj)
        {
            var exp = db.Admins.Find(obj.id);
            exp.username = obj.username;
            exp.password = obj.password;
            return db.SaveChanges() > 0;
        }



        public Admin view(int id)
        {
            return db.Admins.Find(id);
        }



        public List<Admin> viewAll()
        {
            return db.Admins.ToList();
        }
    }
}