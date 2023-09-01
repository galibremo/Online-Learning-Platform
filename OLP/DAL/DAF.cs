using DAL.EF.Models;
using DAL.Interfaces;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAF
    {
        public static IRepo<Student, bool, int> AccessStudent()
        {
            return new StudentRepos();
        }
        public static IRepo<MyCourse, bool, int> AccessMyCourse()
        {
            return new MyCourseRepos();
        }
        public static IRepo<MySubmission, bool, int> AccessMySubmission()
        {
            return new MySubmissionRepos();
        }
        public static IRepo<MyAssignment, bool, int> AccessMyAssignment()
        {
            return new MyAssignmentRepos();
        }
        public static IRepo<TokenStudent, TokenStudent, int> AccessStudentToken()
        {
            return new TokenStudentRepos();
        }

        public static IRepo<User, bool, string> AccessUser()
        {
            return new UserRepos();
        }
        public static IAuthStudent AccessAuth()
        {
            return new UserRepos();
        }
        public static IRepo<WatchList, bool, int> AccessWatchList()
        {
            return new WatchListRepos();
        }
        public static IRepo<Contents, bool, int> AccessContents()
        {
            return new ContentRepos();
        }
        public static IRepo<Assignments,bool,int> AccessAssignments()
        {
            return new AssignmentRepos();
        }
        
        public static IRepo<Course, bool, int> AccessCourses()
        {
            return new CourseRepos();
        }
        public static IRepo<Enrollments, bool, int> AccessEnrollments()
        {
            return new EnrollmentRepos();
        }
        public static IRepo<Submission, bool, int> AccessSubmissions()
        {
            return new SubmissionRepos();
        }
        public static IRepo<Teacher, bool, int> AccessTeacher()
        {
            return new TeacherProfRepos();
        }
        public static IRepo<TokenTeacher, TokenTeacher, int> AccessTeacherToken()
        {
            return new TokenTeacherRepo();
        }
        public static ITeacherAuth AccessAuthenticateTeacher()
        {
            return new TeacherProfRepos();
        }
        public static ISubMarks SubmissionMark()
        {
            return new SubmissionRepos();
        }
        public static IRepo<WatchList, bool, int> AccessTeacherViews()
        {
            return new TeacherViewsRepo();
        }
        public static IRepo<Feedback, bool, int> AccessFeedback()
        {
            return new FeedbackRepos();
        }
        public static IRepo<Admin, bool, int> AccessAdmin()
        {
            return new AdminProfRepo();
        }
        public static IRepo<Token, Token, int> AccessAdminToken()
        {
            return new TokenAdminRepo();
        }
        public static IRepo<WatchList, bool, int> AccessAdminViews()
        {
            return new AdminViewsRepo();
        }
        public static IAdminAuth AccessAuthenticateAdmin()
        {
            return new AdminProfRepo();
        }
    }
}
