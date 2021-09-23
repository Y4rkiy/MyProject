using System.Linq;
using MyProject.Data;
using MyProject.Models;

namespace MyProject
{
    public static class SampleData
    {
        public static void Initialize(ApplicationDbContext context)
        {
            if (!context.IdentityUsers.Any())
            {
                context.IdentityUsers.AddRange(
                    new User
                    {
                        Name = "Jack",
                        Email = "yy@gm.com"
                    },
                    new User
                    {
                        Name = "Michael",
                        Email = "yy@gm.com"
                    },
                    new User
                    {
                        Name = "Jon",
                        Email = "gg@gm.com"
                    }
                ) ;
                context.SaveChanges();
            }
        }
    }
}