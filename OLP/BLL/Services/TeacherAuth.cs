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
    public class TeacherAuth
    {
        public static TokenTeacherDTO Login(string username, string password)
        {
            var res = DAF.AccessAuthenticateTeacher().AuthenticateTeacher(username, password);
            if (res != null)
            {
                var tk = new TokenTeacher();
                tk.key = Guid.NewGuid().ToString();
                tk.created = DateTime.Now;
                tk.expiredDate = DateTime.Now.AddDays(1);
                tk.tid = (from t in DAF.AccessTeacher().viewAll() where t.name.Equals(username) select t.id).SingleOrDefault();
                var token = DAF.AccessTeacherToken().create(tk);
                var config = new MapperConfiguration(cfg => { cfg.CreateMap<TokenTeacher, TokenTeacherDTO>(); });
                var mapper = new Mapper(config);
                var cnvt = mapper.Map<TokenTeacherDTO>(token);
                return cnvt;
            }
            return null;
        }
        public static bool isTeacherTokenValid(string key)
        {
            var data = (from t in DAF.AccessTeacherToken().viewAll() where t.key.Equals(key) && t.expiredDate > DateTime.Now select t).SingleOrDefault();
            return data != null;

        }
        public static bool isTeacher(string key)
        {
            var data = (from t in DAF.AccessTeacherToken().viewAll() where t.key.Equals(key) && t.expiredDate > DateTime.Now && t.teacher.type.Equals("teacher") select t).SingleOrDefault();
            return data != null;
        }
    }
}
