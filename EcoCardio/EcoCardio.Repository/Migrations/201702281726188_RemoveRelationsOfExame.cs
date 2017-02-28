namespace EcoCardio.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveRelationsOfExame : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Exame", "ServicoId", "dbo.Servico");
            DropForeignKey("dbo.Exame", "TransmissaoAcusticaId", "dbo.TransmissaoAcustica");
            DropIndex("dbo.Exame", new[] { "ServicoId" });
            DropIndex("dbo.Exame", new[] { "TransmissaoAcusticaId" });
            AddColumn("dbo.Exame", "RequisitadoPor", c => c.String());
            AddColumn("dbo.Exame", "TransmissaoAcustica", c => c.String());
            DropColumn("dbo.Exame", "ServicoId");
            DropColumn("dbo.Exame", "TransmissaoAcusticaId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Exame", "TransmissaoAcusticaId", c => c.Int());
            AddColumn("dbo.Exame", "ServicoId", c => c.Int());
            DropColumn("dbo.Exame", "TransmissaoAcustica");
            DropColumn("dbo.Exame", "RequisitadoPor");
            CreateIndex("dbo.Exame", "TransmissaoAcusticaId");
            CreateIndex("dbo.Exame", "ServicoId");
            AddForeignKey("dbo.Exame", "TransmissaoAcusticaId", "dbo.TransmissaoAcustica", "Id");
            AddForeignKey("dbo.Exame", "ServicoId", "dbo.Servico", "Id");
        }
    }
}
