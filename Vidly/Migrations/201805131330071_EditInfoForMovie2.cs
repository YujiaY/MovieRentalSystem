namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditInfoForMovie2 : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Movies SET Name = 'Die Hard (1988)' WHERE Id = 2");
            Sql("UPDATE Movies SET GenreId = 1 WHERE Id = 2");
            Sql("UPDATE Movies SET DateAdded  = CAST('2018-05-15' AS DATETIME) WHERE Id = 2");
            Sql("UPDATE Movies SET ReleasedDate = CAST(' 1988-10-06' AS DATETIME) WHERE Id = 2");
            Sql("UPDATE Movies SET NumberInStock = 13 WHERE Id = 2");
        }

        public override void Down()
        {
        }
    }
}
