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
    public class EnrollmentsService
    {
        public static int Coursestudentinfo(int id)
        {
            var data = DAF.AccessEnrollments().viewAll();
            var enrollments = (from i in data where i.cid == id select i.sid).ToList().Count();
            return enrollments;
        }
        public static int Courseteacherinfo(int id)
        {
            var data = DAF.AccessEnrollments().viewAll();
            var enrollments = (from i in data where i.cid == id select i.tid).ToList().Count();
            return enrollments;
        }


    }
}
