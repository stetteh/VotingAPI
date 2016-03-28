namespace VotingAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class votestable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Votes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        candiate_Id = c.Int(),
                        voter_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Candidates", t => t.candiate_Id)
                .ForeignKey("dbo.Voters", t => t.voter_Id)
                .Index(t => t.candiate_Id)
                .Index(t => t.voter_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Votes", "voter_Id", "dbo.Voters");
            DropForeignKey("dbo.Votes", "candiate_Id", "dbo.Candidates");
            DropIndex("dbo.Votes", new[] { "voter_Id" });
            DropIndex("dbo.Votes", new[] { "candiate_Id" });
            DropTable("dbo.Votes");
        }
    }
}
