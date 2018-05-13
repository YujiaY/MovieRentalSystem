namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddInfoForMovie1 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, GenreId, DateAdded, ReleasedDate, NumberInStock) VALUES ('Handover', 5, CAST('2018-05-12' AS DATETIME), CAST('2009-11-06' AS DATETIME), 5)");
        }
        
        public override void Down()
        {
        }
    }
}
