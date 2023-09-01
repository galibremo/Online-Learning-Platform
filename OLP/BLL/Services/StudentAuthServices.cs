using AutoMapper;
using DAL.EF.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DTOs;

namespace BLL.Services
{
    public class StudentAuthServices
    {
        public static TokenStudentDTO Login(string Username, string Password, string Type)
        {
            var data = DAF.AccessAuth().Authenticate(Username, Password, Type);
            if (data != null)
            {
                var token = new TokenStudent();
                token.Username = data.Username;
                token.TokenKey = Guid.NewGuid().ToString();
                token.CreatedAt = DateTime.Now;
                token.ExpiredAt = null;
                var tk = DAF.AccessStudentToken().create(token);
                var config = new MapperConfiguration(cfg => {
                    cfg.CreateMap<TokenStudent, TokenStudentDTO>();
                });
                var mapper = new Mapper(config);
                var ret = mapper.Map<TokenStudentDTO>(tk);
                return ret;
            }
            return null;
        }
        public static bool IsTokenValid(string token)
        {
            var tk = (from t in DAF.AccessStudentToken().viewAll()
                      where t.TokenKey.Equals(token)
                      && t.ExpiredAt == null
                      select t).SingleOrDefault();
            if (tk != null)
            {
                return true;
            }
            return false;
        }
    }
}
