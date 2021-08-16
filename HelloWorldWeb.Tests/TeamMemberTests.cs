using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorldWebApp.Models;
using HelloWorldWebApp.Services;
using Moq;
using Xunit;

namespace HelloWorldWeb.Tests
{
    public class TeamMemberTests
    {
        private readonly ITimeService timeService;
        private Mock<ITimeService> mock;

        private void InitializeMockService()
        {
            mock = new Mock<ITimeService>();

            mock.Setup(_ => _.GetCurrentDate()).Returns(new DateTime(2021, 8, 11));
        }

        [Fact]
        public void GettingAge()
        {
            //Assume
            InitializeMockService();
            var timeService = mock.Object;
            TeamMember newMember = new TeamMember("Leon", timeService);
            newMember.Birthdate = new DateTime(2000, 03, 17);

            //Act
            int age = newMember.GetAge();

            //Assert
            Assert.Equal(21, age);
            mock.Verify(_ => _.GetCurrentDate(), Times.Once());
        }
 
    }
    
}
