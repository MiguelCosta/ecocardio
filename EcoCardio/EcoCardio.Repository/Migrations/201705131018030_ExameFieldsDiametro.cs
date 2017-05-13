namespace EcoCardio.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ExameFieldsDiametro : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Exame", "DiametroAortaAscendente", c => c.Int());
            AddColumn("dbo.Exame", "DiametroAuriculaEsquerda1", c => c.Int());
            AddColumn("dbo.Exame", "DiametroAuriculaEsquerda2", c => c.Int());
            AddColumn("dbo.Exame", "DiametroFuncaoVd", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Exame", "DiametroFuncaoVd");
            DropColumn("dbo.Exame", "DiametroAuriculaEsquerda2");
            DropColumn("dbo.Exame", "DiametroAuriculaEsquerda1");
            DropColumn("dbo.Exame", "DiametroAortaAscendente");
        }
    }
}
