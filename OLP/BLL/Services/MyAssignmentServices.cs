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
    public class MyAssignmentServices
    {
        public static bool Create(MyAssignmentDTO a)
        {
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<MyAssignmentDTO, MyAssignment>(); });
            var mapper = new Mapper(config);
            var converted = mapper.Map<MyAssignment>(a);
            var res = DAF.AccessMyAssignment().create(converted);
            return res;
        }
        public static List<MyAssignmentDTO> Get()
        {
            var data = DAF.AccessMyAssignment().viewAll();
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<MyAssignment, MyAssignmentDTO>(); });
            var mapper = new Mapper(config);
            var cnvrt = mapper.Map<List<MyAssignmentDTO>>(data);
            return cnvrt;
        }
        public static MyAssignmentDTO Get(int id)
        {
            var data = DAF.AccessMyAssignment().view(id);
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<MyAssignment, MyAssignmentDTO>(); });
            var mapper = new Mapper(config);
            var cnvrt = mapper.Map<MyAssignmentDTO>(data);
            return cnvrt;
        }
        public static bool Update(MyAssignmentDTO a)
        {
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<MyAssignmentDTO, MyAssignment>(); });
            var mapper = new Mapper(config);
            var converted = mapper.Map<MyAssignment>(a);
            var res = DAF.AccessMyAssignment().update(converted);
            return res;
        }
        public static bool Delete(int id)
        {
            var res = DAF.AccessMyAssignment().delete(id);
            return res;
        }
    }
}