namespace EcoCardio.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFieldExameMassaVE : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Exame", "MassaVE", c => c.Double());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Exame", "MassaVE");
        }
    }
}
