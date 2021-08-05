namespace HelloWorldWebApp.Models
{
    public class TeamMember
    {
        public TeamMember(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }

        public string Name { get; set; }
    }
}