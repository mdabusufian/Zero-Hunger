namespace Zero_Hunger_Mid.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DBcreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FoodCollects",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        ExpierdDate = c.DateTime(nullable: false),
                        IsCollected = c.Boolean(nullable: false),
                        RestId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Rests", t => t.RestId, cascadeDelete: true)
                .Index(t => t.RestId);
            
            CreateTable(
                "dbo.Rests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        PhoneNum = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FoodCollects", "RestId", "dbo.Rests");
            DropIndex("dbo.FoodCollects", new[] { "RestId" });
            DropTable("dbo.Rests");
            DropTable("dbo.FoodCollects");
        }
    }
}
