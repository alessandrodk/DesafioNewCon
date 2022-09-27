using Business;
using Business.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess.Context
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> dbOptions) : base(dbOptions){}

        public DbSet<PontoTuristico > Cursos { get; set; }
      

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

                


        }

    }
}
