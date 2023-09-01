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
    public class TeacherController : ApiController
    {
        [TeacherLogged]
        [HttpGet]
        [Route("api/get/teacher/{id}")]
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
        [Route("api/get/teacher/update")]
        public HttpResponseMessage UpdateTeacher(TeacherDTO t)
        {
            try
            {
                var data = TeacherService.UpdateTeacher(t);
                if (data)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, new { msg = "profile updated" });
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, new { msg = "No profile found" });
                }

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
                if (data)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, new { msg = "profile Deleted" });
                }

                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, new { msg = "No profile found" });
                }
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
                if (data)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, new { msg = "Profile created" });
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, new { msg = "Can not create profile" });
                }
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
      
        [HttpGet]
        [Route("api/get/course/teacher/{id}")]
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
        [Route("api/get/course/{id}")]
        public HttpResponseMessage GetCourse(int id)
        {
            try
            {
                var data = CourseService.GetCourses(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
        [HttpGet]
        [Route("api/get/course/update")]
        public HttpResponseMessage UpdateCourses(CourseDTO c)
        {
            try
            {
                var data = CourseService.UpdateCourses(c);
                if (data)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, new { msg = "Course updated" });
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, new { msg = "No course found" });
                }

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
                if (data)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, new { msg = "Course deleted" });
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, new { msg = "No course found" });
                }
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
        [IsTeacher]
        [HttpGet]
        [Route("api/get/course/create")]
        public HttpResponseMessage CreateCourse(CourseDTO c)
        {
            try
            {
                var data = CourseService.CreateCourse(c);
                if (data)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, new { msg = "Course created" });

                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, new { msg = "unable to create" });
                }
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
        [HttpGet]
        [Route("api/get/content/course/{id}")]
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
        [Route("api/get/Content/{id}")]
        public HttpResponseMessage GetContent(int id)
        {
            try
            {
                var data = ContentService.GetContent(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
        [HttpGet]
        [Route("api/get/content/update")]
        public HttpResponseMessage UpdateContent(ContentsDTO c)
        {
            try
            {
                var data = ContentService.UpdateContent(c);
                if (data)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, new { msg = "Content updated" });

                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, new { msg = "no content found" });
                }
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
                if (data)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, new { msg = "Content deleted" });

                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, new { msg = "no content found" });
                }
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
        [HttpGet]
        [Route("api/course/contents/create")]
        public HttpResponseMessage CreateContent(ContentsDTO c)
        {
            try
            {
                var data = ContentService.CreateContent(c);
                if (data)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, new { msg = "Content created" });
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NoContent, new { msg = "Course id invalid" });
                }

            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
        [HttpGet]
        [Route("api/teacher/course/assignments/{cid}/{tid}")]
        public HttpResponseMessage GetAllAssignments(int cid, int tid)
        {
            try
            {
                var data = AssignmentService.GetAllAssignments(cid, tid);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
        [HttpGet]
        [Route("api/course/assignments/{id}")]
        public HttpResponseMessage GetAssignments(int id)
        {
            try
            {
                var data = AssignmentService.GetAssignments(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
        [HttpGet]
        [Route("api/get/course/assignment/update")]
        public HttpResponseMessage UpdateAssignments(AssignmentsDTO a)
        {
            try
            {
                var data = AssignmentService.UpdateAssignments(a);
                if (data)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, new { msg = "Assignment updated" });

                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NoContent, new { msg = "No assignment found" });
                }
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
        [HttpGet]
        [Route("api/get/course/assignment/delete/{id}")]
        public HttpResponseMessage DeleteAssignments(int id)
        {
            try
            {
                var data = AssignmentService.DeleteAssignments(id);
                if (data)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, new { msg = "Assignment status changed" });

                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, new { msg = "Invalid operation" });
                }
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
        [TeacherLogged]
        [HttpGet]
        [Route("api/course/Assignment/create")]
        public HttpResponseMessage CreateAssignment(AssignmentsDTO a)
        {
            try
            {
                var data = AssignmentService.CreateAssignments(a);
                if (data)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, new { msg = "Assignment created" });

                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NoContent, new { msg = "Unable to create assignment" });
                }

            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
        [HttpGet]
        [Route("api/teacher/course/assignments/submissions/{id}")]
        public HttpResponseMessage GetSubmissionsByAid(int id)
        {
            try
            {
                var data = TeacherSubmissionService.GetSubmissionsByAid(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
        [HttpGet]
        [Route("api/course/assignments/submissions/{id}")]
        public HttpResponseMessage GetSubmission(int id)
        {
            try
            {
                var data = TeacherSubmissionService.GetSubmission(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
        [HttpGet]
        [Route("api/course/assignments/submissions/feedback/{id}")]
        public HttpResponseMessage FeedbackSubmission(int id, FeedbackModel f)
        {
            try
            {
                var data = TeacherSubmissionService.GetSubmission(id);
                if (data != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, f.feedback);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.OK, new { msg = "submission not found" });
                }
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
        [HttpGet]
        [Route("api/course/assignments/submissions/mark/{id}/{mark}")]
        public HttpResponseMessage SubmissionMark(int id, int mark)
        {
            try
            {
                var data = TeacherSubmissionService.AddSubmissionMark(id, mark);
                return data ? Request.CreateResponse(HttpStatusCode.OK, new { msg = "Marks added" }) : Request.CreateResponse(HttpStatusCode.OK, new { msg = "Invalid request" });

            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
        [HttpGet]
        [Route("api/get/course/assignment/submission/delete/{id}")]
        public HttpResponseMessage DeleteSubmission(int id)
        {
            try
            {
                var data = TeacherSubmissionService.DeleteSubmission(id);
                if (data)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, new { msg = "Submission deleted" });

                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NoContent, new { msg = "No submission found" });
                }
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
        [HttpGet]
        [Route("api/teacher/course/enrollments/{cid}/{tid}")]
        public HttpResponseMessage GetEnrollmentsByCid(int cid, int tid)
        {
            try
            {
                var data = TeacherEnrollmentService.GetEnrollmentByCid(cid, tid);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
        [HttpGet]
        [Route("api/course/enrollments/{id}")]
        public HttpResponseMessage GetEnrollment(int id)
        {
            try
            {
                var data = TeacherEnrollmentService.GetEnrollment(id);
                return data != null ? Request.CreateResponse(HttpStatusCode.OK, data) : Request.CreateResponse(HttpStatusCode.NotFound, new { msg = "Enrollment not found" });
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
        [HttpGet]
        [Route("api/get/course/enrollment/delete/{id}")]
        public HttpResponseMessage DeleteEnrollment(int id)
        {
            try
            {
                var data = TeacherEnrollmentService.DeleteEnrollment(id);
                if (data)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, new { msg = "enrollment deleted" });

                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NoContent, new { msg = "No enrollment found" });
                }
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
        [HttpGet]
        [Route("api/get/content/views/{id}")]
        public HttpResponseMessage GetContentViews(int id)
        {
            try
            {
                var data = ContentService.ContentViews(id);
                if (data != 0)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "Total views : " + data);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NoContent, new { msg = "Invalid Request" });
                }
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
        [HttpGet]
        [Route("api/get/course/views/{id}")]
        public HttpResponseMessage GetCourseViews(int id)
        {
            try
            {
                var data = CourseService.CourseViews(id);
                return data != 0 ? Request.CreateResponse(HttpStatusCode.OK, "Total views : " + data) : Request.CreateResponse(HttpStatusCode.NoContent, new { msg = "Invalid Request" });

            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
        [HttpGet]
        [Route("api/get/submission/views/{aid}")]
        public HttpResponseMessage GetSubmissionViews(int aid)
        {
            try
            {
                var data = TeacherSubmissionService.GetSubmissionViews(aid);
                return data != 0 ? Request.CreateResponse(HttpStatusCode.OK, "Total views : " + data) : Request.CreateResponse(HttpStatusCode.NoContent, new { msg = "Invalid Request" });

            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
        [HttpGet]
        [Route("api/get/course/feedbacks/{cid}")]
        public HttpResponseMessage GetFeedbacks(int cid)
        {
            try
            {
                var data = FeedbackServices.GetFeedbacks(cid);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpGet]
        [Route("api/update/course/feedback")]
        public HttpResponseMessage UpdateFeedback(FeedbackDTO f)
        {
            try
            {
                var data = FeedbackServices.UpdateFeedback(f);
                if (data)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, new { msg = "message edited" });
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, new { msg = "invalid request" });
                }

            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
        [HttpGet]
        [Route("api/delete/course/feedback/{id}")]
        public HttpResponseMessage DeleteFeedback(int id)
        {
            try
            {
                var data = FeedbackServices.DeleteFeedback(id);
                if (data)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, new { msg = "feedback Deleted" });
                }

                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, new { msg = "invalid request" });
                }
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
        [HttpGet]
        [Route("api/create/course/feedback")]
        public HttpResponseMessage CreateFeedback(FeedbackDTO f)
        {
            try
            {
                var data = FeedbackServices.CreateFeedback(f);
                if (data)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, new { msg = "Thanks for the feedback" });
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, new { msg = "Can not write feedback" });
                }
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
        [HttpGet]
        [Route("api/get/course/student/progress/{cid}/{sid}")]
        public HttpResponseMessage GetStudentProgress(int cid, int sid)
        {
            try
            {
                var data = CourseService.GetStudentProgress(cid, sid);
                if (data != 0)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "Student Progress(%): " + data);
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
        [Route("api/get/course/totalstudent/{cid}")]
        public HttpResponseMessage TotalCourseStudent(int cid)
        {
            try
            {
                var data = TeacherEnrollmentService.TotalCourseStudent(cid);
                if (data != 0)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, data);
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
        [Route("api/get/assignment/student/grade/{aid}/{sid}")]
        public HttpResponseMessage GetStudentGrade(int aid, int sid)
        {
            try
            {
                var data = TeacherSubmissionService.PutStudentGrade(aid, sid);
                if (data != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "Grade : " + data);
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
        [Route("api/get/teacher/student/performance/{tid}/{sid}")]
        public HttpResponseMessage AnalyzeStudent(int tid, int sid)
        {
            try
            {
                var data = TeacherEnrollmentService.AnalyzeStudent(tid, sid);
                if (data != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, data);
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
    }
}
