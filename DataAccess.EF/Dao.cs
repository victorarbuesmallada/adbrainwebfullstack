using Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataAccess.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.EF.Config
{
    /// <summary>
    /// Dao class with sets and configuration
    /// </summary>
    public abstract class Dao : DbContext
    {

        public DbSet<Item> Items { get; set; }
        public DbSet<Author> Authors { get; set; }

        public Dao()
            : base("DefaultContext")
        {
        }

        static Dao()
        {
            var type = typeof(System.Data.Entity.SqlServer.SqlProviderServices);
            Database.SetInitializer<Dao>(null);
        }

        /// <summary>
        /// Configure the model scheme
        /// </summary>
        /// <param name="modelBuilder">Db schema builder</param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            ConfigureModels(modelBuilder);
        }

        private void ConfigureModels(DbModelBuilder dbBuilder)
        {
            //Item config
            dbBuilder.Entity<Item>().HasKey(i => i.Id).Property(p => p.Id).
                HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            dbBuilder.Entity<Item>().HasRequired(i => i.Author)
                .WithMany(a => a.Items)
                .HasForeignKey(i => i.AuthorName);

            //Author config
            dbBuilder.Entity<Author>().HasKey(a => a.Name).Property(p => p.Name).
                HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            dbBuilder.Entity<Author>().HasMany(a => a.Items);
        }

    }
}
