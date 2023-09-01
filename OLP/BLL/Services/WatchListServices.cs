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
    public class WatchListServices
    {
        public static bool Create(WatchListDTO w)
        {

            var TotalContentsInContents = (from i in DAF.AccessContents().viewAll()
                                           where i.cid == w.CrsId
                                           select i).ToList().Count();

            var TotalContentsInList = (from i in DAF.AccessWatchList().viewAll()
                                       where i.CrsId == w.CrsId
                                       select i).ToList().Count();
            if (TotalContentsInContents == TotalContentsInList + 1)
            {
                var ass = (from i in DAF.AccessMyCourse().viewAll()
                           where i.Id == w.MyCrsId && i.StuId == w.StuId
                           select i).SingleOrDefault();
                ass.Status = "Finished";
                DAF.AccessMyCourse().update(ass);
            }

            var config = new MapperConfiguration(cfg => { cfg.CreateMap<WatchListDTO, WatchList>(); });
            var mapper = new Mapper(config);
            var converted = mapper.Map<WatchList>(w);
            return DAF.AccessWatchList().create(converted);

        }
        public static List<WatchListDTO> Get()
        {
            var data = DAF.AccessWatchList().viewAll();
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<WatchList, WatchListDTO>(); });
            var mapper = new Mapper(config);
            var cnvrt = mapper.Map<List<WatchListDTO>>(data);
            return cnvrt;
        }
        public static WatchListDTO Get(int id)
        {
            var data = DAF.AccessWatchList().view(id);
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<WatchList, WatchListDTO>(); });
            var mapper = new Mapper(config);
            var cnvrt = mapper.Map<WatchListDTO>(data);
            return cnvrt;
        }
        public static bool Update(WatchListDTO s)
        {
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<WatchListDTO, WatchList>(); });
            var mapper = new Mapper(config);
            var converted = mapper.Map<WatchList>(s);
            var res = DAF.AccessWatchList().update(converted);
            return res;
        }
        public static bool Delete(int id)
        {
            var res = DAF.AccessWatchList().delete(id);
            return res;
        }
    }
}
