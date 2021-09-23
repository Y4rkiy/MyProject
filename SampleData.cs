using System.Linq;
using MyProject.Data;
using MyProject.Models;

namespace MyProject
{
    public static class SampleData
    {
        public static void Initialize(ApplicationDbContext context)
        {
            if (!context.Users.Any())
            {
                context.Users.AddRange(
                    new AspNetUsers
                    {
                        Name = "Jack",
                        Email = "yy@gm.com"
                    },
                    new AspNetUsers
                    {
                        Name = "Michael",
                        Email = "yy@gm.com"
                    },
                    new AspNetUsers
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