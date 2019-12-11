using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using app.domain;
using app.persistence;
using app.web;
using Xunit;
using app.domain.Models;

namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public async Task Test_CapsulesInformation_Index_Returns_A_ViewResult()
        {
            // Arrange
            var mockRepo = new MockCapsulesInformationRepository();
            var controller = new app.web.Controllers.CapsulesInformationsController(mockRepo);

            // Act
            var result = await controller.Index();

            // Assert
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public async Task Test_CapsulesInformation_Index_Model_Is_An_Enumerable_Model_of_CapsulesInformation()
        {
            // Arrange
            var mockRepo = new MockCapsulesInformationRepository();
            var controller = new app.web.Controllers.CapsulesInformationsController(mockRepo);

            //Act
            var result = await controller.Index() as ViewResult;
            var model = result.ViewData.Model;

            //Assert
            Assert.IsAssignableFrom<IEnumerable<CapsulesInformation>>(model);
        }

        [Fact]
        public async Task Test_CapsulesInformation_Model_Contains_CapsulesInformation()
        {
            // Arrange
            var mockRepo = new MockCapsulesInformationRepository();
            var controller = new app.web.Controllers.CapsulesInformationsController(mockRepo);

            //Act
            var result = await controller.Index() as ViewResult;
            var model = result.ViewData.Model;
            var list = model as IEnumerable<CapsulesInformation>;

            //Assert
            Assert.Equal(4, list.Count());
        }
    }
}
