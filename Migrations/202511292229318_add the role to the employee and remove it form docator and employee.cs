namespace Hospital_management_system.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addtheroletotheemployeeandremoveitformdocatorandemployee : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Doctors", "role", c => c.Int(nullable: true));
            AddColumn("dbo.reseptionists", "role", c => c.Int(nullable: true));
        }
        
        public override void Down()
        {
            DropColumn("dbo.reseptionists", "role");
            DropColumn("dbo.Doctors", "role");
        }
    }
}
