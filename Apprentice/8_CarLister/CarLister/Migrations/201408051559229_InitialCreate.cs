namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CarViewModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Year = c.String(nullable: false),
                        Make = c.String(nullable: false),
                        Model = c.String(nullable: false),
                        PicUrl = c.String(),
                        BookValue = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CarViewModels");
        }
    }
}
