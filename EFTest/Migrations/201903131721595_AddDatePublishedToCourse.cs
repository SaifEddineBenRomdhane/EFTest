namespace EFTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDatePublishedToCourse : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "DatePablished", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Courses", "DatePablished");
        }
    }
}
