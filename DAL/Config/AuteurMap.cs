using DAL.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Config
{
    public class AuteurMap : EntityTypeConfiguration<Auteur>
    {
        public AuteurMap()
        {
            // Primary Key
            this.HasKey(t => t.AuteurId);

            // Properties

            this.Property(t => t.NomAuteur)
          .IsRequired()
          .HasMaxLength(100);
            this.Property(t => t.prenomAuteur)
         .IsRequired()
         .HasMaxLength(100);




            // Table & Column Mappings
            this.ToTable("Auteur");
        }
    }
}
