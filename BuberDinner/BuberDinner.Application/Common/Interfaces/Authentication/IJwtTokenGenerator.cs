namespace BuberDinner.Application.Common.Interfaces.Authentication
{
    public interface IJwtTokenGenerator
    {
        string Generatetoken(Guid userId, string firstName, string lastName);
    }
}
