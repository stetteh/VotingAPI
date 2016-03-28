namespace VotingAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class candidatetable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Candidates",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        HomeTown = c.String(),
                        District = c.String(),
                        Party = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Candidates");
        }
    }
}
