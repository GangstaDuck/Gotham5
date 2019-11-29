using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace app.persistence
{
    public class AppContext : DbContext
    {
        // Constructeur
        public AppContext(DbContextOptions<AppContext> options) : base(options) { }

        // Lors de la création d'un modèle, l'ajouter ici en suivant l'exemple ci-dessous :
        // public DbSet<app.domain.NomDuModèle> nomDuModèle { get; set; }
        // Le modèle doit absolument hériter de app.persistence.Entity
    }

    /*public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<AppContext>
    {
        public AppContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var builder = new DbContextOptionsBuilder<AppContext>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            builder.UseSqlServer(connectionString);
            return new AppContext(builder.Options);
        }
    }*/
}
