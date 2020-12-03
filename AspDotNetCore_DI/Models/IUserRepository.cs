using System.Collections.Generic;

namespace AspDotNetCore_DI.Models
{
    public interface IUserRepository
    {
        List<User> GetAllUsers();
    }
}
