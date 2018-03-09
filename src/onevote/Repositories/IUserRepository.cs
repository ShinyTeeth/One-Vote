using onevote.Models;

namespace onevote.Repositories
{
    public interface IUserRepository
    {
        User GetByID(int id);
    }
}