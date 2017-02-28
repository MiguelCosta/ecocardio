namespace EcoCardio.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFieldsExame : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Exame", "Genre", c => c.Int(nullable: false));
            AddColumn("dbo.Exame", "InfoClinica", c => c.String());
            AddColumn("dbo.Exame", "Medico1", c => c.String());
            AddColumn("dbo.Exame", "Medico2", c => c.String());
            AddColumn("dbo.Exame", "Pericardio", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Exame", "Pericardio");
            DropColumn("dbo.Exame", "Medico2");
            DropColumn("dbo.Exame", "Medico1");
            DropColumn("dbo.Exame", "InfoClinica");
            DropColumn("dbo.Exame", "Genre");
        }
    }
}
