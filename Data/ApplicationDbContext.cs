 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
 using Microsoft.EntityFrameworkCore;
 using PracticandoPuntoNetCore.Models;

 namespace PracticandoPuntoNetCore.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        //esta linea de codigo es muy importante a la hora de crear o migrar nuestra BD 
        public DbSet<Libro> Libro { get; set; }
    }
}
