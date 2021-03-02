using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carflix.Api.Models
{
    public class CarflixContext : DbContext
    {
        public CarflixContext(DbContextOptions<CarflixContext> options)
      : base(options)
        { }

        public DbSet<Endereco> Endereco { get; set; }
    }
}
