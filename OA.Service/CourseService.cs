using System;
using System.Collections.Generic;
using System.Text;
using OA.Data;
using OA.Repository;

namespace OA.Service
{
   public class CourseService : ICourseService
    {
        private ICourseRepo<Course> courseRepository;

        public CourseService(ICourseRepo<Course> courseRepository)
        {
            this.courseRepository = courseRepository;
        }

        public IEnumerable<Course> GetCourses()
        {
            return courseRepository.GetAll();
        }

        public Course GetCourse(int id)
        {
            return courseRepository.Get(id);
        }

        public void InsertCourse(Course course)
        {
            courseRepository.Insert(course);
        }
        public void UpdateCourse(Course course)
        {
            courseRepository.Update(course);
        }

        public void DeleteCourse(int id)
        {
            Course course = GetCourse(id);
            courseRepository.Remove(course);
            courseRepository.SaveChanges();
        }

    }
}
