using PharmaEntities;

namespace PharmaRepositories
{
    public interface IUserRepository
    {
        User GetUserByLogin(string login, string password);
    }
}
