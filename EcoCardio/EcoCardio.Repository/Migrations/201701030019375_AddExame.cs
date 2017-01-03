namespace EcoCardio.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddExame : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Exame",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CavidadesCardiacas = c.String(),
                        Conclusao = c.String(),
                        Data = c.DateTime(nullable: false),
                        DiametroAorta = c.Int(),
                        DiametroAuriculaEsquerda = c.Int(),
                        DiametroParedePosterior = c.Int(),
                        DiametroSepto = c.Int(),
                        DiametroVETeleadiastole = c.Int(),
                        DiametroVETelessistole = c.Int(),
                        EspessuraParedesVentriculares = c.String(),
                        EstruturasValvulares = c.String(),
                        FracaoEjecao = c.Int(),
                        FracaoEncurtamento = c.Int(),
                        FuncaoVentricular = c.String(),
                        Idade = c.Int(),
                        MassasIntracavitarias = c.String(),
                        Nome = c.String(maxLength: 1024),
                        Numero = c.Int(nullable: false),
                        NumeroProcesso = c.Int(),
                        Observacao = c.String(),
                        ServicoId = c.Int(),
                        TransmissaoAcusticaId = c.Int(),
                        UtenteId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Servico", t => t.ServicoId)
                .ForeignKey("dbo.TransmissaoAcustica", t => t.TransmissaoAcusticaId)
                .ForeignKey("dbo.Utente", t => t.UtenteId, cascadeDelete: true)
                .Index(t => t.ServicoId)
                .Index(t => t.TransmissaoAcusticaId)
                .Index(t => t.UtenteId);
            
            CreateTable(
                "dbo.TransmissaoAcustica",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 1024),
                    })
                .PrimaryKey(t => t.Id);
            
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
            
            CreateTable(
                "dbo.Responsavel",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 1024),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Template",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 1024),
                        Texto = c.String(),
                        Type = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AlterColumn("dbo.Servico", "Nome", c => c.String(nullable: false, maxLength: 1024));
            AlterColumn("dbo.Servico", "Tipo", c => c.String(maxLength: 1024));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Exame", "UtenteId", "dbo.Utente");
            DropForeignKey("dbo.Exame", "TransmissaoAcusticaId", "dbo.TransmissaoAcustica");
            DropForeignKey("dbo.Exame", "ServicoId", "dbo.Servico");
            DropIndex("dbo.Exame", new[] { "UtenteId" });
            DropIndex("dbo.Exame", new[] { "TransmissaoAcusticaId" });
            DropIndex("dbo.Exame", new[] { "ServicoId" });
            AlterColumn("dbo.Servico", "Tipo", c => c.String());
            AlterColumn("dbo.Servico", "Nome", c => c.String());
            DropTable("dbo.Template");
            DropTable("dbo.Responsavel");
            DropTable("dbo.Utente");
            DropTable("dbo.TransmissaoAcustica");
            DropTable("dbo.Exame");
        }
    }
}
