namespace OneToOneRel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReviewEntity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Review",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Content = c.String(),
                        EntityName = c.String(),
                        EntityId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Review");
        }
    }
}
