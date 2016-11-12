using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Cranz1.Models;

namespace Cranz1.Data
{
    public class EfUserRepository : IUserRepository
    {
        private EfContext Context;
        public EfUserRepository()
        {
            Context = new EfContext();

        }
        public IQueryable<User> Users
        {
            get
            {
                return Context.Users; //возвращаем коллекцию пользователей
                //БД = контекст, опасно, поэтому для каждой сущности делаем оболочку (репозиторий) над контекстом, где лежат нужные методы, кот. лежат в контроллерах (CreateUser, DelUser), нельзя напрямую трогать контекст!!
                //контекст - это неограниченный доступ к стеку. оболочка/посредник - репозиторий - возможность использовать только pop и push
            }
        }

        public bool CreateUser(User user)
        {
            Context.Users.Add(user);
            return Context.SaveChanges() == 1; // перезапишется коллекция сущностей, добавятся изменения - в БД сохранится новый пользователь
        }

        public User GetUserByID(int id)
        {
            return Context.Users.Find(id); //возвращаем пользователя по id - это primary key, ищем с помощью Find
        }
    }
}