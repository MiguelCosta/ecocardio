namespace EcoCardio.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ServicoTipo : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE dbo.Servico SET Tipo = 0;");
            AlterColumn("dbo.Servico", "Tipo", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Servico", "Tipo", c => c.String(maxLength: 1024));
        }
    }
}
