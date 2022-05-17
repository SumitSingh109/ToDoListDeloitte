namespace ToDoListDeloitte.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using ToDoListDeloitte.Models;


    internal sealed class Configuration : DbMigrationsConfiguration<ToDoListDeloitte.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ToDoListDeloitte.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            AddUsers(context);
        }

        void AddUsers(ToDoListDeloitte.Models.ApplicationDbContext context)
        {
            var user = new ApplicationUser { UserName = "Admin1@deloitte.com" };
            var usermanager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            usermanager.Create(user, "password123");

        }

    }
}
