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
    public class CourseService
    {
        public static List<CourseDTO> GetAllCourses(int id)
        {
            var data = DAF.AccessCourses().viewAll();
            var courses = (from i in data where i.tid == id select i).ToList();
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<Course, CourseDTO>(); });
            var mapper = new Mapper(config);
            var cnvt = mapper.Map<List<CourseDTO>>(data);
            return cnvt;
        }
        public static CourseDTO GetCourses(int id)
        {
            var data = DAF.AccessCourses().view(id);
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<Course, CourseDTO>(); });
            var mapper = new Mapper(config);
            var cnvt = mapper.Map<CourseDTO>(data);
            return cnvt;
        }
        public static bool UpdateCourses(CourseDTO c)
        {
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<CourseDTO, Course>(); });
            var mapper = new Mapper(config);
            var cnvt = mapper.Map<Course>(c);
            var data = DAF.AccessCourses().update(cnvt);
            return data;
        }
        public static bool DeleteCourse(int id)
        {
            var data = DAF.AccessCourses().delete(id);
            return data;
        }
        public static bool CreateCourse(CourseDTO c)
        {
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<CourseDTO, Course>(); });
            var mapper = new Mapper(config);
            var cnvt = mapper.Map<Course>(c);
            var data = DAF.AccessCourses().create(cnvt);
            return data;

        }
        public static int CourseViews(int cid)
        {
            var count = DAF.AccessTeacherViews().viewAll();
            var views = (from i in count where i.CrsId == cid select i).ToList().Count();
            return views;

        }
        public static int GetStudentProgress(int cid, int sid)
        {
            var data = (from i in DAF.AccessTeacherViews().viewAll() where i.CrsId == cid && i.StuId == sid select i).ToList().Count();
            var data2 = (from j in DAF.AccessContents().viewAll() where j.cid == cid select j).ToList().Count();
            var res = (data / data2) * 100;
            return res;
        }
       
    }
}
