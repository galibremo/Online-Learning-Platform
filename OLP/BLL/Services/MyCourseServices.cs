using AutoMapper;
using BLL.DTOs;
using DAL.EF.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class MyCourseServices
    {
        public static bool Create(MyCourseDTO c)
        {
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<MyCourseDTO, MyCourse>(); });
            var mapper = new Mapper(config);
            var converted = mapper.Map<MyCourse>(c);
            var res = DAF.AccessMyCourse().create(converted);
            return res;
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
