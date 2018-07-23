using DAL.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Config
{
    public class LivreMap : EntityTypeConfiguration<Livre>
    {
        public LivreMap()
        {
            // Primary Key
            this.HasKey(t => t.LivreId);

            // Properties

            this.Property(t => t.NomLivre)
          .IsRequired()
          .HasMaxLength(100);
            this.Property(t => t.date);
                

            

            // Table & Column Mappings
            this.ToTable("Livre");



            //relationShips
            this.HasRequired(t => t.auteur)
                .WithMany(t => t.livres)
                .HasForeignKey(t => t.Auteur_Id)
                .WillCascadeOnDelete(true);
        }
    }
}
