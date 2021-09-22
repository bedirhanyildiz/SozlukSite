namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Writers", "WriterSurname", c => c.String(maxLength: 50));
            DropColumn("dbo.Writers", "WriterSurmane");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Writers", "WriterSurmane", c => c.String(maxLength: 50));
            DropColumn("dbo.Writers", "WriterSurname");
        }
    }
}
