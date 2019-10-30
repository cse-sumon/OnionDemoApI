using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnionDemo.Models
{
    public class CourseViewModel
    {
        public int Id { get; set; }
        [Required]
        public string CourseCode { get; set; }
        [Required]
        public string CourseTitle { get; set; }
    }
}
