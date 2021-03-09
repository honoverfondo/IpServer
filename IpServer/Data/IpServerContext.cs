using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using IpServer.Models;

namespace IpServer.Data
{
    public class IpServerContext : DbContext
    {
        public IpServerContext (DbContextOptions<IpServerContext> options)
            : base(options)
        {
        }

        public DbSet<Marca> Marca { get; set; }
        public DbSet<Modelo> Modelo { get; set; }
    }
}
