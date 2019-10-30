using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OA.Data;
using OA.Repository;
using OA.Service;
using OnionDemo.Controllers;
using Stripe;
using System;
using System.Collections.Generic;
using Xunit;

namespace XUnitTestProject
{
    public class UnitTest1
    {
        //private IProductRepo<Course> productRepository;
        //private IProductService productService;

        //public UnitTest1(IProductRepo<Course> productRepository, IProductService product)
        //{
        //    this.productRepository = productRepository;
        //    productService = product;
        //}

        //public TestController _controller;
        //public CourseController _controller2;
        //public CourseService _service;
        //public CourseRepo<Course> _repo;
        //public ApplicationContext _context;
        //public UnitTest1(ApplicationContext context)
        //{
        //    _context = context;
        //    _repo = new CourseRepo<Course>(_context);
        //    _service = new CourseService(_repo);
        //    _controller = new TestController();
        //    _controller2 = new CourseController(_service);
        //}

        //[Fact]
        //public void TestGet()
        //{
        //   ApplicationContext context = new ApplicationContext();
        //    var course = new Course();
        //    var repo = new CourseRepo<Course>(context);
        //    var service = new CourseService(repo);
        //    var controller = new CourseController(service);
        //    var result = controller.Get(10);

        //    //Act
        //    int a = 20;

        //   // Assert
        //   var viewResult = Assert.IsType<int>(result);
        //    Assert.Equal(30, viewResult);
        //}
        [Fact]
        public void getCourses()
        {

            var controller = new TestController();
            // act
            var okResult = controller.GetAllItems();
            // Assert
            var items = Assert.IsType<List<Course>>(okResult);
            Assert.Equal(3, items.Count);

        }
        [Fact]
        public void GetById()
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
