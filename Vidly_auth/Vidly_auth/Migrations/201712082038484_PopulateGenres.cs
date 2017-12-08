namespace Vidly_auth.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'Action/Adventure')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (2, 'Sci-Fi')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (3, 'Comedy')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (4, 'Drama')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (5, 'Family')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (6, 'Romance')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (7, 'Horror')");
        }
        
        public override void Down()
        {
        }
    }
}
