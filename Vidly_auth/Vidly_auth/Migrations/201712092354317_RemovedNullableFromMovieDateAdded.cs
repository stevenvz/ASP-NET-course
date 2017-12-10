namespace Vidly_auth.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedNullableFromMovieDateAdded : DbMigration
    {
        public override void Up()
        {
            Sql(@"UPDATE dbo.Movies SET DateAdded = CURRENT_TIMESTAMP WHERE DateAdded IS NULL");
            AlterColumn("dbo.Movies", "DateAdded", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "DateAdded", c => c.DateTime());
        }
    }
}
