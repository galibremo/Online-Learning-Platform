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
    public class FeedbackServices
    {
        public static List<FeedbackDTO> GetFeedbacks(int id)
        {
            var data = (from i in DAF.AccessFeedback().viewAll() where i.cid == id select i).ToList();
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<Feedback, FeedbackDTO>(); });
            var mapper = new Mapper(config);
            var cnvt = mapper.Map<List<FeedbackDTO>>(data);
            return cnvt;

        }
        public static bool UpdateFeedback(FeedbackDTO t)
        {
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<FeedbackDTO, Feedback>(); });
            var mapper = new Mapper(config);
            var cnvt = mapper.Map<Feedback>(t);
            var data = DAF.AccessFeedback().update(cnvt);
            return data;

        }
        public static bool DeleteFeedback(int id)
        {
            var data = DAF.AccessFeedback().delete(id);
            return data;

        }
        public static bool CreateFeedback(FeedbackDTO f)
        {
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<FeedbackDTO, Feedback>(); });
            var mapper = new Mapper(config);
            var cnvt = mapper.Map<Feedback>(f);
            var data = DAF.AccessFeedback().create(cnvt);
            return data;
        }
    }
}
