using AutoMapper;
using BLL.DTOs;
using DAL.EF.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace BLL.Services
{
    public class MyCourseServices
    {
        public static bool Create(MyCourseDTO c)
        {
            var getActvcrs = (from i in DAF.AccessStudent().viewAll()
                              where i.Student_Id == c.StuId
                              select i).SingleOrDefault();
            if(getActvcrs.NumOfActvCrs < 3)
            {
                var config = new MapperConfiguration(cfg => { cfg.CreateMap<MyCourseDTO, MyCourse>(); });
                var mapper = new Mapper(config);
                var converted = mapper.Map<MyCourse>(c);
                DAF.AccessMyCourse().create(converted);
                var std = DAF.AccessStudent().view(c.StuId);
                std.NumOfActvCrs = std.NumOfActvCrs + 1;
                return DAF.AccessStudent().update(std);
            }
            return false;
            
        }
        public static MyCourseStudentDTO GetWithStnt(int id)
        {
            var data = DAF.AccessMyCourse().view(id);
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<MyCourse, MyCourseStudentDTO>();
                cfg.CreateMap<Student, StudentDTO>();
            });
            var mapper = new Mapper(config);
            var cnvrt = mapper.Map<MyCourseStudentDTO>(data);
            return cnvrt;
        }
        public static List<MyCourseDTO> Get()
        {
            var data = DAF.AccessMyCourse().viewAll();
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<MyCourse, MyCourseDTO>(); });
            var mapper = new Mapper(config);
            var cnvrt = mapper.Map<List<MyCourseDTO>>(data);
            return cnvrt;
        }
        public static MyCourseDTO Get(int id)
        {
            var data = DAF.AccessMyCourse().view(id);
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<MyCourse, MyCourseDTO>(); });
            var mapper = new Mapper(config);
            var cnvrt = mapper.Map<MyCourseDTO>(data);
            return cnvrt;
        }
        public static bool Update(MyCourseDTO c)
        {
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<MyCourseDTO, MyCourse>(); });
            var mapper = new Mapper(config);
            var converted = mapper.Map<MyCourse>(c);
            var res = DAF.AccessMyCourse().update(converted);
            return res;
        }
        public static bool Delete(int id)
        {
            var res = DAF.AccessMyCourse().delete(id);
            return res;
        }
    }
}
