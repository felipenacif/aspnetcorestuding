using AppStartCMD.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppStartCMD.Data
{
    public class AppStartCMDDbContext : DbContext
    {
        public AppStartCMDDbContext(DbContextOptions<AppStartCMDDbContext> options) : base(options)
        {

        }

        public DbSet<Materia> Materias { get; set; }
    }
}
