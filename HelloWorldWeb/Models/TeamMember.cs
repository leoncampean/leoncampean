using System;

namespace HelloWorldWebApp.Models
{
    public class TeamMember
    {
        private static int idCounter = 0;
        public TeamMember(string name)
        {
            Id = idCounter;
            idCounter++;
            Name = name;
        }

        public int Id { get; set; }

        public string Name { get; set; }
        public DateTime Birthdate { get; set; }

        public int GetAge()
        {
            var age = DateTime.Now.Subtract(Birthdate).Days;
            age = age / 365;

            return age;
        }
    }
}