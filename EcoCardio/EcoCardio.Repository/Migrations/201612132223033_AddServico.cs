namespace EcoCardio.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class AddServico : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Servicoes",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Nome = c.String(),
                    Tipo = c.String(),
                })
                .PrimaryKey(t => t.Id);

        }

        public override void Down()
        {
            DropTable("dbo.Servicoes");
        }
    }
}
