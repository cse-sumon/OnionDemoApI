using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using OA.Service;
using OA.Data;
using Microsoft.AspNetCore.Http;

namespace OnionDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly List<Course> course;

        public TestController()
        {
           course = new List<Course>()
            {
                new Course(){Id=1, CourseCode="CSE-101",CourseTitle="Programming C"},
                new Course(){Id=2, CourseCode="CSE-102",CourseTitle="Algorithm"},
                new Course(){Id=3, CourseCode="CSE-103",CourseTitle="Data Structure"}

            };

        }

        [HttpGet]
        public IEnumerable<Course> GetAllItems()
        {
            return course;
        }

        [HttpGet]
        public Course GetAllItem(int id)
        {
           return course.Where(c=>c.Id==id).FirstOrDefault();
        }

    }
}