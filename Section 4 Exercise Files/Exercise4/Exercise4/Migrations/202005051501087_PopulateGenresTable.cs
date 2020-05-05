namespace Exercise4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres VALUES ('Horror')");
            Sql("INSERT INTO Genres VALUES ('Action')");
            Sql("INSERT INTO Genres VALUES ('SciFi')");
            Sql("INSERT INTO Genres VALUES ('Romance')");
            Sql("INSERT INTO Genres VALUES ('Fiction')");
            Sql("INSERT INTO Genres VALUES ('Nonfiction')");
            Sql("INSERT INTO Genres VALUES ('Comedy')");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM Genres WHERE Name = 'Horror'");
            Sql("DELETE FROM Genres WHERE Name = 'Action'");
            Sql("DELETE FROM Genres WHERE Name = 'SciFi'");
            Sql("DELETE FROM Genres WHERE Name = 'Romance'");
            Sql("DELETE FROM Genres WHERE Name = 'Fiction'");
            Sql("DELETE FROM Genres WHERE Name = 'Nonfiction'");
            Sql("DELETE FROM Genres WHERE Name = 'Comedy'");
        }
    }
}
