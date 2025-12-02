namespace Hospital_management_system.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialmegeration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Doctors", "Role", c => c.Int(nullable: false));
            AddColumn("dbo.reseptionists", "Role", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.reseptionists", "Role");
            DropColumn("dbo.Doctors", "Role");
        }
    }
}
