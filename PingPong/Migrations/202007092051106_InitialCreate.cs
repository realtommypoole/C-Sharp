namespace PingPong.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Player",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TeamID = c.Int(),
                        LastName = c.String(),
                        FirstName = c.String(),
                        RightHand = c.Boolean(nullable: false),
                        DateOfBirth = c.DateTime(nullable: false),
                        Secret = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Team",
                c => new
                    {
                        TeamID = c.Int(nullable: false, identity: true),
                        TeamName = c.String(),
                        League = c.Int(),
                    })
                .PrimaryKey(t => t.TeamID);
            
            CreateTable(
                "dbo.TeamPlayer",
                c => new
                    {
                        Team_TeamID = c.Int(nullable: false),
                        Player_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Team_TeamID, t.Player_ID })
                .ForeignKey("dbo.Team", t => t.Team_TeamID, cascadeDelete: true)
                .ForeignKey("dbo.Player", t => t.Player_ID, cascadeDelete: true)
                .Index(t => t.Team_TeamID)
                .Index(t => t.Player_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TeamPlayer", "Player_ID", "dbo.Player");
            DropForeignKey("dbo.TeamPlayer", "Team_TeamID", "dbo.Team");
            DropIndex("dbo.TeamPlayer", new[] { "Player_ID" });
            DropIndex("dbo.TeamPlayer", new[] { "Team_TeamID" });
            DropTable("dbo.TeamPlayer");
            DropTable("dbo.Team");
            DropTable("dbo.Player");
        }
    }
}
