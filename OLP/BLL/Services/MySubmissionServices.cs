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
    public class MySubmissionServices
    {
        public static bool Create(MySubmissionDTO s)
        {
            var ass = DAF.AccessMyAssignment().view(s.AssId);
            ass.Status = "Submitted";
            DAF.AccessMyAssignment().update(ass);
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<MySubmissionDTO, MySubmission>(); });
            var mapper = new Mapper(config);
            var converted = mapper.Map<MySubmission>(s);
            var res = DAF.AccessMySubmission().create(converted);
            return res;
        }
        public static List<MySubmissionDTO> Get()
        {
            var data = DAF.AccessMySubmission().viewAll();
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<MySubmission, MySubmissionDTO>(); });
            var mapper = new Mapper(config);
            var cnvrt = mapper.Map<List<MySubmissionDTO>>(data);
            return cnvrt;
        }
        public static MySubmissionDTO Get(int id)
        {
            var data = DAF.AccessMySubmission().view(id);
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<MySubmission, MySubmissionDTO>(); });
            var mapper = new Mapper(config);
            var cnvrt = mapper.Map<MySubmissionDTO>(data);
            return cnvrt;
        }
        public static bool Update(MySubmissionDTO a)
        {
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<MySubmissionDTO, MySubmission>(); });
            var mapper = new Mapper(config);
            var converted = mapper.Map<MySubmission>(a);
            var res = DAF.AccessMySubmission().update(converted);
            return res;
        }
        public static bool Delete(int id)
        {
            var res = DAF.AccessMySubmission().delete(id);
            return res;
        }
    }
}