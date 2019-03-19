namespace EFTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameTitleToNameInCourse : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "Name", c => c.String(nullable: false));
            DropColumn("dbo.Courses", "Title");
            //This Line Of Code The Same Job As The 1st 2 Lines
            //RenameColumn("dbo.Courses", "Title", "Name");
            //Or Even Use SQl();
            //sql("UPDATE Courses SET Name = Title");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Courses", "Title", c => c.String(nullable:false));
            DropColumn("dbo.Courses", "Name");
            // This Line Of Code The Same Job As The 1st 2 Lines
            //RenameColumn("dbo.Courses","Name", "Title" );
            //Or Even Use SQl();
            //sql("UPDATE Courses SET Title = Name");
        }
    }
}
