using OA.Data;
using OnionDemo.Controllers;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTestProject
{
    
    class CourseTest
    {

    
        [Fact]
        public void testCourse()
        {
            //Arrange
            var id = 2;
            var controller = new TestController();
            // act
            var okResult = controller.GetAllItem(id);
            // Assert
            Assert.IsType<Course>(okResult);
            Assert.Equal(id, (okResult as Course).Id);

            //var items = Assert.IsType<List<Course>>(okResult);
            //Assert.Equal(3, items.);

        }
    }
    
}
