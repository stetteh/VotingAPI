namespace VotingAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedenums : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Candidates", "HomeTown", c => c.Int(nullable: false));
            AlterColumn("dbo.Candidates", "District", c => c.Int(nullable: false));
            AlterColumn("dbo.Candidates", "Party", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Candidates", "Party", c => c.String());
            AlterColumn("dbo.Candidates", "District", c => c.String());
            AlterColumn("dbo.Candidates", "HomeTown", c => c.String());
        }
    }
}
