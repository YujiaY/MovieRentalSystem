namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditInfoAgainForMovie2 : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Movies SET Name = 'Die Hard(1988)', GenreId = 1, DateAdded  = CAST('2018-05-13' AS DATETIME),  ReleasedDate = CAST(' 1988-10-06' AS DATETIME), NumberInStock = 10 WHERE Id = 2");
        }
        
        public override void Down()
        {
        }
    }
}
