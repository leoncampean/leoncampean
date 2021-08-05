namespace HelloWorldWeb.Tests
{
    internal interface ITeamService
    {
        void AddTeamMember(string v);
        object GetTeamInfo();
        void RemoveMember(int v);
    }
}