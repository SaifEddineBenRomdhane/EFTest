namespace EFTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRefranceToTag : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tags", "Refrance", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tags", "Refrance");
        }
    }
}
