using app.persistence;
using app.web.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace app.unitTests
{
    class NewsTess
    {
        [Fact]
        public async Task Test_News_Index_Returns_A_ViewResult()
        {
            // Arrange
            var mockRepo = new MockNewsRepository();
            var controller = new NewsController(mockRepo);

            // Act
            var result = await controller.Index();

            // Assert
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public async Task Test_News_Index_Model_Is_An_Enumerable_Model_of_News()
        {
            // Arrange
            var mockRepo = new MockNewsRepository();
            var controller = new NewsController(mockRepo);

            //Act
            var result = await controller.Index() as ViewResult;
            var model = result.ViewData.Model;

            //Assert
            Assert.IsAssignableFrom<IEnumerable<domain.News>>(model);
        }

        [Fact]
        public async Task Test_Index_Model_Contains_News()
        {
            // Arrange
            var mockRepo = new MockNewsRepository();
            var controller = new NewsController(mockRepo);

            //Act
            var result = await controller.Index() as ViewResult;
            var model = result.ViewData.Model;
            var list = model as IEnumerable<domain.News>;

            //Assert
            Assert.Equal(3, list.Count());
        }
    }
}
