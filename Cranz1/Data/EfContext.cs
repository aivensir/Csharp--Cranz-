using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Cranz1.Models;

namespace Cranz1.Data
{
    public class EfContext : DbContext //DbContext - от EntityFramework
    {
        public DbSet<User> Users { get; set; } //коллекция сущностей из БД
        //контексты исп. только в репозиториях, не трогая контексты, чтобы ничего не сломать, потому что контекст - прямой доступ к БД, а репозиторий как посредник между БД и контроллерами

    }
}