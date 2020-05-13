using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventosTec.Web.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace EventosTec.Web.Models
{
    public class DataDbContext: DbContext
    {
        public DataDbContext (DbContextOptions<DataDbContext> options): base(options)
        {

        }
        public DbSet<Client> Clients { get; set; }
        public DbSet<City> Clities { get; set; }
        public DbSet<Event> Events { get; set; }

        public DbSet<Category> Categories { get; set; }
    }
}
