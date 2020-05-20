namespace Vidzy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstRun : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Tags", "Name", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Tags", "Name", c => c.String(nullable: false, maxLength: 255));
        }
    }
}
