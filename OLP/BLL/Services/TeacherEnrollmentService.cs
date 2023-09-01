using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class TeacherEnrollmentService
    {
        public static List<EnrollmentsDTO> GetEnrollment(int id)
        {
            var data = DAF.AccessEnrollments().viewAll();
            var res = (from e in data where e.tid == id select e).ToList();
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<Enrollments, EnrollmentsDTO>(); });
            var mapper = new Mapper(config);
            var cnvt = mapper.Map<List<EnrollmentsDTO>>(data);
            return cnvt;
        }
        public static List<EnrollmentsDTO> GetEnrollmentByCid(int cid, int tid)
        {
            var data = DAF.AccessEnrollments().viewAll();
            var res = (from e in data where e.cid == cid && e.tid == tid select e).ToList();
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<Enrollments, EnrollmentsDTO>(); });
            var mapper = new Mapper(config);
            var cnvt = mapper.Map<List<EnrollmentsDTO>>(data);
            return cnvt;
        }
        public static bool DeleteEnrollment(int id)
        {
            var data = DAF.AccessEnrollments().delete(id);
            return data;
        }
        public static int TotalCourseStudent(int id)
        {
            var data = (from i in DAF.AccessEnrollments().viewAll() where i.cid == id select i).ToList().Count();
            return data;
        }
        public static Dictionary<string, int> AnalyzeStudent(int tid, int sid)
        {
            Dictionary<string, int> data = new Dictionary<string, int>();
            int marks = 0;
            int cn = 0;
            var counts = 0;
            var ce = (from i in DAF.AccessEnrollments().viewAll() where i.tid == tid && i.sid == sid select i).ToList().Count();
            var cv = (from j in DAF.AccessCourses().viewAll() where j.tid == tid select j.id).ToList();
            foreach (var i in cv)
            {
                var views = (from j in DAF.AccessTeacherViews().viewAll() where j.StuId == sid && j.CrsId == i select j).ToList().Count();
                counts += views;
            }
            var m = (from i in DAF.AccessTeacher().view(tid).assignments select i.id).ToList();
            foreach (var j in m)
            {
                var res = (from i in DAF.AccessSubmissions().viewAll() where i.aid == j && i.sid == sid select i.marks).SingleOrDefault();
                marks += res;
                ++cn;
            }
            data["TotalCoursesEnrolled"] = ce;
            data["TotalContentViewed"] = counts;
            data["AverageMark"] = marks / cn;
            return data;


        }
    }
}
