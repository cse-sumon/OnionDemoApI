using OA.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Service
{
    public interface ICourseService
    {
        IEnumerable<Course> GetCourses();
        Course GetCourse(int id);
        void InsertCourse(Course course);
        void UpdateCourse(Course course);
        void DeleteCourse(int id);
    }
}
