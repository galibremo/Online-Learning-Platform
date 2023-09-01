using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class AdminAuth
    {
        public static TokenAdminDTO Login(string username, string password)
        {
            var res = DAF.AccessAuthenticateAdmin().AuthenticateAdmin(username, password);
            if (res != null)
            {
                var tk = new Token();
                tk.key = Guid.NewGuid().ToString();
                tk.created = DateTime.Now;
                tk.expiredDate = DateTime.Now.AddDays(1);
                tk.aid = (from t in DAF.AccessAdmin().viewAll() where t.username.Equals(username) select t.id).SingleOrDefault();
                var token = DAF.AccessAdminToken().create(tk);
                var config = new MapperConfiguration(cfg => { cfg.CreateMap<Token, TokenAdminDTO>(); });
                var mapper = new Mapper(config);
                var cnvt = mapper.Map<TokenAdminDTO>(token);
                return cnvt;
            }
            return null;
        }
        public static bool isAdminTokenValid(string key)
        {
            var data = (from t in DAF.AccessAdminToken().viewAll() where t.key.Equals(key) && t.expiredDate > DateTime.Now select t).SingleOrDefault();
            return data != null;

        }
        public static bool isAdmin(string key)
        {
            var data = (from t in DAF.AccessAdminToken().viewAll() where t.key.Equals(key) && t.expiredDate > DateTime.Now && t.Admin.username.Equals("admin") select t).SingleOrDefault();
            return data != null;
        }

    }
}
