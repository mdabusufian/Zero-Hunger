namespace Zero_Hunger_Mid.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class annoteCreate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Rests", "Name", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Rests", "Name", c => c.String());
        }
    }
}
