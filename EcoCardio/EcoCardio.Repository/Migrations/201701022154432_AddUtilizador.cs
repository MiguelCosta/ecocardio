namespace EcoCardio.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUtilizador : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Servicoes", newName: "Servico");
            CreateTable(
                "dbo.Utilizador",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 256),
                        Password = c.String(nullable: false, maxLength: 256),
                        Username = c.String(nullable: false, maxLength: 256),
                        Profile = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Username, unique: true);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Utilizador", new[] { "Username" });
            DropTable("dbo.Utilizador");
            RenameTable(name: "dbo.Servico", newName: "Servicoes");
        }
    }
}
