namespace MentorIT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class User_Name1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AspNetUsers", "Name", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AspNetUsers", "Name", c => c.Int(nullable: false));
        }
    }
}
