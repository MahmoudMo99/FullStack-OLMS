﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OnlineLearningManagementSystemProject.Models
{
    public class StudentCourse
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public int StudentID { get; set; }
        [ForeignKey("StudentID")]
        public Student Student { get; set; }
        public int CourseID { get; set; }
        [ForeignKey("CourseID")]
        public Course Course { get; set; }
    }
}
