namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Auteur",
                c => new
                    {
                        AuteurId = c.Int(nullable: false, identity: true),
                        NomAuteur = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        prenomAuteur = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.AuteurId);
            
            CreateTable(
                "dbo.Livre",
                c => new
                    {
                        LivreId = c.Int(nullable: false, identity: true),
                        NomLivre = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        date = c.DateTime(nullable: false, precision: 0),
                        Auteur_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.LivreId)
                .ForeignKey("dbo.Auteur", t => t.Auteur_Id, cascadeDelete: true)
                .Index(t => t.Auteur_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Livre", "Auteur_Id", "dbo.Auteur");
            DropIndex("dbo.Livre", new[] { "Auteur_Id" });
            DropTable("dbo.Livre");
            DropTable("dbo.Auteur");
        }
    }
}
