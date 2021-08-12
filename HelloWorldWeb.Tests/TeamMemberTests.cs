using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorldWebApp.Models;
using HelloWorldWebApp.Services;
using Xunit;

namespace HelloWorldWeb.Tests
{
    public class TeamMemberTests
    {
        private readonly ITeamService timeService;

        [Fact]
        public void GettingAge()
        {
            //Asume
            TeamMember newMember = new TeamMember("Leon", timeService);
            newMember.Birthdate = new DateTime(2000, 03, 17);
            //Act
            int age = newMember.GetAge();
            //Assert
            Assert.Equal(21,age);
        }
    }
}
