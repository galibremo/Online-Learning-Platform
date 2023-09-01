using AutoMapper;
using AutoMapper.Configuration.Conventions;
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
    public class AssignmentService
    {
        public static List<AssignmentsDTO> GetAllAssignments(int cid, int tid)
        {
            var data = DAF.AccessAssignments().viewAll();
            var contents = (from i in data where i.cid == cid && i.tid == tid select i).ToList();
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<Assignments, AssignmentsDTO>(); });
            var mapper = new Mapper(config);
            var cnvt = mapper.Map<List<AssignmentsDTO>>(contents);
            return cnvt;
        }
        public static AssignmentsDTO GetAssignments(int id)
        {
            var data = DAF.AccessAssignments().view(id);
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<Assignments, AssignmentsDTO>(); });
            var mapper = new Mapper(config);
            var cnvt = mapper.Map<AssignmentsDTO>(data);
            return cnvt;
        }
        public static bool UpdateAssignments(AssignmentsDTO a)
        {
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<AssignmentsDTO, Assignments>(); });
            var mapper = new Mapper(config);
            var cnvt = mapper.Map<Assignments>(a);
            var data = DAF.AccessAssignments().update(cnvt);
            return data;
        }
        public static bool DeleteAssignments(int id)
        {
            var data = DAF.AccessAssignments().delete(id);
            return data;
        }
        public static bool CreateAssignments(AssignmentsDTO a)
        {
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<AssignmentsDTO, Assignments>(); });
            var mapper = new Mapper(config);
            var cnvt = mapper.Map<Assignments>(a);
            var data = DAF.AccessAssignments().create(cnvt);
            return data;
        }

    }
}
