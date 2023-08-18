using DAL.EF.Models;
using DAL.Interfaces;
using DAL.Repos;
using System;
using System.Collections.Generic;
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
        public static IRepo<Token,Token,int> AccessToken()
        {
            return new TokenRepos();
        }

        public static IRepo<User, bool, string> AccessUser()
        {   
            return new UserRepos();
        }
        public static IAuth AccessAuth() 
        {
            return new UserRepos();
        }
        public static IRepo<WatchList,bool,int> AccessWatchList()
        {
            return new WatchListRepos();
        }
        public static IRepo<Contents, bool, int> AccessContents()
        {
            return new ContentsRepos();
        }
    }
}
