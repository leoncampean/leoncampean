using System;
using HelloWorldWebApp.Services;

namespace HelloWorldWebApp.Models
{
    public class TeamMember
    {
        private static int idCounter = 0;
        private readonly ITimeService timeService;
        public TeamMember(string name, ITeamService timeService)
        {
            Id = idCounter;
            idCounter++;
            Name = name;
            this.timeService = (ITimeService)timeService;
        }

        public TeamMember(string name, ITimeService timeService)
        {
            Name = name;
            this.timeService = timeService;
        }

        public int Id { get; set; }

        public string Name { get; set; }
        public DateTime Birthdate { get; set; }

        public int GetAge()
        {
            var age = timeService.GetCurrentDate().Subtract(Birthdate).Days;
            age = age / 365;

            return age;
        }
    }
}