namespace EFTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCategory : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            Sql("INSERT INTO Categories VALUES (3,'romance') ");
            Sql("INSERT INTO Categories VALUES(4, 'web development') ");
            Sql("INSERT INTO Categories VALUES (5,'romance') ");
            Sql("INSERT INTO Categories VALUES(6, 'web development') ");
        }
        
        public override void Down()
        {
            DropTable("dbo.Categories");
        }
    }
}
