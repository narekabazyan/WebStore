namespace WebStoreServer.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebStoreServer.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WebStoreServer.Models.WebStoreServerContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebStoreServer.Models.WebStoreServerContext context)
        {
            context.Users.AddOrUpdate(x => x.Id,
                new User() { Id = 1, Email = "test@test.test", Password="testpass" }
            );

            context.UserDetails.AddOrUpdate(x => x.Id,
                new UserDetails()
                {
                    Id = 1,
                    Username = "test",
                    FirstName = "test",
                    LastName = "test",
                    UserId = 1,
                }
            );
        }
    }
}
