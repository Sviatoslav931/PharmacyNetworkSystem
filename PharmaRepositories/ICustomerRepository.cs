using PharmaEntities;

namespace PharmaRepositories
{
    public interface ICustomerRepository
    {
        Customer GetCustomerByCard(int card);
    }
}
