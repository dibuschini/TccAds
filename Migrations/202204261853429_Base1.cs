namespace TccAds.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Base1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Usuarios", "UsrData");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Usuarios", "UsrData", c => c.DateTime(nullable: false));
        }
    }
}
