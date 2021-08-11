
using System;
using HelloWorldWebApp.Services;
using Xunit;

namespace HelloWorldWebApp.Tests
{
    public class TeamServiceTest
    {
        [Fact]
        public void AddTeamMemberToTheTeam()
        {
            //Assume
            ITeamService teamService = new TeamService();

            //Act
            teamService.AddTeamMember("George");

            //Assert
            Assert.Equal(7, teamService.GetTeamInfo().TeamMembers.Count);
        }

        [Fact]
        public void RemoveMemberFromTheTeam()
        {
            // Assume
            ITeamService teamService = new TeamService();

            // Act
            int initialCount = teamService.GetTeamInfo().TeamMembers.Count;
            var id = teamService.GetTeamInfo().TeamMembers[0].Id;
            teamService.RemoveMember(id);

            // Assert
            Assert.Equal(initialCount - 1, teamService.GetTeamInfo().TeamMembers.Count);
        }

        [Fact]
        public void UpdateMemberName()
        {
            // Assume
            ITeamService teamService = new TeamService();

            // Act
            teamService.UpdateMemberName(1, "UnitTest");

            // Assert
            var member = teamService.GetMemberById(1);
            Assert.Equal("UnitTest", member.Name);
        }
        
        [Fact]
        public void checkIdProblem()
        {
            //Asume
            ITeamService teamService = new TeamService();
            //Act
            var memeberToBeDeleted = teamService.GetTeamInfo().TeamMembers[teamService.GetTeamInfo().TeamMembers.Count-2];
            var newName = "Borys";
            teamService.RemoveMember(memeberToBeDeleted.Id);
            var id = teamService.AddTeamMember(newName);
            teamService.RemoveMember(id);
            //Assert
            var member = teamService.GetTeamInfo().TeamMembers.Find(element => element.Name == newName);
            Assert.Null(member);
        }
    }
}