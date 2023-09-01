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
    public class StudentServices
    {
        public static bool Create(StudentDTO n)
        {
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<StudentDTO, Student>(); });
            var mapper = new Mapper(config);
            var converted = mapper.Map<Student>(n);
            DAF.AccessStudent().create(converted);
            var usr = new User();
            usr.Username = n.Username;
            usr.Password = n.Password;
            usr.UserType = "Student";
            return DAF.AccessUser().create(usr);
        }
        public static StudentMyCourseDTO GetWithStnt(int id)
        {
            var data = DAF.AccessStudent().view(id);
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Student, StudentMyCourseDTO>();
                cfg.CreateMap<MyCourse, MyCourseDTO>();
            });
            var mapper = new Mapper(config);
            var cnvrt = mapper.Map<StudentMyCourseDTO>(data);
            return cnvrt;
        }
        public static List<StudentDTO> Get()
        {
            var data = DAF.AccessStudent().viewAll();
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<Student, StudentDTO>(); });
            var mapper = new Mapper(config);
            var cnvrt = mapper.Map<List<StudentDTO>>(data);
            return cnvrt;
        }
        public static StudentDTO Get(int id)
        {
            var data = DAF.AccessStudent().view(id);
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<Student, StudentDTO>(); });
            var mapper = new Mapper(config);
            var cnvrt = mapper.Map<StudentDTO>(data);
            return cnvrt;
        }
        public static bool Update(StudentDTO s)
        {
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<StudentDTO, Student>(); });
            var mapper = new Mapper(config);
            var converted = mapper.Map<Student>(s);
            var res = DAF.AccessStudent().update(converted);
            return res;
        }
        public static bool Delete(int id)
        {
            var res = DAF.AccessStudent().delete(id);
            return res;
        }
    }
}