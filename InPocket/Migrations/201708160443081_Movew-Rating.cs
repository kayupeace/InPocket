namespace InPocket.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MovewRating : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Rating", c => c.String(maxLength: 5));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "Rating");
        }
    }
}
