namespace Zero_Hunger_Mid.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class editannote2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Rests", "Address", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Rests", "Address", c => c.String());
        }
    }
}
