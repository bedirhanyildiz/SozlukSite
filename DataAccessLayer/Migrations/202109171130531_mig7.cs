namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig7 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Headings", "HeadingStatus", c => c.Boolean(nullable: false));
            DropColumn("dbo.Headings", "HeadinStatus");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Headings", "HeadinStatus", c => c.Boolean(nullable: false));
            DropColumn("dbo.Headings", "HeadingStatus");
        }
    }
}
