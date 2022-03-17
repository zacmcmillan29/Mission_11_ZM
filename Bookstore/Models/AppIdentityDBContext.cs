using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Bookstore.Models
{
    //setting up our class to inherit from a class that will allow login stuff!
    public class AppIdentityDBContext : IdentityDbContext<IdentityUser>
    {
        //constructor = options for this context file!
        public AppIdentityDBContext(DbContextOptions options) : base(options)
        {
        }
    }
}
