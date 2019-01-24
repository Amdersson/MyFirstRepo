namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class INITIAL : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Demoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MyProperty1 = c.Int(nullable: false),
                        MyProperty2 = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Demoes");
        }
    }
}
