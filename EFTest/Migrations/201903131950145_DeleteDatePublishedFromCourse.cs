namespace EFTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteDatePublishedFromCourse : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Courses", "DatePablished");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Courses", "DatePablished", c => c.DateTime());
        }
    }
}
