using ReadCycle.Models;
using Microsoft.AspNetCore.Identity;

namespace ReadCycle.Data
{
    public class ApplicationDbInitializer
    {
        public static void Initialize(ApplicationDbContext db, UserManager<ApplicationUser> um, RoleManager<IdentityRole> rm)
        {
            // Delete the database before we initialize it. This is common to do during development.
            db.Database.EnsureDeleted();

            // Recreate the database and tables according to our models
            db.Database.EnsureCreated();
            
            // Add Admin as a role
            var adminRole = new IdentityRole("Admin");
            rm.CreateAsync(adminRole).Wait();

            // Add a new user and assign the admin role
            var admin = new ApplicationUser
                { Nickname = "admin", UserName = "admin", FirstName = "Admin", LastName = "uia", Location = "Grimstad", PhoneNumber = "12345678", Email = "admin@uia.no", EmailConfirmed = true };
            um.CreateAsync(admin, "Password1.").Wait();
            um.AddToRoleAsync(admin, "Admin").Wait();
            
            // Add a new user
            var user1 = new ApplicationUser 
                { Nickname = "user1", UserName = "user", FirstName = "User", LastName = "en", Location = "Grimstad", PhoneNumber = "87654321", Email = "user1@uia.no", EmailConfirmed = true };
            um.CreateAsync(user1, "Password1.").Wait();
            
            // Finally save the added relationships
            db.SaveChanges();
        }
    }
}