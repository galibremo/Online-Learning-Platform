using System;
﻿using Microsoft.SqlServer.Server;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace DAL.EF.Models
{
    public class Student
    {
        [Key]
        public int Student_Id { get; set; }
        [Required]
        [StringLength(15)]
        public string Student_Name { get; set; }
        [Required]
        [StringLength(15)]
        public string Email { get; set; }
        [Required]
        public DateTime DOB { get; set; }
        [Required]
        [StringLength(15)]
        public string Username { get; set; }
        [Required]
        [StringLength(20)]
        public string Password { get; set; }
        [Required]
        [DefaultValue(0)]
        public int NumOfActvCrs { get; set; }
        [Required]
        [StringLength(20)]
        public string UserType { get; set; }
        public virtual ICollection<MyCourse> MyCourses { get; set; }
        public virtual ICollection<Submission> submissions { get; set; }
        public virtual ICollection<Enrollments> enrollments { get; set; }
        public virtual ICollection<WatchList> WatchLists { get; set; }
        public Student()
        {
            MyCourses = new List<MyCourse>();
            submissions = new List<Submission>();
            enrollments = new List<Enrollments>();
            WatchLists = new List<WatchList>();
        }
    }
}