namespace Day4_UserAuth.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedBookDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Pages = c.Int(nullable: false),
                        Genre = c.String(),
                        OwnerId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.OwnerId)
                .Index(t => t.OwnerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "OwnerId", "dbo.AspNetUsers");
            DropIndex("dbo.Books", new[] { "OwnerId" });
            DropTable("dbo.Books");
        }
    }
}
