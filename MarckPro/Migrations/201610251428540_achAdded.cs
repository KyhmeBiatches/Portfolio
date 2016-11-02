namespace MarckPro.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class achAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Achieveds",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        title = c.String(),
                        content = c.String(),
                        createdAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Achieveds");
        }
    }
}
