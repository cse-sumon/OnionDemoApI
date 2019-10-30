using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OA.Data;
using OA.Service;
using OnionDemo.Models;

namespace OnionDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService courseService;

        public CourseController(ICourseService courseService)
        {
            this.courseService = courseService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            List<CourseViewModel> model = new List<CourseViewModel>();
            courseService.GetCourses().ToList().ForEach(u =>
            {
                CourseViewModel course = new CourseViewModel
                {
                    Id = u.Id,
                    CourseCode = u.CourseCode,
                    CourseTitle = u.CourseTitle,
                };
                model.Add(course);
            });

            return Ok(model);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            List<CourseViewModel> model = new List<CourseViewModel>();
            var result = courseService.GetCourse(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpPost]
        public ActionResult Post(CourseViewModel model)
        {
            Course courseEntity = new Course
            {
                CourseCode = model.CourseCode,
                CourseTitle = model.CourseTitle,
            };
            courseService.InsertCourse(courseEntity);
            return Ok();
        }

        [HttpPut]
        public ActionResult Put(CourseViewModel model)
        {
            Course courseEntity = courseService.GetCourse(model.Id);
            courseEntity.CourseCode = model.CourseCode;
            courseEntity.CourseTitle = model.CourseTitle;

            courseService.UpdateCourse(courseEntity);
            if (courseEntity.Id > 0)
            {
                return Ok();
            }
            return BadRequest(model);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            courseService.DeleteCourse(id);
            return Ok();
        }
    }
}