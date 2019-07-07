using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MentorIT.Models
{
    public class AppDbInitializer : CreateDatabaseIfNotExists<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            var userManager = new ApplicationUserManager(new UserStore<ApplicationUser>(context));

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));

            // Add Roles
            var role1 = new IdentityRole { Name = "admin" }; // Admin
            var role2 = new IdentityRole { Name = "mentor" }; // Mentor
            var role3 = new IdentityRole { Name = "student" }; // Student


            // Add Roles to BD
            roleManager.Create(role1);
            roleManager.Create(role2);
            roleManager.Create(role3);


            // Add new users
            var admin = new ApplicationUser { Email = "admin@mentorit.com", Name = "Admin", };
            string password = "Admin!123";
            var result = userManager.Create(admin, password);


            // If adding was success
            if (result.Succeeded)
            {


                // Add User Role
                userManager.AddToRole(admin.Id, role1.Name);


            }
            base.Seed(context);
        }
    }
}