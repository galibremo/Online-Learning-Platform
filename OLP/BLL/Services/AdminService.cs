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
    public class AdminService
    {
       
        public static bool UpdateAdmin(AdminDTO d)
        {
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<AdminDTO, Admin>(); });
            var mapper = new Mapper(config);
            var cnvt = mapper.Map<Admin>(d);
            var data = DAF.AccessAdmin().update(cnvt);
            return data;

        }
      
       
    }
}
