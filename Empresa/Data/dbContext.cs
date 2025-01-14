﻿using Empresa.Model;
using Microsoft.EntityFrameworkCore;

namespace Empresa.Data
{
    public class dbContext: DbContext
    {
        public dbContext(DbContextOptions<dbContext> options): base(options){}

        

        public DbSet<Empregado> Empregados { get; set; }
        public DbSet<Departamento> departamentos { get; set; }

    }
}
