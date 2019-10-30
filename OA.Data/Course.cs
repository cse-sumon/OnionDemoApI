using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OA.Data
{
   public class Course
    {
        public int Id { get; set; }
        public string CourseCode { get; set; }
        public string CourseTitle { get; set; }
    }
}
