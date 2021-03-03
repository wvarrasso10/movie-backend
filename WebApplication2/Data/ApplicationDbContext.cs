using DemoApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebApplication2.Data
{
    //class that defines how we talk to database
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        //need db set for model to turn into table and communicate
        //movie class is single entity or table
        public DbSet<Movie> Movies { get; set; }
    }
}
