using BLL.DTOs;
using BLL.Services;
using OLP.AuthFilters;
using OLP.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Configuration;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace OLP.Controllers

{
    [EnableCors("*", "*", "*")]
    public class AdminController : ApiController

    {
        [AdminLogged]
        [HttpGet]
        [Route("api/get/admin/update")]
        public HttpResponseMessage UpdateAdmin(AdminDTO a)
        {
            try
            {
                var data = AdminService.UpdateAdmin(a);
                return Request.CreateResponse(HttpStatusCode.OK, new { msg = "profile updated" });
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }


        [HttpGet]
        [Route("api/get/teacher/all")]

        public HttpResponseMessage GetTeacher(int id)
        {
            try
            {
                var data = TeacherService.GetTeacher(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpGet]
        [Route("api/get/student/all")]
        public HttpResponseMessage GetStudent(int id)
        {
            try
            {
                var data = StudentServices.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }



        [HttpGet]
        [Route("api/get/teacher/update")]
        public HttpResponseMessage UpdateTeacher(TeacherDTO t)
        {
            try
            {
                var data = TeacherService.UpdateTeacher(t);
                return Request.CreateResponse(HttpStatusCode.OK, new { msg = "profile updated" });
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpGet]
        [Route("api/get/student/update")]
        public HttpResponseMessage UpdateStudent(StudentDTO t)
        {
            try
            {
                var data = StudentServices.Update(t);
                return Request.CreateResponse(HttpStatusCode.OK, new { msg = "profile updated" });
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpGet]
        [Route("api/get/teacher/delete/{id}")]
        public HttpResponseMessage DeleteTeacher(int id)
        {
            try
            {
                var data = TeacherService.DeleteTeacher(id);
                return Request.CreateResponse(HttpStatusCode.OK, new { msg = "profile Deleted" });
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpGet]
        [Route("api/get/student/delete/{id}")]
        public HttpResponseMessage DeleteStudent(int id)
        {
            try
            {
                var data = StudentServices.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, new { msg = "profile Deleted" });
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }


        [HttpGet]
        [Route("api/get/teacher/create")]
        public HttpResponseMessage CreateTeacher(TeacherDTO t)
        {
            try
            {
                var data = TeacherService.CreateTeacher(t);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpGet]
        [Route("api/get/student/create")]
        public HttpResponseMessage CreateStudent(StudentDTO t)
        {
            try
            {
                var data = StudentServices.Create(t);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }



        [HttpGet]
        [Route("api/get/course/all")]

        public HttpResponseMessage GetAllCourses(int id)

        {

            try

            {

                var data = CourseService.GetAllCourses(id);

                return Request.CreateResponse(HttpStatusCode.OK, data);

            }

            catch (Exception e)

            {

                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);

            }

        }



        [HttpGet]

        [Route("api/get/course/delete/{id}")]

        public HttpResponseMessage DeleteCourse(int id)

        {

            try

            {

                var data = CourseService.DeleteCourse(id);

                return Request.CreateResponse(HttpStatusCode.OK, new { msg = "Course deleted" });

            }

            catch (Exception e)

            {

                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);

            }

        }



        [HttpGet]

        [Route("api/get/content/all")]

        public HttpResponseMessage GetAllContents(int id)

        {
            try
            {
                var data = ContentService.GetAllContents(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }


        [HttpGet]
        [Route("api/get/content/delete/{id}")]

        public HttpResponseMessage DeleteContent(int id)

        {
            try

            {

                var data = ContentService.DeleteContent(id);

                return Request.CreateResponse(HttpStatusCode.OK, new { msg = "Content deleted" });

            }

            catch (Exception e)

            {

                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);

            }

        }

        [HttpGet]
        [Route("api/courseinfo/{id}/students")]

        public HttpResponseMessage Getstudentinfo(int id)
        {
            try
            {
                var data = EnrollmentsService.Coursestudentinfo(id);
                if (data != 0)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "Students: " + data);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, new { msg = "Invalid Request" });
                }
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
        [HttpGet]
        [Route("api/courseinfo/{id}/teachers")]
        public HttpResponseMessage Getteacherinfo(int id)
        {
            try
            {
                var data = EnrollmentsService.Courseteacherinfo(id);
                if (data != 0)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "Teachers: " + data);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, new { msg = "Invalid Request" });
                }
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
        [HttpGet]
        [Route("api/Studentscourse/{id}")]
        public HttpResponseMessage GetWithCat(int id)
        {
            try
            {
                var data = StudentServices.GetWithStnt(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpGet]
        [Route("api/studentevalution/{cid}/{sid}")]
        public HttpResponseMessage GetStudentProgress(int cid, int sid)
        {
            try
            {
                var data = CourseService.GetStudentProgress(cid, sid);
                if (data != 0)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "Student Evalution(%): " + data);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, new { msg = "Invalid Request" });
                }
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
        /*[HttpGet]
        [Route("api/teachercourses/{id}")]
        public HttpResponseMessage Getwithteacher(int id)
        {
            try
            {
                var data = CourseService.GetWithteacher(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }*/
    }
}
