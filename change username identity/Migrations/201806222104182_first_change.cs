namespace change_username_identity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first_change : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "UnConfirmedEmail", c => c.String(maxLength: 256));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "UnConfirmedEmail");
        }
    }
}
