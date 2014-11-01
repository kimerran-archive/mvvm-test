using System.Collections.Generic;
using Mvvm.Domain;

namespace Mvvm.DataAccess
{
    public interface IUserRepository
    {
        IEnumerable<User> FindAll();
    }
}
