using System.Collections.Generic;
using Mvvm.Domain;

namespace Mvvm.DataAccess
{
    public class UserRepository : IUserRepository
    {
        public IEnumerable<User> FindAll()
        {
            return new List<User>
            {
                new User() { Username = "mark", Password = "neri"}
            };
        }
    }
}
