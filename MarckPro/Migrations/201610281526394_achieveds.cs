namespace MarckPro.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class achieveds : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PicVidModels",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PicVidModels");
        }
    }
}
