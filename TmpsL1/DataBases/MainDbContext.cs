using System.Data.Entity;
using System.Linq;
using TmpsL1.Interface;
using TmpsL1.Models;

namespace TmpsL1.DataBases
{
    public class MainDbContext : DbContext, IRepository<User>
    {
        public MainDbContext(string connectionString) : base(connectionString)
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
