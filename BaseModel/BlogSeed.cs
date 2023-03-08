using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseModel
{
    public static class BlogSeed
    {
        public static void SeedingData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User()
                {
                    Id = 1,
                    Name = "Test",
                }
                ) ;
            modelBuilder.Entity<Blog>().HasData(
                new Blog()
                {
                    Id = 1,
                    Name = "Blog 1",
                    Description = "Blalalalala",
                    UserId = 1,
                },
                new Blog()
                {
                    Id = 2,
                    Name = "Blog 2",
                    Description = "Blalalalala",
                    UserId = 1,
                }
                );
        }
    }
}
