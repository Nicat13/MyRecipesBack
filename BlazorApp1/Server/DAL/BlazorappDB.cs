using BlazorApp1.Shared;
using BlazorApp1.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Server.DAL
{
    public class BlazorappDB:DbContext
    {
        public BlazorappDB(DbContextOptions<BlazorappDB> options) : base(options) { }
        public DbSet<salam> users { get; set; }

    }
}
