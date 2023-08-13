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
            var res = DAF.AccessStudent().create(converted);
            return res;
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
