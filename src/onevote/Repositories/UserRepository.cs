using System;
using onevote.Models;

namespace onevote.Repositories
{
    public class UserRepository : IUserRepository
    {
        public User GetByID(int id)
        {
            return new User()
            {
                ID = 0,
                FirstName = "John",
                LastName = "Doe",
                BirthDate = DateTime.Now
            };
        }
    }
}