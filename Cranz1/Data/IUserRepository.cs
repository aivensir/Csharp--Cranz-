using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cranz1.Models;

namespace Cranz1.Data
{
    interface IUserRepository
    {
        IQueryable<User> Users { get; } //коллекция Users, только получаем
        bool CreateUser(User user);
        User GetUserByID(int id);
    }
}
