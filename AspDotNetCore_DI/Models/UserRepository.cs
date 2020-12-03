using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspDotNetCore_DI.Models
{
    public class UserRepository : IUserRepository
    {
        public List<User> GetAllUsers()
        {
            return new List<User>
            {
                new User()
                {
                    Name = "Diego",
                    LastName = "Maradona",
                    Birth = new DateTime(1960, 10, 30),
                    UserName = "El Pelusa"
                },
                new User()
                {
                    Name = "Luis",
                    LastName = "Dutra",
                    Birth = new DateTime(1992, 3, 28),
                    UserName = "Dutra"
                }
            };
        }
    }
}
