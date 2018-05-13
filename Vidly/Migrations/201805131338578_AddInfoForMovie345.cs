namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddInfoForMovie345 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, GenreId, DateAdded, ReleasedDate, NumberInStock) VALUES ('The Terminator (1984)', 1, CAST('2018-05-15' AS DATETIME), CAST('1984-12-20' AS DATETIME), 25)");
            Sql("INSERT INTO Movies (Name, GenreId, DateAdded, ReleasedDate, NumberInStock) VALUES ('Toy Story (1995)', 3, CAST('2018-05-15' AS DATETIME), CAST('1995-12-07' AS DATETIME), 21)");
            Sql("INSERT INTO Movies (Name, GenreId, DateAdded, ReleasedDate, NumberInStock) VALUES ('Titanic (1997)', 4, CAST('2018-05-16' AS DATETIME), CAST('1997-12-21' AS DATETIME), 28)");

        }
        
        public override void Down()
        {
        }
    }
}
