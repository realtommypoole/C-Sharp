namespace PingPong.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class emaiToPlaye : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Player", "Email", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Player", "Email");
        }
    }
}
