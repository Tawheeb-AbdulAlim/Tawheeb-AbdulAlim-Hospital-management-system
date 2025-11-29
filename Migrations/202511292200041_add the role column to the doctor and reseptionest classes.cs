namespace Hospital_management_system.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addtherolecolumntothedoctorandreseptionestclasses : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "Role", c => c.Int(nullable: true));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "Role", c => c.String());
        }
    }
}
