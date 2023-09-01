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
    public class ContentService
    {
        public static List<ContentsDTO> GetAllContents(int id)
        {
            var data = DAF.AccessContents().viewAll();
            var contents = (from i in data where i.cid == id select i).ToList();
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<Contents, ContentsDTO>(); });
            var mapper = new Mapper(config);
            var cnvt = mapper.Map<List<ContentsDTO>>(contents);
            return cnvt;
        }
        public static ContentsDTO GetContent(int id)
        {
            var data = DAF.AccessContents().view(id);
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<Contents, ContentsDTO>(); });
            var mapper = new Mapper(config);
            var cnvt = mapper.Map<ContentsDTO>(data);
            return cnvt;
        }
        public static bool UpdateContent(ContentsDTO c)
        {
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<ContentsDTO, Contents>(); });
            var mapper = new Mapper(config);
            var cnvt = mapper.Map<Contents>(c);
            var data = DAF.AccessContents().update(cnvt);
            return data;
        }
        public static bool DeleteContent(int id)
        {
            var data = DAF.AccessContents().delete(id);
            return data;
        }
        public static bool CreateContent(ContentsDTO c)
        {
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<ContentsDTO, Contents>(); });
            var mapper = new Mapper(config);
            var cnvt = mapper.Map<Contents>(c);
            var data = DAF.AccessContents().create(cnvt);
            return data;

        }
        public static int ContentViews(int cid)
        {
            var count = DAF.AccessTeacherViews().viewAll();
            var views = (from i in count where i.CntId == cid select i).ToList().Count();
            return views;
        }
    }
}
