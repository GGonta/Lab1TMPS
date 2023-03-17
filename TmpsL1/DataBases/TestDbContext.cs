using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TmpsL1.Interface;
using TmpsL1.Models;

namespace TmpsL1.DataBases
{
    class TestDbContext : DbContext, IRepository<User>
    {
        public TestDbContext(string connectionString) : base(connectionString)
        {

        }

        public DbSet<User> Users { get; set; }

        public User GetById(int id)
        {
            return Users.FirstOrDefault(p => p.Id == id);
        }

        public void Add(User entity)
        {
            Users.Add(entity);
        }

        public void Save()
        {
            base.SaveChanges();
        }
    }
}
