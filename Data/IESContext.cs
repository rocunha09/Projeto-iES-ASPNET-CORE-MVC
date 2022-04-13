using Microsoft.EntityFrameworkCore;
using Projeto_IES_ASPNET_CORE_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_IES_ASPNET_CORE_MVC.Data
{
    public class IESContext : DbContext
    {
        public DbSet<Instituicao> Instituicoes { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public IESContext(DbContextOptions<IESContext> options): base(options) {}
    }
}
