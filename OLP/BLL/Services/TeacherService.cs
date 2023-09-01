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
    public class TeacherService
    {
        public static TeacherDTO GetTeacher(int id)
        {
            var data = DAF.AccessTeacher().view(id);
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<Teacher, TeacherDTO>(); });
            var mapper = new Mapper(config);
            var cnvt = mapper.Map<TeacherDTO>(data);
            return cnvt;

        }
        public static bool UpdateTeacher(TeacherDTO t)
        {
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<TeacherDTO, Teacher>(); });
            var mapper = new Mapper(config);
            var cnvt = mapper.Map<Teacher>(t);
            var data = DAF.AccessTeacher().update(cnvt);
            return data;

        }
        public static bool DeleteTeacher(int id)
        {
            var data = DAF.AccessTeacher().delete(id);
            return data;

        }
        public static bool CreateTeacher(TeacherDTO t)
        {
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<TeacherDTO, Teacher>(); });
            var mapper = new Mapper(config);
            var cnvt = mapper.Map<Teacher>(t);
            var data = DAF.AccessTeacher().create(cnvt);
            return data;
        }
    }
}
