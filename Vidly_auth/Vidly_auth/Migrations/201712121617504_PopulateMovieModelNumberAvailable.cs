namespace Vidly_auth.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovieModelNumberAvailable : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Movies SET NumberAvailable = NumberInStock WHERE NumberAvailable=0");
        }
        
        public override void Down()
        {
        }
    }
}
