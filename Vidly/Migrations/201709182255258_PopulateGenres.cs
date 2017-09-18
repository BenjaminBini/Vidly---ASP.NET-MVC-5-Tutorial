namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class PopulateGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO genres (Name) values ('Comedy')");
            Sql("INSERT INTO genres (Name) values ('Drama')");
            Sql("INSERT INTO genres (Name) values ('Thriller')");
        }

        public override void Down()
        {
        }
    }
}