using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;

namespace Web_EF_Test.Models
{
    /*
        Enable-Migrations
        Add-Migration AddEName
        Update-Database
     */
    public class EfDbContext : DbContext
    {
        public DbSet<Brand> Brand { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Test> Test { get; set; }
    }
}