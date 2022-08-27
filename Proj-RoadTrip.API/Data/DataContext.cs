using Microsoft.EntityFrameworkCore;
using Proj_RoadTrip.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proj_RoadTrip.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        
        public DbSet<Cliente> Clientes { get; set; }
    }
}
