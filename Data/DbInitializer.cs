using System.Linq;
using UserApi.Models;
using BCrypt.Net;

namespace UserApi.Data
{
    public static class DbInitializer
    {
        public static void Initialize(AppDbContext context)
        {
            if (context.Users.Any()) return;

            var users = new User[]
            {
                new User { Name = "Admin", Email = "admin@email.com", PasswordHash = BCrypt.Net.BCrypt.HashPassword("Admin123"), Status = "Active" }
            };

            context.Users.AddRange(users);
            context.SaveChanges();
        }
    }
}
