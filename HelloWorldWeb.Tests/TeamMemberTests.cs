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
        [Fact]
        public void GettingAge()
        {
            //Asume
            var newTeamMember = new TeamMember(12,"Leon");
            newTeamMember.Birthdate = new DateTime(2000, 03, 17);
            //Act
            int age = newTeamMember.GetAge();
            //Assert
            Assert.Equal(21,age);
        }
    }
}
