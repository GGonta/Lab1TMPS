using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TmpsL1.Models;

namespace TmpsL1.Interface
{
    public interface IUserService
    {
        void AddUser(User user);
        User GetUserById(int id);
        void SaveUsers();
    }
}
