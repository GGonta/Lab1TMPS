using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TmpsL1.DataBases;
using TmpsL1.Interface;
using TmpsL1.Models;
using TmpsL1.Service;

// SOLID Principles:

// Single Responsibility Principle (SRP) - Each class should have only one responsibility.
// Open/Closed Principle (OCP) - Classes should be open for extension, but closed for modification.
// Liskov Substitution Principle (LSP) - Subtypes should be substitutable for their base types.
// Interface Segregation Principle (ISP) - Clients should not be forced to depend on interfaces they don't use.
// Dependency Inversion Principle (DIP) - High-level modules should not depend on low-level modules. Both should depend on abstractions.

namespace TmpsL1
{
    class Program
    {
        static void Main(string[] args)
        {
            string db = "main";

            if (db == "main")
            {
                using (var dbContext = new MainDbContext("DbConnectionStringMain"))
                {
                    User user = new User
                    {
                        Id = 3322,
                        Name = "Ion",
                        Password = "qwqwqw"
                    };
                    UserService userService = new UserService(dbContext);
                    userService.AddUser(user);
                    userService.SaveUsers();
                    var result = userService.GetUserById(3322);
                    Console.WriteLine($"{result.Id} \n {result.Name} \n {result.Password}");
                }
            } 
            else
            {
                using (var dbContext = new TestDbContext("DbConnectionStringTest"))
                {
                    User user = new User
                    {
                        Id = 10,
                        Name = "Ion",
                        Password = "qwqwqw"
                    };
                    UserService userService = new UserService(dbContext);
                    userService.AddUser(user);
                    var result = userService.GetUserById(6);
                    Console.WriteLine($"{result.Id} \n {result.Name} \n {result.Password}");
                }
            }
        }
    }
}
