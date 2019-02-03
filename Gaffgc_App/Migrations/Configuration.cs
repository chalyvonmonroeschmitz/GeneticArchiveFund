namespace Gaffgc_App.Migrations
{
    using Microsoft.AspNet.Identity;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Gaffgc_App.Models;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System.Threading.Tasks;

    internal sealed class Configuration : DbMigrationsConfiguration<Gaffgc_App.Models.GaffgcDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Gaffgc_App.Models.GaffgcDBContext context)
        {
            //Step 1 Create the user.
            Gaffgc_App.Models.User user = new User()
            {
                UserName = "code.monkey@hotmail.com",
                Email = "code.monkey@hotmail.com",
                Name = "Charly",
                Surname = "Sen",
                Country = "Australia",
                Birthday = 10101980,
                PasswordHash = new PasswordHasher().HashPassword("Testing@123")
            };
            user.SecurityStamp = Guid.NewGuid().ToString();

            //Step 2 Create and add the new Role.
            var testerRole = new IdentityRole("Testers");
            context.Roles.Add(testerRole);

            //Step 3 Create a role for a user
            var role = new IdentityUserRole();
            role.RoleId = testerRole.Id;
            role.UserId = user.Id;

            //Step 4 Add the role row and add the user to DB)
            user.Roles.Add(role);
            context.Users.Add(user);
            context.SaveChanges();

            user = new User()
            {
                UserName = "demo@email.com",
                Email = "demo@email.com",
                Name = "Demo",
                Surname = "Account",
                Country = "Australia",
                Birthday = 11111979,
                PasswordHash = new PasswordHasher().HashPassword("Demo@123")
            };
            user.SecurityStamp = Guid.NewGuid().ToString();

            //Step 3 Create a role for a user
            var role2 = new IdentityUserRole();
            role2.RoleId = testerRole.Id;
            role2.UserId = user.Id;

            //Step 4 Add the role row and add the user to DB)
            user.Roles.Add(role2);
            context.Users.Add(user);

            context.SaveChanges();
        }
    }
}
