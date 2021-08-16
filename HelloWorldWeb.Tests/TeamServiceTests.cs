
using System;
using HelloWorldWebApp.Services;
using Xunit;

namespace HelloWorldWebApp.Tests
{
    public class TeamServiceTests
    {
        [Fact]
        public void AddTeamMemberToTheTeam()
        {
            //Assume
            ITeamService teamService = new TeamService();

            //Act
            int initialCount = teamService.GetTeamInfo().TeamMembers.Count;
            teamService.AddTeamMember("George");

            //Assert
            Assert.Equal(initialCount + 1, teamService.GetTeamInfo().TeamMembers.Count);
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
            var targetTeamMember = teamService.GetTeamInfo().TeamMembers[0];
            var memberId = targetTeamMember.Id;
            // Act
            teamService.UpdateMemberName(memberId, "UnitTest");

            // Assert
            Assert.Equal("UnitTest", teamService.GetMemberById(memberId).Name);
        }

        [Fact]
        public void checkIdProblem()
        {
            // Assume
            ITeamService teamService = new TeamService();
            var id = teamService.GetTeamInfo().TeamMembers[0].Id;

            // Act
            teamService.RemoveMember(id);
            int memberId = teamService.AddTeamMember("Test");
            teamService.RemoveMember(memberId);

            // Assert
            int lastIndex = teamService.GetTeamInfo().TeamMembers.Count;
            Assert.NotEqual("Test", teamService.GetTeamInfo().TeamMembers[lastIndex - 1].Name);
        }

    }
}