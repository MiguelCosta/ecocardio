namespace EcoCardio.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveUtente : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Exame", "UtenteId", "dbo.Utente");
            DropIndex("dbo.Exame", new[] { "UtenteId" });
            AddColumn("dbo.Exame", "DataNascimento", c => c.DateTime());
            AddColumn("dbo.Exame", "Email", c => c.String());
            AddColumn("dbo.Exame", "FirstName", c => c.String());
            AddColumn("dbo.Exame", "LastName", c => c.String());
            AddColumn("dbo.Exame", "Morada", c => c.String());
            AddColumn("dbo.Exame", "NumeroSNS", c => c.String());
            AddColumn("dbo.Exame", "Telefone", c => c.String());
            AddColumn("dbo.Exame", "Telemovel", c => c.String());
            AlterColumn("dbo.Exame", "Nome", c => c.String());
            DropColumn("dbo.Exame", "UtenteId");
            DropTable("dbo.Utente");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Utente",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DataNascimento = c.DateTime(),
                        Email = c.String(maxLength: 1024),
                        FirstName = c.String(maxLength: 1024),
                        Genre = c.Int(nullable: false),
                        LastName = c.String(maxLength: 1024),
                        Morada = c.String(),
                        Nome = c.String(nullable: false),
                        NumeroProcesso = c.Int(),
                        NumeroSNS = c.String(maxLength: 1024),
                        Telefone = c.String(maxLength: 1024),
                        Telemovel = c.String(maxLength: 1024),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Exame", "UtenteId", c => c.Int(nullable: false));
            AlterColumn("dbo.Exame", "Nome", c => c.String(maxLength: 1024));
            DropColumn("dbo.Exame", "Telemovel");
            DropColumn("dbo.Exame", "Telefone");
            DropColumn("dbo.Exame", "NumeroSNS");
            DropColumn("dbo.Exame", "Morada");
            DropColumn("dbo.Exame", "LastName");
            DropColumn("dbo.Exame", "FirstName");
            DropColumn("dbo.Exame", "Email");
            DropColumn("dbo.Exame", "DataNascimento");
            CreateIndex("dbo.Exame", "UtenteId");
            AddForeignKey("dbo.Exame", "UtenteId", "dbo.Utente", "Id", cascadeDelete: true);
        }
    }
}
