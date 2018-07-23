using DAL.Config;
using DAL.Migrations;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Context
{
    public partial class BookContext : DbContext
    {
         static BookContext()
         {
             Database.SetInitializer<BookContext>(null);
          
         }
         


        public BookContext()
            : base("Name=BookContext")
        {
            /* if (!Database.Exists("Book"))
                 Database.SetInitializer(new DropCreateDatabaseAlways<BookContext>()); }*/
        }


        public DbSet<Auteur> auteurs { get; set; }
        public DbSet<Livre> livres { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {


            modelBuilder.Configurations.Add(new AuteurMap());
            modelBuilder.Configurations.Add(new LivreMap());

        }
    }
}
