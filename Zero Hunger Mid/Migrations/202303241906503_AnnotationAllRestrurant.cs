namespace Zero_Hunger_Mid.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AnnotationAllRestrurant : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Rests", "Address", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Rests", "PhoneNum", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Rests", "PhoneNum", c => c.String());
            AlterColumn("dbo.Rests", "Address", c => c.String(nullable: false));
        }
    }
}
