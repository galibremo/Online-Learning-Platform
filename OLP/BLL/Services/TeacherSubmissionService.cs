using AutoMapper;
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
    public class TeacherSubmissionService
    {
        public static SubmissionDTO GetSubmission(int id)
        {
            var data = DAF.AccessSubmissions().view(id);
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<Submission, SubmissionDTO>(); });
            var mapper = new Mapper(config);
            var cnvt = mapper.Map<SubmissionDTO>(data);
            return cnvt;
        }
        public static bool AddSubmissionMark(int id, int mark)
        {
            var data = DAF.SubmissionMark().AddMarks(id, mark);
            return data;
        }
        public static bool DeleteSubmission(int id)
        {
            var data = DAF.AccessSubmissions().delete(id);
            return data;
        }
        public static List<SubmissionDTO> GetSubmissionsByAid(int id)
        {
            var data = DAF.AccessSubmissions().viewAll();
            var res = (from s in data where s.aid == id select s).ToList();
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<Submission, SubmissionDTO>(); });
            var mapper = new Mapper(config);
            var cnvt = mapper.Map<List<SubmissionDTO>>(res);
            return cnvt;
        }
        public static int GetSubmissionViews(int id)
        {
            var data = DAF.AccessSubmissions().viewAll();
            var res = (from s in data where s.aid == id select s).ToList().Count();
            return res;
        }
        /*public static StudentDTO GetStudentBySid(int sid)
        {
            var data = DAF.AccessSubmissions().view(sid);
            var res = DAF.AccessStudent().view(data.sid);
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<Student, StudentDTO>(); });
            var mapper = new Mapper(config);
            var cnvt = mapper.Map<StudentDTO>(res);
            return cnvt;
        }*/
        public static string PutStudentGrade(int aid, int sid)
        {
            var data = (from i in DAF.AccessSubmissions().viewAll() where i.aid == aid && i.sid == sid select i.marks).SingleOrDefault();
            if (data >= 90)
            {
                return "A";
            }
            else if (data >= 80 && data < 90)
            {
                return "B";
            }
            else if (data >= 70 && data < 80)
            {
                return "C";
            }
            else if (data >= 60 && data < 70)
            {
                return "D";
            }
            return "F";
        }

    }
}
