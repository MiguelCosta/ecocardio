namespace EcoCardio.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class BodySurfaceFields : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Exame", "BodySurface", c => c.Double());
            AddColumn("dbo.Exame", "VolumeDiastolico", c => c.Int());
            AddColumn("dbo.Exame", "Height", c => c.Int());
            AddColumn("dbo.Exame", "Weight", c => c.Int());
        }

        public override void Down()
        {
            DropColumn("dbo.Exame", "Weight");
            DropColumn("dbo.Exame", "Height");
            DropColumn("dbo.Exame", "VolumeDiastolico");
            DropColumn("dbo.Exame", "BodySurface");
        }
    }
}
